part of swagger.api;


@Entity()
class Address {
  /* Unique identifier of location */
  @Property(name: 'location_id')
  String locationId = null;
  
/* longitude */
  @Property(name: 'lon')
  double lon = null;
  
/* latitude */
  @Property(name: 'lat')
  double lat = null;
  
  Address();

  @override
  String toString()  {
    return 'Address[locationId=$locationId, lon=$lon, lat=$lat, ]';
  }

}

