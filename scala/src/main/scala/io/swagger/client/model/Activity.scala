package io.swagger.client.model




case class Activity (
  /* type of activity */
  _type: String,
  /* id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to */
  id: String,
  /* id that refers to address */
  location_id: String,
  /* arrival time at this activity in ms */
  arr_time: Long,
  /* end time of and thus departure time at this activity */
  end_time: Long)
  
