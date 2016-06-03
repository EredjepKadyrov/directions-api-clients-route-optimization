part of api;


@Entity()
class Activity {
  /* type of activity */
  String type = null;
  //enum typeEnum {  start,  end,  service,  pickupShipment,  deliverShipment,  };
  /* id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to */
  String id = null;
  
  /* id that refers to address */
  String locationId = null;
  
  /* arrival time at this activity in ms */
  int arrTime = null;
  
  /* end time of and thus departure time at this activity */
  int endTime = null;
  
  
  Activity();

  @override
  String toString()  {
    return 'Activity[type=$type, id=$id, locationId=$locationId, arrTime=$arrTime, endTime=$endTime, ]';
  }

}

