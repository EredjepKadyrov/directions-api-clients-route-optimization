part of api;


@Entity()
class Vehicle {
  /* Unique identifier of vehicle */
  String vehicleId = null;
  
  /* Unique identifier referring to the available vehicle types */
  String typeId = null;
  
  
  Address startAddress = null;
  
  
  Address endAddress = null;
  
  
  Break _break = null;
  
  /* Indicates whether vehicle should return to start address or not. If not, it can end at any service activity. */
  bool returnToDepot = null;
  
  /* earliest start of vehicle at its start location */
  int earliestStart = null;
  
  /* latest end of vehicle at its end location */
  int latestEnd = null;
  
  /* array of skills */
  List<String> skills = [];
  
  
  Vehicle();

  @override
  String toString()  {
    return 'Vehicle[vehicleId=$vehicleId, typeId=$typeId, startAddress=$startAddress, endAddress=$endAddress, _break=$_break, returnToDepot=$returnToDepot, earliestStart=$earliestStart, latestEnd=$latestEnd, skills=$skills, ]';
  }

}

