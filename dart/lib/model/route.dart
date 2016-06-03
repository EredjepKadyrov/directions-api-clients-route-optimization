part of api;


@Entity()
class Route {
  /* id of vehicle that operates route */
  String vehicleId = null;
  
  /* array of activities */
  List<Activity> activities = [];
  
  
  Route();

  @override
  String toString()  {
    return 'Route[vehicleId=$vehicleId, activities=$activities, ]';
  }

}

