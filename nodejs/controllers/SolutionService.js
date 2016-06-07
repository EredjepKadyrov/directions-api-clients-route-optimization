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
  "processing_time" : 123456789,
  "solution" : {
    "time" : 123456789,
    "distance" : 123,
    "unassigned" : {
      "services" : [ "aeiou" ],
      "shipments" : [ "aeiou" ]
    },
    "routes" : [ {
      "activities" : [ {
        "id" : "aeiou",
        "arr_time" : 123456789,
        "end_time" : 123456789,
        "type" : "aeiou",
        "location_id" : "aeiou"
      } ],
      "vehicle_id" : "aeiou"
    } ],
    "no_unassigned" : 123,
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
