'use strict';

var url = require('url');


var Vrp = require('./VrpService');


module.exports.postVrp = function postVrp (req, res, next) {
  Vrp.postVrp(req.swagger.params, res, next);
};
