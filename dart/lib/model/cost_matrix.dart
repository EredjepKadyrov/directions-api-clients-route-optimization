part of swagger.api;


@Entity()
class CostMatrix {
  /* type of cost matrix, currently default or google are supported */
  @Property(name: 'type')
  String type = null;
  //enum typeEnum {  default,  google,  };
/* URL of matrix service */
  @Property(name: 'url')
  String url = null;
  
/* vehicle profile or empty if catch all fallback */
  @Property(name: 'profile')
  String profile = null;
  
  CostMatrix();

  @override
  String toString()  {
    return 'CostMatrix[type=$type, url=$url, profile=$profile, ]';
  }

}

