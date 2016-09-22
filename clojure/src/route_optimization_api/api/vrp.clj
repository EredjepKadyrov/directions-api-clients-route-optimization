(ns route-optimization-api.api.vrp
  (:require [route-optimization-api.core :refer [call-api check-required-params with-collection-format]])
  (:import (java.io File)))

(defn post-vrp-with-http-info
  "Solves vehicle routing problems
  This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution."
  [key body ]
  (call-api "/optimize" :post
            {:path-params   {}
             :header-params {}
             :query-params  {"key" key }
             :form-params   {}
             :body-param    body
             :content-types ["application/json"]
             :accepts       ["application/json"]
             :auth-names    ["api_key"]}))

(defn post-vrp
  "Solves vehicle routing problems
  This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution."
  [key body ]
  (:data (post-vrp-with-http-info key body)))

