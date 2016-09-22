'use strict';

exports.getSolution = function(args, res, next) {
  /**
   * parameters expected in the args:
  * key (String)
  * jobId (String)
  **/
    var examples = {};
  examples['application/json'] = {
  "waiting_in_queue" : 123456789,
  "status" : "aeiou",
  "copyrights" : [ "aeiou" ],
  "processing_time" : 123456789,
  "solution" : {
    "time" : 123456789,
    "distance" : 123,
    "unassigned" : {
      "services" : [ "aeiou" ],
      "shipments" : [ "aeiou" ]
    },
    "max_operation_time" : 123456789,
    "routes" : [ {
      "distance" : 123456789,
      "transport_time" : 123456789,
      "completion_time" : 123456789,
      "activities" : [ {
        "load_after" : [ 123 ],
        "id" : "aeiou",
        "distance" : 123456789,
        "arr_time" : 123456789,
        "driving_time" : 123456789,
        "end_time" : 123456789,
        "load_before" : [ 123 ],
        "waiting_time" : 123456789,
        "type" : "aeiou",
        "location_id" : "aeiou"
      } ],
      "waiting_time" : 123456789,
      "vehicle_id" : "aeiou"
    } ],
    "no_unassigned" : 123,
    "transport_time" : 123456789,
    "no_vehicles" : 123,
    "waiting_time" : 123456789,
    "costs" : 123
  },
  "job_id" : "aeiou"
};
  if(Object.keys(examples).length > 0) {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(examples[Object.keys(examples)[0]] || {}, null, 2));
  }
  else {
    res.end();
  }
  
}

