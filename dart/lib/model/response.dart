part of api;


@Entity()
class Response {
  /* unique identify of job - which you get when posting your request to the large problem solver */
  String jobId = null;
  
  /* indicates the current status of the job */
  String status = null;
  //enum statusEnum {  waiting_in_queue,  processing,  finished,  };
  /* waiting time in ms */
  int waitingInQueue = null;
  
  /* processing time in ms. if job is still waiting in queue, processing_time is 0 */
  int processingTime = null;
  
  /* the solution. only available if status field indicates finished */
  Solution solution = null;
  
  
  Response();

  @override
  String toString()  {
    return 'Response[jobId=$jobId, status=$status, waitingInQueue=$waitingInQueue, processingTime=$processingTime, solution=$solution, ]';
  }

}

