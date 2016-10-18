part of swagger.api;


@Entity()
class Stop {
  
  @Property(name: 'address')
  Address address = null;
  
/* duration of stop, i.e. time in ms the corresponding activity takes */
  @Property(name: 'duration')
  int duration = null;
  
/* array of time windows. currently, only a single time window is allowed */
  @Property(name: 'time_windows')
  List<TimeWindow> timeWindows = [];
  
  Stop();

  @override
  String toString()  {
    return 'Stop[address=$address, duration=$duration, timeWindows=$timeWindows, ]';
  }

}

