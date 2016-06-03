'use strict';

var url = require('url');


var Solution = require('./SolutionService');


module.exports.getSolution = function getSolution (req, res, next) {
  var key = req.swagger.params['key'].value;
  var jobId = req.swagger.params['jobId'].value;
  

  var result = Solution.getSolution(key, jobId);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
