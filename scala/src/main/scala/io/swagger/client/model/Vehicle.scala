package io.swagger.client.model




case class Vehicle (
  /* Unique identifier of vehicle */
  vehicle_id: String,
  /* Unique identifier referring to the available vehicle types */
  type_id: String,
  start_address: Address,
  end_address: Address,
  break: Break,
  /* Indicates whether vehicle should return to start address or not. If not, it can end at any service activity. */
  return_to_depot: Boolean,
  /* earliest start of vehicle at its start location */
  earliest_start: Long,
  /* latest end of vehicle at its end location */
  latest_end: Long,
  /* array of skills */
  skills: List[String])
  
