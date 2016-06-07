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
    public class SolutionUnassigned :  IEquatable<SolutionUnassigned>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionUnassigned" /> class.
        /// </summary>
        public SolutionUnassigned()
        {
            
        }

        
        /// <summary>
        /// An array of ids of unassigned services
        /// </summary>
        /// <value>An array of ids of unassigned services</value>
        [DataMember(Name="services", EmitDefaultValue=false)]
        public List<string> Services { get; set; }
  
        
        /// <summary>
        /// An array of ids of unassigned shipments
        /// </summary>
        /// <value>An array of ids of unassigned shipments</value>
        [DataMember(Name="shipments", EmitDefaultValue=false)]
        public List<string> Shipments { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SolutionUnassigned {\n");
            sb.Append("  Services: ").Append(Services).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            
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
            return this.Equals(obj as SolutionUnassigned);
        }

        /// <summary>
        /// Returns true if SolutionUnassigned instances are equal
        /// </summary>
        /// <param name="obj">Instance of SolutionUnassigned to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SolutionUnassigned other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Services == other.Services ||
                    this.Services != null &&
                    this.Services.SequenceEqual(other.Services)
                ) && 
                (
                    this.Shipments == other.Shipments ||
                    this.Shipments != null &&
                    this.Shipments.SequenceEqual(other.Shipments)
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
                
                if (this.Services != null)
                    hash = hash * 57 + this.Services.GetHashCode();
                
                if (this.Shipments != null)
                    hash = hash * 57 + this.Shipments.GetHashCode();
                
                return hash;
            }
        }

    }
}
