package io.swagger.client.model




case class Response (
  /* unique identify of job - which you get when posting your request to the large problem solver */
  job_id: String,
  /* indicates the current status of the job */
  status: String,
  /* waiting time in ms */
  waiting_in_queue: Long,
  /* processing time in ms. if job is still waiting in queue, processing_time is 0 */
  processing_time: Long,
  /* the solution. only available if status field indicates finished */
  solution: Solution)
  
