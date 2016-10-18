part of swagger.api;


@Entity()
class Service {
  /* Unique identifier of service */
  @Property(name: 'id')
  String id = null;
  
/* type of service */
  @Property(name: 'type')
  String type = null;
  //enum typeEnum {  service,  pickup,  delivery,  };
/* priority of service, i.e. 1 = high, 2 = normal, 3 = low. default is 2. */
  @Property(name: 'priority')
  int priority = null;
  
/* name of service */
  @Property(name: 'name')
  String name = null;
  

  @Property(name: 'address')
  Address address = null;
  
/* duration of service, i.e. time in ms the corresponding activity takes */
  @Property(name: 'duration')
  int duration = null;
  
/* array of time windows. currently, only a single time window is allowed */
  @Property(name: 'time_windows')
  List<TimeWindow> timeWindows = [];
  
/* array of capacity dimensions */
  @Property(name: 'size')
  List<int> size = [];
  
/* array of required skills */
  @Property(name: 'required_skills')
  List<String> requiredSkills = [];
  
/* array of allowed vehicle ids */
  @Property(name: 'allowed_vehicles')
  List<String> allowedVehicles = [];
  
  Service();

  @override
  String toString()  {
    return 'Service[id=$id, type=$type, priority=$priority, name=$name, address=$address, duration=$duration, timeWindows=$timeWindows, size=$size, requiredSkills=$requiredSkills, allowedVehicles=$allowedVehicles, ]';
  }

}

