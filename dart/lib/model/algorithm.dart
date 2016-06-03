part of api;


@Entity()
class Algorithm {
  
  String problemType = null;
  //enum problemTypeEnum {  min,  min-max,  };
  
  String objective = null;
  //enum objectiveEnum {  transport_time,  completion_time,  };
  
  Algorithm();

  @override
  String toString()  {
    return 'Algorithm[problemType=$problemType, objective=$objective, ]';
  }

}

