part of api;


@Entity()
class JobId {
  /* unique id for your job/request with which you can fetch your solution */
  String jobId = null;
  
  
  JobId();

  @override
  String toString()  {
    return 'JobId[jobId=$jobId, ]';
  }

}

