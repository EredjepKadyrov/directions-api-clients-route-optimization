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
    public class Vehicle :  IEquatable<Vehicle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vehicle" /> class.
        /// </summary>
        public Vehicle()
        {
            
        }

        
        /// <summary>
        /// Unique identifier of vehicle
        /// </summary>
        /// <value>Unique identifier of vehicle</value>
        [DataMember(Name="vehicle_id", EmitDefaultValue=false)]
        public string VehicleId { get; set; }
  
        
        /// <summary>
        /// Unique identifier referring to the available vehicle types
        /// </summary>
        /// <value>Unique identifier referring to the available vehicle types</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public string TypeId { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartAddress
        /// </summary>
        [DataMember(Name="start_address", EmitDefaultValue=false)]
        public Address StartAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EndAddress
        /// </summary>
        [DataMember(Name="end_address", EmitDefaultValue=false)]
        public Address EndAddress { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Break
        /// </summary>
        [DataMember(Name="break", EmitDefaultValue=false)]
        public Break Break { get; set; }
  
        
        /// <summary>
        /// Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.
        /// </summary>
        /// <value>Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.</value>
        [DataMember(Name="return_to_depot", EmitDefaultValue=false)]
        public bool? ReturnToDepot { get; set; }
  
        
        /// <summary>
        /// earliest start of vehicle at its start location
        /// </summary>
        /// <value>earliest start of vehicle at its start location</value>
        [DataMember(Name="earliest_start", EmitDefaultValue=false)]
        public long? EarliestStart { get; set; }
  
        
        /// <summary>
        /// latest end of vehicle at its end location
        /// </summary>
        /// <value>latest end of vehicle at its end location</value>
        [DataMember(Name="latest_end", EmitDefaultValue=false)]
        public long? LatestEnd { get; set; }
  
        
        /// <summary>
        /// array of skills
        /// </summary>
        /// <value>array of skills</value>
        [DataMember(Name="skills", EmitDefaultValue=false)]
        public List<string> Skills { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vehicle {\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
            sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
            sb.Append("  Break: ").Append(Break).Append("\n");
            sb.Append("  ReturnToDepot: ").Append(ReturnToDepot).Append("\n");
            sb.Append("  EarliestStart: ").Append(EarliestStart).Append("\n");
            sb.Append("  LatestEnd: ").Append(LatestEnd).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
            
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
            return this.Equals(obj as Vehicle);
        }

        /// <summary>
        /// Returns true if Vehicle instances are equal
        /// </summary>
        /// <param name="obj">Instance of Vehicle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vehicle other)
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
                    this.TypeId == other.TypeId ||
                    this.TypeId != null &&
                    this.TypeId.Equals(other.TypeId)
                ) && 
                (
                    this.StartAddress == other.StartAddress ||
                    this.StartAddress != null &&
                    this.StartAddress.Equals(other.StartAddress)
                ) && 
                (
                    this.EndAddress == other.EndAddress ||
                    this.EndAddress != null &&
                    this.EndAddress.Equals(other.EndAddress)
                ) && 
                (
                    this.Break == other.Break ||
                    this.Break != null &&
                    this.Break.Equals(other.Break)
                ) && 
                (
                    this.ReturnToDepot == other.ReturnToDepot ||
                    this.ReturnToDepot != null &&
                    this.ReturnToDepot.Equals(other.ReturnToDepot)
                ) && 
                (
                    this.EarliestStart == other.EarliestStart ||
                    this.EarliestStart != null &&
                    this.EarliestStart.Equals(other.EarliestStart)
                ) && 
                (
                    this.LatestEnd == other.LatestEnd ||
                    this.LatestEnd != null &&
                    this.LatestEnd.Equals(other.LatestEnd)
                ) && 
                (
                    this.Skills == other.Skills ||
                    this.Skills != null &&
                    this.Skills.SequenceEqual(other.Skills)
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
                
                if (this.TypeId != null)
                    hash = hash * 57 + this.TypeId.GetHashCode();
                
                if (this.StartAddress != null)
                    hash = hash * 57 + this.StartAddress.GetHashCode();
                
                if (this.EndAddress != null)
                    hash = hash * 57 + this.EndAddress.GetHashCode();
                
                if (this.Break != null)
                    hash = hash * 57 + this.Break.GetHashCode();
                
                if (this.ReturnToDepot != null)
                    hash = hash * 57 + this.ReturnToDepot.GetHashCode();
                
                if (this.EarliestStart != null)
                    hash = hash * 57 + this.EarliestStart.GetHashCode();
                
                if (this.LatestEnd != null)
                    hash = hash * 57 + this.LatestEnd.GetHashCode();
                
                if (this.Skills != null)
                    hash = hash * 57 + this.Skills.GetHashCode();
                
                return hash;
            }
        }

    }
}
