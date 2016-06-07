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
    public class TimeWindow :  IEquatable<TimeWindow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeWindow" /> class.
        /// </summary>
        public TimeWindow()
        {
            
        }

        
        /// <summary>
        /// earliest start time of corresponding activity
        /// </summary>
        /// <value>earliest start time of corresponding activity</value>
        [DataMember(Name="earliest", EmitDefaultValue=false)]
        public long? Earliest { get; set; }
  
        
        /// <summary>
        /// latest start time of corresponding activity
        /// </summary>
        /// <value>latest start time of corresponding activity</value>
        [DataMember(Name="latest", EmitDefaultValue=false)]
        public long? Latest { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeWindow {\n");
            sb.Append("  Earliest: ").Append(Earliest).Append("\n");
            sb.Append("  Latest: ").Append(Latest).Append("\n");
            
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
            return this.Equals(obj as TimeWindow);
        }

        /// <summary>
        /// Returns true if TimeWindow instances are equal
        /// </summary>
        /// <param name="obj">Instance of TimeWindow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeWindow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Earliest == other.Earliest ||
                    this.Earliest != null &&
                    this.Earliest.Equals(other.Earliest)
                ) && 
                (
                    this.Latest == other.Latest ||
                    this.Latest != null &&
                    this.Latest.Equals(other.Latest)
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
                
                if (this.Earliest != null)
                    hash = hash * 57 + this.Earliest.GetHashCode();
                
                if (this.Latest != null)
                    hash = hash * 57 + this.Latest.GetHashCode();
                
                return hash;
            }
        }

    }
}
