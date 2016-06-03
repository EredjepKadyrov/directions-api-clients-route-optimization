part of api;


@Entity()
class Shipment {
  /* Unique identifier of service */
  String id = null;
  
  /* name of shipment */
  String name = null;
  
  
  Stop pickup = null;
  
  
  Stop delivery = null;
  
  /* array of capacity dimensions */
  List<int> size = [];
  
  /* array of required skills */
  List<String> requiredSkills = [];
  
  /* array of allowed vehicle ids */
  List<String> allowedVehicles = [];
  
  
  Shipment();

  @override
  String toString()  {
    return 'Shipment[id=$id, name=$name, pickup=$pickup, delivery=$delivery, size=$size, requiredSkills=$requiredSkills, allowedVehicles=$allowedVehicles, ]';
  }

}

