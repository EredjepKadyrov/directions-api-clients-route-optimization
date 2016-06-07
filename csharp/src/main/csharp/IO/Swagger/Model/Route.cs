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
    public class Route :  IEquatable<Route>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route" /> class.
        /// </summary>
        public Route()
        {
            
        }

        
        /// <summary>
        /// id of vehicle that operates route
        /// </summary>
        /// <value>id of vehicle that operates route</value>
        [DataMember(Name="vehicle_id", EmitDefaultValue=false)]
        public string VehicleId { get; set; }
  
        
        /// <summary>
        /// array of activities
        /// </summary>
        /// <value>array of activities</value>
        [DataMember(Name="activities", EmitDefaultValue=false)]
        public List<Activity> Activities { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Route {\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  Activities: ").Append(Activities).Append("\n");
            
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
            return this.Equals(obj as Route);
        }

        /// <summary>
        /// Returns true if Route instances are equal
        /// </summary>
        /// <param name="obj">Instance of Route to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Route other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.VehicleId == other.VehicleId ||
                    this.VehicleId != null &&
                    this.VehicleId.Equals(other.VehicleId)
                ) && 
                (
                    this.Activities == other.Activities ||
                    this.Activities != null &&
                    this.Activities.SequenceEqual(other.Activities)
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
                
                if (this.VehicleId != null)
                    hash = hash * 57 + this.VehicleId.GetHashCode();
                
                if (this.Activities != null)
                    hash = hash * 57 + this.Activities.GetHashCode();
                
                return hash;
            }
        }

    }
}
