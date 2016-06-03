package io.swagger.client.model




case class Shipment (
  /* Unique identifier of service */
  id: String,
  /* name of shipment */
  name: String,
  pickup: Stop,
  delivery: Stop,
  /* array of capacity dimensions */
  size: List[Integer],
  /* array of required skills */
  required_skills: List[String],
  /* array of allowed vehicle ids */
  allowed_vehicles: List[String])
  
