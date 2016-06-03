package io.swagger.client.model




case class VehicleType (
  /* Unique identifier for the vehicle type */
  type_id: String,
  /* Profile of vehicle type */
  profile: String,
  /* array of capacity dimensions */
  capacity: List[Integer],
  /* speed_factor of vehicle type */
  speed_factor: Double,
  /* service time factor of vehicle type */
  service_time_factor: Double)
  
