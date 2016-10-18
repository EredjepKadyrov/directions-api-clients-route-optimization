part of swagger.api;


@Entity()
class VehicleType {
  /* Unique identifier for the vehicle type */
  @Property(name: 'type_id')
  String typeId = null;
  
/* Profile of vehicle type */
  @Property(name: 'profile')
  String profile = null;
  //enum profileEnum {  car,  bike,  foot,  mtb,  motorcycle,  racingbike,  truck,  small_truck,  bus,  };
/* array of capacity dimensions */
  @Property(name: 'capacity')
  List<int> capacity = [];
  
/* speed_factor of vehicle type */
  @Property(name: 'speed_factor')
  double speedFactor = null;
  
/* service time factor of vehicle type */
  @Property(name: 'service_time_factor')
  double serviceTimeFactor = null;
  
  VehicleType();

  @override
  String toString()  {
    return 'VehicleType[typeId=$typeId, profile=$profile, capacity=$capacity, speedFactor=$speedFactor, serviceTimeFactor=$serviceTimeFactor, ]';
  }

}

