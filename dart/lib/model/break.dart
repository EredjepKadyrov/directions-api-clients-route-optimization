part of api;


@Entity()
class Break {
  /* earliest start of break */
  int earliest = null;
  
  /* latest start of break */
  int latest = null;
  
  /* duration of break */
  int duration = null;
  
  
  Break();

  @override
  String toString()  {
    return 'Break[earliest=$earliest, latest=$latest, duration=$duration, ]';
  }

}

