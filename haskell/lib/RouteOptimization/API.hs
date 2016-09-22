{-# LANGUAGE DataKinds, TypeFamilies, TypeOperators, FlexibleInstances, OverloadedStrings, ViewPatterns #-}
{-# LANGUAGE RecordWildCards, GeneralizedNewtypeDeriving, DeriveTraversable, FlexibleContexts, DeriveGeneric #-}
{-# OPTIONS_GHC -fno-warn-unused-binds -fno-warn-unused-imports -fcontext-stack=304 #-}
module RouteOptimization.API (
  -- * Client and Server
  ServerConfig(..),
  RouteOptimizationBackend,
  createRouteOptimizationClient,
  runRouteOptimizationServer,
  runRouteOptimizationClient,
  runRouteOptimizationClientWithManager,
  RouteOptimizationClient,
  -- ** Servant
  RouteOptimizationAPI,
  ) where

import RouteOptimization.Types

import Data.Aeson (Value)
import Data.Coerce (coerce)
import Servant.API
import Servant (serve, ServantErr)
import Web.HttpApiData
import qualified Network.Wai.Handler.Warp as Warp
import qualified Data.Text as T
import Data.Text (Text)
import Servant.Common.BaseUrl(BaseUrl(..))
import Servant.Client (ServantError, client, Scheme(Http))
import Data.Proxy (Proxy(..))
import Control.Monad.IO.Class
import Data.Function ((&))
import GHC.Exts (IsString(..))
import qualified Data.Map as Map
import GHC.Generics (Generic)
import Data.Monoid ((<>))
import Servant.API.Verbs (Verb, StdMethod(..))
import Control.Monad.Except (ExceptT)
import Network.HTTP.Client (Manager, newManager, defaultManagerSettings)
import Network.HTTP.Types.Method (methodOptions)

instance ReflectMethod 'OPTIONS where
  reflectMethod _ = methodOptions




-- For the form data code generation.
lookupEither :: FromHttpApiData b => Text -> [(Text, Text)] -> Either Text b
lookupEither key assocs =
  case lookup key assocs of
    Nothing -> Left $ "Could not find parameter " <> key <> " in form data"
    Just value -> parseQueryParam value

-- | Servant type-level API, generated from the Swagger spec for RouteOptimization.
type RouteOptimizationAPI
    =    "solution" :> Capture "jobId" Text :> QueryParam "key" Text :> Verb 'GET 200 '[JSON] Response -- 'getSolution' route
    :<|> "optimize" :> QueryParam "key" Text :> ReqBody '[JSON] Request :> Verb 'POST 200 '[JSON] JobId -- 'postVrp' route

-- | Server or client configuration, specifying the host and port to query or serve on.
data ServerConfig = ServerConfig {
    configHost :: String,  -- ^ Hostname to serve on, e.g. "127.0.0.1"
    configPort :: Int      -- ^ Port to serve on, e.g. 8080
  } deriving (Eq, Ord, Show, Read)

-- | List of elements parsed from a query.
newtype QueryList (p :: CollectionFormat) a = QueryList { fromQueryList :: [a] }
  deriving (Functor, Applicative, Monad, Foldable, Traversable)

-- | Formats in which a list can be encoded into a HTTP path.
data CollectionFormat = CommaSeparated -- ^ CSV format for multiple parameters.
                      | SpaceSeparated -- ^ Also called "SSV"
                      | TabSeparated -- ^ Also called "TSV"
                      | PipeSeparated -- ^ `value1|value2|value2`
                      | MultiParamArray -- ^ Using multiple GET parameters, e.g. `foo=bar&foo=baz`. Only for GET params.

instance FromHttpApiData a => FromHttpApiData (QueryList 'CommaSeparated a) where
    parseQueryParam = parseSeparatedQueryList ','

instance FromHttpApiData a => FromHttpApiData (QueryList 'TabSeparated a) where
    parseQueryParam = parseSeparatedQueryList '\t'

instance FromHttpApiData a => FromHttpApiData (QueryList 'SpaceSeparated a) where
    parseQueryParam = parseSeparatedQueryList ' '

instance FromHttpApiData a => FromHttpApiData (QueryList 'PipeSeparated a) where
    parseQueryParam = parseSeparatedQueryList '|'

instance FromHttpApiData a => FromHttpApiData (QueryList 'MultiParamArray a) where
    parseQueryParam = error "unimplemented FromHttpApiData for MultiParamArray collection format"

parseSeparatedQueryList :: FromHttpApiData a => Char -> Text -> Either Text (QueryList p a)
parseSeparatedQueryList char = fmap QueryList . mapM parseQueryParam . T.split (== char)

instance ToHttpApiData a => ToHttpApiData (QueryList 'CommaSeparated a) where
    toQueryParam = formatSeparatedQueryList ','

instance ToHttpApiData a => ToHttpApiData (QueryList 'TabSeparated a) where
    toQueryParam = formatSeparatedQueryList '\t'

instance ToHttpApiData a => ToHttpApiData (QueryList 'SpaceSeparated a) where
    toQueryParam = formatSeparatedQueryList ' '

instance ToHttpApiData a => ToHttpApiData (QueryList 'PipeSeparated a) where
    toQueryParam = formatSeparatedQueryList '|'

instance ToHttpApiData a => ToHttpApiData (QueryList 'MultiParamArray a) where
    toQueryParam = error "unimplemented ToHttpApiData for MultiParamArray collection format"

formatSeparatedQueryList :: ToHttpApiData a => Char ->  QueryList p a -> Text
formatSeparatedQueryList char = T.intercalate (T.singleton char) . map toQueryParam . fromQueryList


-- | Backend for RouteOptimization.
-- The backend can be used both for the client and the server. The client generated from the RouteOptimization Swagger spec
-- is a backend that executes actions by sending HTTP requests (see @createRouteOptimizationClient@). Alternatively, provided
-- a backend, the API can be served using @runRouteOptimizationServer@.
data RouteOptimizationBackend m = RouteOptimizationBackend {
    getSolution :: Text -> Maybe Text -> m Response{- ^ This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.  -},
    postVrp :: Maybe Text -> Request -> m JobId{- ^ This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.  -}
  }

newtype RouteOptimizationClient a = RouteOptimizationClient { runClient :: Manager -> BaseUrl -> ExceptT ServantError IO a }
    deriving Functor

instance Applicative RouteOptimizationClient where
    pure x = RouteOptimizationClient (\_ _ -> pure x)
    (RouteOptimizationClient f) <*> (RouteOptimizationClient x) = RouteOptimizationClient (\manager url -> f manager url <*> x manager url)

instance Monad RouteOptimizationClient where
    (RouteOptimizationClient a) >>= f = RouteOptimizationClient (\manager url -> do
        value <- a manager url
        runClient (f value) manager url)

instance MonadIO RouteOptimizationClient where
    liftIO io = RouteOptimizationClient (\_ _ -> liftIO io)

createRouteOptimizationClient :: RouteOptimizationBackend RouteOptimizationClient
createRouteOptimizationClient = RouteOptimizationBackend{..}
  where
    ((coerce -> getSolution) :<|>
     (coerce -> postVrp)) = client (Proxy :: Proxy RouteOptimizationAPI)

-- | Run requests in the RouteOptimizationClient monad.
runRouteOptimizationClient :: ServerConfig -> RouteOptimizationClient a -> ExceptT ServantError IO a
runRouteOptimizationClient clientConfig cl = do
  manager <- liftIO $ newManager defaultManagerSettings
  runRouteOptimizationClientWithManager manager clientConfig cl

-- | Run requests in the RouteOptimizationClient monad using a custom manager.
runRouteOptimizationClientWithManager :: Manager -> ServerConfig -> RouteOptimizationClient a -> ExceptT ServantError IO a
runRouteOptimizationClientWithManager manager clientConfig cl =
  runClient cl manager $ BaseUrl Http (configHost clientConfig) (configPort clientConfig) ""

-- | Run the RouteOptimization server at the provided host and port.
runRouteOptimizationServer :: MonadIO m => ServerConfig -> RouteOptimizationBackend (ExceptT ServantErr IO)  -> m ()
runRouteOptimizationServer ServerConfig{..} backend =
  liftIO $ Warp.runSettings warpSettings $ serve (Proxy :: Proxy RouteOptimizationAPI) (serverFromBackend backend)

  where
    warpSettings = Warp.defaultSettings & Warp.setPort configPort & Warp.setHost (fromString configHost)
    serverFromBackend RouteOptimizationBackend{..} =
      (coerce getSolution :<|>
       coerce postVrp)
