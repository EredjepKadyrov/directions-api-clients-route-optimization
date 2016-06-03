part of api;


@Entity()
class Request {
  /* An array of vehicles that can be employed */
  List<Vehicle> vehicles = [];
  
  /* An array of vehicle types */
  List<VehicleType> vehicleTypes = [];
  
  /* An array of services */
  List<Service> services = [];
  
  /* An array of shipments */
  List<Shipment> shipments = [];
  
  /* An array of relations */
  List<Relation> relations = [];
  
  
  Algorithm algorithm = null;
  
  
  Request();

  @override
  String toString()  {
    return 'Request[vehicles=$vehicles, vehicleTypes=$vehicleTypes, services=$services, shipments=$shipments, relations=$relations, algorithm=$algorithm, ]';
  }

}

