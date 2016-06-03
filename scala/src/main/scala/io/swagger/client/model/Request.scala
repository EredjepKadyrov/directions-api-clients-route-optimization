package io.swagger.client.model




case class Request (
  /* An array of vehicles that can be employed */
  vehicles: List[Vehicle],
  /* An array of vehicle types */
  vehicle_types: List[VehicleType],
  /* An array of services */
  services: List[Service],
  /* An array of shipments */
  shipments: List[Shipment],
  /* An array of relations */
  relations: List[Relation],
  algorithm: Algorithm)
  
