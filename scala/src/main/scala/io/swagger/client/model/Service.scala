package io.swagger.client.model




case class Service (
  /* Unique identifier of service */
  id: String,
  /* type of service */
  _type: String,
  /* name of service */
  name: String,
  address: Address,
  /* duration of service, i.e. time in ms the corresponding activity takes */
  duration: Long,
  /* array of time windows. currently, only a single time window is allowed */
  time_windows: List[TimeWindow],
  /* array of capacity dimensions */
  size: List[Integer],
  /* array of required skills */
  required_skills: List[String],
  /* array of allowed vehicle ids */
  allowed_vehicles: List[String])
  
