{-# LANGUAGE DeriveGeneric #-}
{-# LANGUAGE GeneralizedNewtypeDeriving #-}
{-# OPTIONS_GHC -fno-warn-unused-binds -fno-warn-unused-imports #-}

module RouteOptimization.Types (
    Activity (..),
    Address (..),
    Algorithm (..),
    Break (..),
    CostMatrix (..),
    JobId (..),
    Objective (..),
    Relation (..),
    Request (..),
    Response (..),
    Route (..),
    Service (..),
    Shipment (..),
    Solution (..),
    Solution_unassigned (..),
    Stop (..),
    TimeWindow (..),
    Vehicle (..),
    VehicleType (..),
    ) where

import Data.List (stripPrefix)
import Data.Maybe (fromMaybe)
import Data.Aeson (Value, FromJSON(..), ToJSON(..), genericToJSON, genericParseJSON)
import Data.Aeson.Types (Options(..), defaultOptions)
import Data.Text (Text)
import qualified Data.Text as T
import qualified Data.Map as Map
import GHC.Generics (Generic)
import Data.Function ((&))


-- | 
data Activity = Activity
    { activityType_ :: Text -- ^ type of activity
    , activityId :: Text -- ^ id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to
    , activityLocationId :: Text -- ^ id that refers to address
    , activityArrTime :: Integer -- ^ arrival time at this activity in ms
    , activityEndTime :: Integer -- ^ end time of and thus departure time at this activity
    , activityWaitingTime :: Integer -- ^ waiting time at this activity in ms
    , activityDistance :: Integer -- ^ cumulated distance from start to this activity in m
    , activityDrivingTime :: Integer -- ^ driving time of driver in ms
    , activityLoadBefore :: [Int] -- ^ Array with size/capacity dimensions before this activity
    , activityLoadAfter :: [Int] -- ^ Array with size/capacity dimensions after this activity
    } deriving (Show, Eq, Generic)

instance FromJSON Activity where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "activity")
instance ToJSON Activity where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "activity")

-- | 
data Address = Address
    { addressLocationId :: Text -- ^ Unique identifier of location
    , addressLon :: Double -- ^ longitude
    , addressLat :: Double -- ^ latitude
    } deriving (Show, Eq, Generic)

instance FromJSON Address where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "address")
instance ToJSON Address where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "address")

-- | 
data Algorithm = Algorithm
    { algorithmProblemType :: Text -- ^ 
    , algorithmObjective :: Text -- ^ 
    } deriving (Show, Eq, Generic)

instance FromJSON Algorithm where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "algorithm")
instance ToJSON Algorithm where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "algorithm")

-- | 
data Break = Break
    { breakEarliest :: Integer -- ^ earliest start of break
    , breakLatest :: Integer -- ^ latest start of break
    , breakDuration :: Integer -- ^ duration of break
    , breakMaxDrivingTime :: Integer -- ^ max driving time without break
    , breakInitialDrivingTime :: Integer -- ^ initial driving time, i.e. the time your driver has already spent for driving
    , breakPossibleSplit :: [Integer] -- ^ array of splits
    } deriving (Show, Eq, Generic)

instance FromJSON Break where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "break")
instance ToJSON Break where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "break")

-- | 
data CostMatrix = CostMatrix
    { costMatrixType_ :: Text -- ^ type of cost matrix, currently default or google are supported
    , costMatrixUrl :: Text -- ^ URL of matrix service
    , costMatrixProfile :: Text -- ^ vehicle profile or empty if catch all fallback
    } deriving (Show, Eq, Generic)

instance FromJSON CostMatrix where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "costMatrix")
instance ToJSON CostMatrix where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "costMatrix")

-- | 
data JobId = JobId
    { jobIdJobId :: Text -- ^ unique id for your job/request with which you can fetch your solution
    } deriving (Show, Eq, Generic)

instance FromJSON JobId where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "jobId")
instance ToJSON JobId where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "jobId")

-- | 
data Objective = Objective
    { objectiveType_ :: Text -- ^ type of objective function, i.e. min or min-max 
    , objectiveValue :: Text -- ^ objective function value
    } deriving (Show, Eq, Generic)

instance FromJSON Objective where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "objective")
instance ToJSON Objective where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "objective")

-- | 
data Relation = Relation
    { relationType_ :: Text -- ^ identifier of relation
    , relationIds :: [Text] -- ^ An array of ids that should be related
    , relationVehicleId :: Text -- ^ vehicle id
    } deriving (Show, Eq, Generic)

