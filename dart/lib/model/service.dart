part of api;


@Entity()
class Service {
  /* Unique identifier of service */
  String id = null;
  
  /* type of service */
  String type = null;
  //enum typeEnum {  service,  pickup,  delivery,  };
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
    return 'Service[id=$id, type=$type, name=$name, address=$address, duration=$duration, timeWindows=$timeWindows, size=$size, requiredSkills=$requiredSkills, allowedVehicles=$allowedVehicles, ]';
  }

}

