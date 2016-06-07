library api;

import 'dart:async';
import 'dart:convert';
import 'dart:html';
import 'package:http/browser_client.dart';
import 'package:http/http.dart';
import 'package:dartson/dartson.dart';
import 'package:crypto/crypto.dart';
import 'package:intl/intl.dart';

part 'api_client.dart';
part 'api_exception.dart';
part 'auth/authentication.dart';
part 'auth/api_key_auth.dart';
part 'auth/oauth.dart';
part 'auth/http_basic_auth.dart';

part 'api/vrp_api.dart';
part 'api/solution_api.dart';

part 'model/jobId.dart';
part 'model/request.dart';
part 'model/vehicle.dart';
part 'model/algorithm.dart';
part 'model/address.dart';
part 'model/_break.dart';
part 'model/vehicleType.dart';
part 'model/service.dart';
part 'model/shipment.dart';
part 'model/stop.dart';
part 'model/timeWindow.dart';
part 'model/relation.dart';
part 'model/response.dart';
part 'model/solution.dart';
part 'model/route.dart';
part 'model/activity.dart';
part 'model/solutionUnassigned.dart';
