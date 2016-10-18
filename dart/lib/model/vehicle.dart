part of swagger.api;


@Entity()
class Vehicle {
  /* Unique identifier of vehicle */
  @Property(name: 'vehicle_id')
  String vehicleId = null;
  
/* Unique identifier referring to the available vehicle types */
  @Property(name: 'type_id')
  String typeId = null;
  

  @Property(name: 'start_address')
  Address startAddress = null;
  

  @Property(name: 'end_address')
  Address endAddress = null;
  

  @Property(name: 'break')
  ModelBreak _break = null;
  
/* Indicates whether vehicle should return to start address or not. If not, it can end at any service activity. */
  @Property(name: 'return_to_depot')
  bool returnToDepot = null;
  
/* earliest start of vehicle at its start location */
  @Property(name: 'earliest_start')
  int earliestStart = null;
  
/* latest end of vehicle at its end location */
  @Property(name: 'latest_end')
  int latestEnd = null;
  
/* array of skills */
  @Property(name: 'skills')
  List<String> skills = [];
  
  Vehicle();

  @override
  String toString()  {
    return 'Vehicle[vehicleId=$vehicleId, typeId=$typeId, startAddress=$startAddress, endAddress=$endAddress, _break=$_break, returnToDepot=$returnToDepot, earliestStart=$earliestStart, latestEnd=$latestEnd, skills=$skills, ]';
  }

}

