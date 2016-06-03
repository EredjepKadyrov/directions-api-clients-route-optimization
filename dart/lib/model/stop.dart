part of api;


@Entity()
class Stop {
  
  Address address = null;
  
  /* duration of stop, i.e. time in ms the corresponding activity takes */
  int duration = null;
  
  /* array of time windows. currently, only a single time window is allowed */
  List<TimeWindow> timeWindows = [];
  
  
  Stop();

  @override
  String toString()  {
    return 'Stop[address=$address, duration=$duration, timeWindows=$timeWindows, ]';
  }

}

