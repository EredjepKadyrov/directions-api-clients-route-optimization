part of api;


@Entity()
class Relation {
  /* identifier of relation */
  String type = null;
  
  /* An array of ids that should be related */
  List<String> ids = [];
  
  /* vehicle id */
  String vehicleId = null;
  
  
  Relation();

  @override
  String toString()  {
    return 'Relation[type=$type, ids=$ids, vehicleId=$vehicleId, ]';
  }

}

