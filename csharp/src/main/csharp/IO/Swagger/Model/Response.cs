using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Response {
    
    /// <summary>
    /// unique identify of job - which you get when posting your request to the large problem solver
    /// </summary>
    /// <value>unique identify of job - which you get when posting your request to the large problem solver</value>
    [DataMember(Name="job_id", EmitDefaultValue=false)]
    public string JobId { get; set; }

    
    /// <summary>
    /// indicates the current status of the job
    /// </summary>
    /// <value>indicates the current status of the job</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    public string Status { get; set; }

    
    /// <summary>
    /// waiting time in ms
    /// </summary>
    /// <value>waiting time in ms</value>
    [DataMember(Name="waiting_in_queue", EmitDefaultValue=false)]
    public long? WaitingInQueue { get; set; }

    
    /// <summary>
    /// processing time in ms. if job is still waiting in queue, processing_time is 0
    /// </summary>
    /// <value>processing time in ms. if job is still waiting in queue, processing_time is 0</value>
    [DataMember(Name="processing_time", EmitDefaultValue=false)]
    public long? ProcessingTime { get; set; }

    
    /// <summary>
    /// the solution. only available if status field indicates finished
    /// </summary>
    /// <value>the solution. only available if status field indicates finished</value>
    [DataMember(Name="solution", EmitDefaultValue=false)]
    public Solution Solution { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Response {\n");
      
      sb.Append("  JobId: ").Append(JobId).Append("\n");
      
      sb.Append("  Status: ").Append(Status).Append("\n");
      
      sb.Append("  WaitingInQueue: ").Append(WaitingInQueue).Append("\n");
      
      sb.Append("  ProcessingTime: ").Append(ProcessingTime).Append("\n");
      
      sb.Append("  Solution: ").Append(Solution).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
