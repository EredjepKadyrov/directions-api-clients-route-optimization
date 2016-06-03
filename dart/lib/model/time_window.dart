part of api;


@Entity()
class TimeWindow {
  /* earliest start time of corresponding activity */
  int earliest = null;
  
  /* latest start time of corresponding activity */
  int latest = null;
  
  
  TimeWindow();

  @override
  String toString()  {
    return 'TimeWindow[earliest=$earliest, latest=$latest, ]';
  }

}

