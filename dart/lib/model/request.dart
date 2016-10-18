part of swagger.api;


@Entity()
class Request {
  /* An array of vehicles that can be employed */
  @Property(name: 'vehicles')
  List<Vehicle> vehicles = [];
  
/* An array of vehicle types */
  @Property(name: 'vehicle_types')
  List<VehicleType> vehicleTypes = [];
  
/* An array of services */
  @Property(name: 'services')
  List<Service> services = [];
  
/* An array of shipments */
  @Property(name: 'shipments')
  List<Shipment> shipments = [];
  
/* An array of relations */
  @Property(name: 'relations')
  List<Relation> relations = [];
  

  @Property(name: 'algorithm')
  Algorithm algorithm = null;
  
/* An array of objectives */
  @Property(name: 'objectives')
  List<Objective> objectives = [];
  
/* An array of cost matrices */
  @Property(name: 'cost_matrices')
  List<CostMatrix> costMatrices = [];
  
  Request();

  @override
  String toString()  {
    return 'Request[vehicles=$vehicles, vehicleTypes=$vehicleTypes, services=$services, shipments=$shipments, relations=$relations, algorithm=$algorithm, objectives=$objectives, costMatrices=$costMatrices, ]';
  }

}