instance FromJSON Relation where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "relation")
instance ToJSON Relation where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "relation")

-- | 
data Request = Request
    { requestVehicles :: [Vehicle] -- ^ An array of vehicles that can be employed
    , requestVehicleTypes :: [VehicleType] -- ^ An array of vehicle types
    , requestServices :: [Service] -- ^ An array of services
    , requestShipments :: [Shipment] -- ^ An array of shipments
    , requestRelations :: [Relation] -- ^ An array of relations
    , requestAlgorithm :: Algorithm -- ^ 
    , requestObjectives :: [Objective] -- ^ An array of objectives
    , requestCostMatrices :: [CostMatrix] -- ^ An array of cost matrices
    } deriving (Show, Eq, Generic)

instance FromJSON Request where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "request")
instance ToJSON Request where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "request")

-- | 
data Response = Response
    { responseCopyrights :: [Text] -- ^ 
    , responseJobId :: Text -- ^ unique identify of job - which you get when posting your request to the large problem solver
    , responseStatus :: Text -- ^ indicates the current status of the job
    , responseWaitingInQueue :: Integer -- ^ waiting time in ms
    , responseProcessingTime :: Integer -- ^ processing time in ms. if job is still waiting in queue, processing_time is 0
    , responseSolution :: Solution -- ^ the solution. only available if status field indicates finished
    } deriving (Show, Eq, Generic)

instance FromJSON Response where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "response")
instance ToJSON Response where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "response")

-- | 
data Route = Route
    { routeVehicleId :: Text -- ^ id of vehicle that operates route
    , routeDistance :: Integer -- ^ distance of route in meter
    , routeTransportTime :: Integer -- ^ transport time of route in ms
    , routeCompletionTime :: Integer -- ^ completion time of route in ms
    , routeWaitingTime :: Integer -- ^ waiting time of route in ms
    , routeActivities :: [Activity] -- ^ array of activities
    } deriving (Show, Eq, Generic)

instance FromJSON Route where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "route")
instance ToJSON Route where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "route")

-- | 
data Service = Service
    { serviceId :: Text -- ^ Unique identifier of service
    , serviceType_ :: Text -- ^ type of service
    , servicePriority :: Int -- ^ priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2.
    , serviceName :: Text -- ^ name of service
    , serviceAddress :: Address -- ^ 
    , serviceDuration :: Integer -- ^ duration of service, i.e. time in ms the corresponding activity takes
    , serviceTimeWindows :: [TimeWindow] -- ^ array of time windows. currently, only a single time window is allowed
    , serviceSize :: [Int] -- ^ array of capacity dimensions
    , serviceRequiredSkills :: [Text] -- ^ array of required skills
    , serviceAllowedVehicles :: [Text] -- ^ array of allowed vehicle ids
    } deriving (Show, Eq, Generic)

instance FromJSON Service where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "service")
instance ToJSON Service where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "service")

-- | 
data Shipment = Shipment
    { shipmentId :: Text -- ^ Unique identifier of service
    , shipmentName :: Text -- ^ name of shipment
    , shipmentPriority :: Int -- ^ priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2.
    , shipmentPickup :: Stop -- ^ 
    , shipmentDelivery :: Stop -- ^ 
    , shipmentSize :: [Int] -- ^ array of capacity dimensions
    , shipmentRequiredSkills :: [Text] -- ^ array of required skills
    , shipmentAllowedVehicles :: [Text] -- ^ array of allowed vehicle ids
    } deriving (Show, Eq, Generic)

instance FromJSON Shipment where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "shipment")
instance ToJSON Shipment where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "shipment")

-- | 
data Solution = Solution
    { solutionCosts :: Int -- ^ overall costs of solution
    , solutionDistance :: Int -- ^ overall travel distance in meters
    , solutionTime :: Integer -- ^ overall transport time in ms
    , solutionTransportTime :: Integer -- ^ overall transport time in ms
    , solutionMaxOperationTime :: Integer -- ^ operation time of the longest route in ms
    , solutionWaitingTime :: Integer -- ^ total waiting time in ms
    , solutionNoVehicles :: Int -- ^ number of employed vehicles
    , solutionNoUnassigned :: Int -- ^ number of jobs that could not be assigned to final solution
    , solutionRoutes :: [Route] -- ^ An array of routes
    , solutionUnassigned :: Solution_unassigned -- ^ 
    } deriving (Show, Eq, Generic)

