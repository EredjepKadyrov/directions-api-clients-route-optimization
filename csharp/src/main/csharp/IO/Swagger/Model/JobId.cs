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
    public class JobId :  IEquatable<JobId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobId" /> class.
        /// </summary>
        public JobId()
        {
            
        }

        
        /// <summary>
        /// unique id for your job/request with which you can fetch your solution
        /// </summary>
        /// <value>unique id for your job/request with which you can fetch your solution</value>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public string _JobId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobId {\n");
            sb.Append("  _JobId: ").Append(_JobId).Append("\n");
            
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
            return this.Equals(obj as JobId);
        }

        /// <summary>
        /// Returns true if JobId instances are equal
        /// </summary>
        /// <param name="obj">Instance of JobId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobId other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this._JobId == other._JobId ||
                    this._JobId != null &&
                    this._JobId.Equals(other._JobId)
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
                
                if (this._JobId != null)
                    hash = hash * 57 + this._JobId.GetHashCode();
                
                return hash;
            }
        }

    }
}
