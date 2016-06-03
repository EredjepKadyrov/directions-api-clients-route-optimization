'use strict';

var url = require('url');


var Vrp = require('./VrpService');


module.exports.postVrp = function postVrp (req, res, next) {
  var key = req.swagger.params['key'].value;
  var body = req.swagger.params['body'].value;
  

  var result = Vrp.postVrp(key, body);

  if(typeof result !== 'undefined') {
    res.setHeader('Content-Type', 'application/json');
    res.end(JSON.stringify(result || {}, null, 2));
  }
  else
    res.end();
};