instance FromJSON Solution where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "solution")
instance ToJSON Solution where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "solution")

-- | 
data Solution_unassigned = Solution_unassigned
    { solutionUnassignedServices :: [Text] -- ^ An array of ids of unassigned services
    , solutionUnassignedShipments :: [Text] -- ^ An array of ids of unassigned shipments
    } deriving (Show, Eq, Generic)

instance FromJSON Solution_unassigned where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "solutionUnassigned")
instance ToJSON Solution_unassigned where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "solutionUnassigned")

-- | 
data Stop = Stop
    { stopAddress :: Address -- ^ 
    , stopDuration :: Integer -- ^ duration of stop, i.e. time in ms the corresponding activity takes
    , stopTimeWindows :: [TimeWindow] -- ^ array of time windows. currently, only a single time window is allowed
    } deriving (Show, Eq, Generic)

instance FromJSON Stop where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "stop")
instance ToJSON Stop where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "stop")

-- | 
data TimeWindow = TimeWindow
    { timeWindowEarliest :: Integer -- ^ earliest start time of corresponding activity
    , timeWindowLatest :: Integer -- ^ latest start time of corresponding activity
    } deriving (Show, Eq, Generic)

instance FromJSON TimeWindow where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "timeWindow")
instance ToJSON TimeWindow where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "timeWindow")

-- | 
data Vehicle = Vehicle
    { vehicleVehicleId :: Text -- ^ Unique identifier of vehicle
    , vehicleTypeId :: Text -- ^ Unique identifier referring to the available vehicle types
    , vehicleStartAddress :: Address -- ^ 
    , vehicleEndAddress :: Address -- ^ 
    , vehicleBreak :: Break -- ^ 
    , vehicleReturnToDepot :: Bool -- ^ Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.
    , vehicleEarliestStart :: Integer -- ^ earliest start of vehicle at its start location
    , vehicleLatestEnd :: Integer -- ^ latest end of vehicle at its end location
    , vehicleSkills :: [Text] -- ^ array of skills
    } deriving (Show, Eq, Generic)

instance FromJSON Vehicle where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "vehicle")
instance ToJSON Vehicle where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "vehicle")

-- | 
data VehicleType = VehicleType
    { vehicleTypeTypeId :: Text -- ^ Unique identifier for the vehicle type
    , vehicleTypeProfile :: Text -- ^ Profile of vehicle type
    , vehicleTypeCapacity :: [Int] -- ^ array of capacity dimensions
    , vehicleTypeSpeedFactor :: Double -- ^ speed_factor of vehicle type
    , vehicleTypeServiceTimeFactor :: Double -- ^ service time factor of vehicle type
    } deriving (Show, Eq, Generic)

instance FromJSON VehicleType where
  parseJSON  = genericParseJSON  (removeFieldLabelPrefix True "vehicleType")
instance ToJSON VehicleType where
  toJSON     = genericToJSON     (removeFieldLabelPrefix False "vehicleType")

-- Remove a field label prefix during JSON parsing.
-- Also perform any replacements for special characters.
removeFieldLabelPrefix :: Bool -> String -> Options
removeFieldLabelPrefix forParsing prefix =
  defaultOptions
    { fieldLabelModifier = fromMaybe (error ("did not find prefix " ++ prefix)) . stripPrefix prefix . replaceSpecialChars
    }
  where
    replaceSpecialChars field = foldl (&) field (map mkCharReplacement specialChars)
    specialChars = [("#", "'Hash"), ("!", "'Exclamation"), ("&", "'Ampersand"), ("@", "'At"), ("$", "'Dollar"), ("%", "'Percent"), ("*", "'Star"), ("+", "'Plus"), (">=", "'Greater_Than_Or_Equal_To"), (".", "'Period"), ("-", "'Dash"), ("<=", "'Less_Than_Or_Equal_To"), ("!=", "'Not_Equal"), (":", "'Colon"), ("_", "'Underscore"), ("^", "'Caret"), ("|", "'Pipe"), (">", "'GreaterThan"), ("=", "'Equal"), ("<", "'LessThan")]
    mkCharReplacement (replaceStr, searchStr) = T.unpack . replacer (T.pack searchStr) (T.pack replaceStr) . T.pack
    replacer = if forParsing then flip T.replace else T.replace


