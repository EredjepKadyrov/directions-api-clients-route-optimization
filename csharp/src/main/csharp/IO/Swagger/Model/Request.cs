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
    public class Request :  IEquatable<Request>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        public Request()
        {
            
        }

        
        /// <summary>
        /// An array of vehicles that can be employed
        /// </summary>
        /// <value>An array of vehicles that can be employed</value>
        [DataMember(Name="vehicles", EmitDefaultValue=false)]
        public List<Vehicle> Vehicles { get; set; }
  
        
        /// <summary>
        /// An array of vehicle types
        /// </summary>
        /// <value>An array of vehicle types</value>
        [DataMember(Name="vehicle_types", EmitDefaultValue=false)]
        public List<VehicleType> VehicleTypes { get; set; }
  
        
        /// <summary>
        /// An array of services
        /// </summary>
        /// <value>An array of services</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<Service> Services { get; set; }
  
        
        /// <summary>
        /// An array of shipments
        /// </summary>
        /// <value>An array of shipments</value>
        [DataMember(Name="shipments", EmitDefaultValue=false)]
        public List<Shipment> Shipments { get; set; }
  
        
        /// <summary>
        /// An array of relations
        /// </summary>
        /// <value>An array of relations</value>
        [DataMember(Name="relations", EmitDefaultValue=false)]
        public List<Relation> Relations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Algorithm
        /// </summary>
        [DataMember(Name="algorithm", EmitDefaultValue=false)]
        public Algorithm Algorithm { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Request {\n");
            sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
            sb.Append("  VehicleTypes: ").Append(VehicleTypes).Append("\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Relations: ").Append(Relations).Append("\n");
            sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
            
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
            return this.Equals(obj as Request);
        }

        /// <summary>
        /// Returns true if Request instances are equal
        /// </summary>
        /// <param name="obj">Instance of Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Vehicles == other.Vehicles ||
                    this.Vehicles != null &&
                    this.Vehicles.SequenceEqual(other.Vehicles)
                ) && 
                (
                    this.VehicleTypes == other.VehicleTypes ||
                    this.VehicleTypes != null &&
                    this.VehicleTypes.SequenceEqual(other.VehicleTypes)
                ) && 
                (
                    this.Services == other.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(other.Services)
                ) && 
                (
                    this.Shipments == other.Shipments ||
                    this.Shipments != null &&
                    this.Shipments.SequenceEqual(other.Shipments)
                ) && 
                (
                    this.Relations == other.Relations ||
                    this.Relations != null &&
                    this.Relations.SequenceEqual(other.Relations)
                ) && 
                (
                    this.Algorithm == other.Algorithm ||
                    this.Algorithm != null &&
                    this.Algorithm.Equals(other.Algorithm)
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
                
                if (this.Vehicles != null)
                    hash = hash * 57 + this.Vehicles.GetHashCode();
                
                if (this.VehicleTypes != null)
                    hash = hash * 57 + this.VehicleTypes.GetHashCode();
                
                if (this.Services != null)
                    hash = hash * 57 + this.Services.GetHashCode();
                
                if (this.Shipments != null)
                    hash = hash * 57 + this.Shipments.GetHashCode();
                
                if (this.Relations != null)
                    hash = hash * 57 + this.Relations.GetHashCode();
                
                if (this.Algorithm != null)
                    hash = hash * 57 + this.Algorithm.GetHashCode();
                
                return hash;
            }
        }

    }
}
