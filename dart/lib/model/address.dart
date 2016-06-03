part of api;


@Entity()
class Address {
  /* Unique identifier of location */
  String locationId = null;
  
  /* longitude */
  num lon = null;
  
  /* latitude */
  num lat = null;
  
  
  Address();

  @override
  String toString()  {
    return 'Address[locationId=$locationId, lon=$lon, lat=$lat, ]';
  }

}

