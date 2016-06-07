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
    public class Relation :  IEquatable<Relation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Relation" /> class.
        /// </summary>
        public Relation()
        {
            
        }

        
        /// <summary>
        /// identifier of relation
        /// </summary>
        /// <value>identifier of relation</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// An array of ids that should be related
        /// </summary>
        /// <value>An array of ids that should be related</value>
        [DataMember(Name="ids", EmitDefaultValue=false)]
        public List<string> Ids { get; set; }
  
        
        /// <summary>
        /// vehicle id
        /// </summary>
        /// <value>vehicle id</value>
        [DataMember(Name="vehicle_id", EmitDefaultValue=false)]
        public string VehicleId { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Relation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
            
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
            return this.Equals(obj as Relation);
        }

        /// <summary>
        /// Returns true if Relation instances are equal
        /// </summary>
        /// <param name="obj">Instance of Relation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Relation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Ids == other.Ids ||
                    this.Ids != null &&
                    this.Ids.SequenceEqual(other.Ids)
                ) && 
                (
                    this.VehicleId == other.VehicleId ||
                    this.VehicleId != null &&
                    this.VehicleId.Equals(other.VehicleId)
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
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Ids != null)
                    hash = hash * 57 + this.Ids.GetHashCode();
                
                if (this.VehicleId != null)
                    hash = hash * 57 + this.VehicleId.GetHashCode();
                
                return hash;
            }
        }

    }
}
