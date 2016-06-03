part of api;


@Entity()
class VehicleType {
  /* Unique identifier for the vehicle type */
  String typeId = null;
  
  /* Profile of vehicle type */
  String profile = null;
  //enum profileEnum {  car,  bike,  foot,  mtb,  motorcycle,  racingbike,  truck,  small_truck,  bus,  };
  /* array of capacity dimensions */
  List<int> capacity = [];
  
  /* speed_factor of vehicle type */
  num speedFactor = null;
  
  /* service time factor of vehicle type */
  num serviceTimeFactor = null;
  
  
  VehicleType();

  @override
  String toString()  {
    return 'VehicleType[typeId=$typeId, profile=$profile, capacity=$capacity, speedFactor=$speedFactor, serviceTimeFactor=$serviceTimeFactor, ]';
  }

}

