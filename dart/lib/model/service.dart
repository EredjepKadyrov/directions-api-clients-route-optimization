part of api;


@Entity()
class Service {
  /* Unique identifier of service */
  String id = null;
  
  /* type of service */
  String type = null;
  //enum typeEnum {  service,  pickup,  delivery,  };
  /* priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2. */
  int priority = null;
  
  /* name of service */
  String name = null;
  
  
  Address address = null;
  
  /* duration of service, i.e. time in ms the corresponding activity takes */
  int duration = null;
  
  /* array of time windows. currently, only a single time window is allowed */
  List<TimeWindow> timeWindows = [];
  
  /* array of capacity dimensions */
  List<int> size = [];
  
  /* array of required skills */
  List<String> requiredSkills = [];
  
  /* array of allowed vehicle ids */
  List<String> allowedVehicles = [];
  
  
  Service();

  @override
  String toString()  {
    return 'Service[id=$id, type=$type, priority=$priority, name=$name, address=$address, duration=$duration, timeWindows=$timeWindows, size=$size, requiredSkills=$requiredSkills, allowedVehicles=$allowedVehicles, ]';
  }

}

