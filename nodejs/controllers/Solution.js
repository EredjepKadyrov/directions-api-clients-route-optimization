'use strict';

var url = require('url');


var Solution = require('./SolutionService');


module.exports.getSolution = function getSolution (req, res, next) {
  Solution.getSolution(req.swagger.params, res, next);
};
