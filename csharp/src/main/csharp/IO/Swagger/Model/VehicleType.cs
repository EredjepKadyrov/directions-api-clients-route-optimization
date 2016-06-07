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
    public class VehicleType :  IEquatable<VehicleType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleType" /> class.
        /// </summary>
        public VehicleType()
        {
            
        }

        
        /// <summary>
        /// Unique identifier for the vehicle type
        /// </summary>
        /// <value>Unique identifier for the vehicle type</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public string TypeId { get; set; }
  
        
        /// <summary>
        /// Profile of vehicle type
        /// </summary>
        /// <value>Profile of vehicle type</value>
        [DataMember(Name="profile", EmitDefaultValue=false)]
        public string Profile { get; set; }
  
        
        /// <summary>
        /// array of capacity dimensions
        /// </summary>
        /// <value>array of capacity dimensions</value>
        [DataMember(Name="capacity", EmitDefaultValue=false)]
        public List<int?> Capacity { get; set; }
  
        
        /// <summary>
        /// speed_factor of vehicle type
        /// </summary>
        /// <value>speed_factor of vehicle type</value>
        [DataMember(Name="speed_factor", EmitDefaultValue=false)]
        public double? SpeedFactor { get; set; }
  
        
        /// <summary>
        /// service time factor of vehicle type
        /// </summary>
        /// <value>service time factor of vehicle type</value>
        [DataMember(Name="service_time_factor", EmitDefaultValue=false)]
        public double? ServiceTimeFactor { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VehicleType {\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Capacity: ").Append(Capacity).Append("\n");
            sb.Append("  SpeedFactor: ").Append(SpeedFactor).Append("\n");
            sb.Append("  ServiceTimeFactor: ").Append(ServiceTimeFactor).Append("\n");
            
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
            return this.Equals(obj as VehicleType);
        }

        /// <summary>
        /// Returns true if VehicleType instances are equal
        /// </summary>
        /// <param name="obj">Instance of VehicleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VehicleType other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) && 
                (
                    this.Profile == other.Profile ||
                    this.Profile != null &&
                    this.Profile.Equals(other.Profile)
                ) && 
                (
                    this.Capacity == other.Capacity ||
                    this.Capacity != null &&
                    this.Capacity.SequenceEqual(other.Capacity)
                ) && 
                (
                    this.SpeedFactor == other.SpeedFactor ||
                    this.SpeedFactor != null &&
                    this.SpeedFactor.Equals(other.SpeedFactor)
                ) && 
                (
                    this.ServiceTimeFactor == other.ServiceTimeFactor ||
                    this.ServiceTimeFactor != null &&
                    this.ServiceTimeFactor.Equals(other.ServiceTimeFactor)
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
                
                if (this.TypeId != null)
                    hash = hash * 57 + this.TypeId.GetHashCode();
                
                if (this.Profile != null)
                    hash = hash * 57 + this.Profile.GetHashCode();
                
                if (this.Capacity != null)
                    hash = hash * 57 + this.Capacity.GetHashCode();
                
                if (this.SpeedFactor != null)
                    hash = hash * 57 + this.SpeedFactor.GetHashCode();
                
                if (this.ServiceTimeFactor != null)
                    hash = hash * 57 + this.ServiceTimeFactor.GetHashCode();
                
                return hash;
            }
        }

    }
}
