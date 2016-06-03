'use strict';

exports.postVrp = function(key, body) {

  var examples = {};
  
  examples['application/json'] = {
  "job_id" : "aeiou"
};
  

  
  if(Object.keys(examples).length > 0)
    return examples[Object.keys(examples)[0]];
  
}
