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
    public class Stop :  IEquatable<Stop>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Stop" /> class.
        /// </summary>
        public Stop()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
  
        
        /// <summary>
        /// duration of stop, i.e. time in ms the corresponding activity takes
        /// </summary>
        /// <value>duration of stop, i.e. time in ms the corresponding activity takes</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public long? Duration { get; set; }
  
        
        /// <summary>
        /// array of time windows. currently, only a single time window is allowed
        /// </summary>
        /// <value>array of time windows. currently, only a single time window is allowed</value>
        [DataMember(Name="time_windows", EmitDefaultValue=false)]
        public List<TimeWindow> TimeWindows { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Stop {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  TimeWindows: ").Append(TimeWindows).Append("\n");
            
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
            return this.Equals(obj as Stop);
        }

        /// <summary>
        /// Returns true if Stop instances are equal
        /// </summary>
        /// <param name="obj">Instance of Stop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Stop other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
                ) && 
                (
                    this.TimeWindows == other.TimeWindows ||
                    this.TimeWindows != null &&
                    this.TimeWindows.SequenceEqual(other.TimeWindows)
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
                
                if (this.Address != null)
                    hash = hash * 57 + this.Address.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.TimeWindows != null)
                    hash = hash * 57 + this.TimeWindows.GetHashCode();
                
                return hash;
            }
        }

    }
}
