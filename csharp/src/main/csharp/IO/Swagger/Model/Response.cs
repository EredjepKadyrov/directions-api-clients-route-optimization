using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Response :  IEquatable<Response>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Response" /> class.
        /// </summary>
        public Response()
        {
            
        }

        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
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
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Response);
        }

        /// <summary>
        /// Returns true if Response instances are equal
        /// </summary>
        /// <param name="obj">Instance of Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Response other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.WaitingInQueue == other.WaitingInQueue ||
                    this.WaitingInQueue != null &&
                    this.WaitingInQueue.Equals(other.WaitingInQueue)
                ) && 
                (
                    this.ProcessingTime == other.ProcessingTime ||
                    this.ProcessingTime != null &&
                    this.ProcessingTime.Equals(other.ProcessingTime)
                ) && 
                (
                    this.Solution == other.Solution ||
                    this.Solution != null &&
                    this.Solution.Equals(other.Solution)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                
                if (this.JobId != null)
                    hash = hash * 57 + this.JobId.GetHashCode();
                
                if (this.Status != null)
                    hash = hash * 57 + this.Status.GetHashCode();
                
                if (this.WaitingInQueue != null)
                    hash = hash * 57 + this.WaitingInQueue.GetHashCode();
                
                if (this.ProcessingTime != null)
                    hash = hash * 57 + this.ProcessingTime.GetHashCode();
                
                if (this.Solution != null)
                    hash = hash * 57 + this.Solution.GetHashCode();
                
                return hash;
            }
        }

    }
}
