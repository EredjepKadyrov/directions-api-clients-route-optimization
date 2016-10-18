library swagger.api;

import 'dart:async';
import 'dart:convert';
import 'package:http/browser_client.dart';
import 'package:http/http.dart';
import 'package:dartson/dartson.dart';
import 'package:dartson/transformers/date_time.dart';
import 'package:intl/intl.dart';

part 'api_client.dart';
part 'api_helper.dart';
part 'api_exception.dart';
part 'auth/authentication.dart';
part 'auth/api_key_auth.dart';
part 'auth/oauth.dart';
part 'auth/http_basic_auth.dart';

part 'api/solution_api.dart';
part 'api/vrp_api.dart';

part 'model/activity.dart';
part 'model/address.dart';
part 'model/algorithm.dart';
part 'model/cost_matrix.dart';
part 'model/job_id.dart';
part 'model/model_break.dart';
part 'model/objective.dart';
part 'model/relation.dart';
part 'model/request.dart';
part 'model/response.dart';
part 'model/route.dart';
part 'model/service.dart';
part 'model/shipment.dart';
part 'model/solution.dart';
part 'model/solution_unassigned.dart';
part 'model/stop.dart';
part 'model/time_window.dart';
part 'model/vehicle.dart';
part 'model/vehicle_type.dart';


ApiClient defaultApiClient = new ApiClient();

