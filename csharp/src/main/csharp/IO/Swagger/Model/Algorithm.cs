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
    public class Algorithm :  IEquatable<Algorithm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Algorithm" /> class.
        /// </summary>
        public Algorithm()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ProblemType
        /// </summary>
        [DataMember(Name="problem_type", EmitDefaultValue=false)]
        public string ProblemType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Objective
        /// </summary>
        [DataMember(Name="objective", EmitDefaultValue=false)]
        public string Objective { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Algorithm {\n");
            sb.Append("  ProblemType: ").Append(ProblemType).Append("\n");
            sb.Append("  Objective: ").Append(Objective).Append("\n");
            
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
            return this.Equals(obj as Algorithm);
        }

        /// <summary>
        /// Returns true if Algorithm instances are equal
        /// </summary>
        /// <param name="obj">Instance of Algorithm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Algorithm other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProblemType == other.ProblemType ||
                    this.ProblemType != null &&
                    this.ProblemType.Equals(other.ProblemType)
                ) && 
                (
                    this.Objective == other.Objective ||
                    this.Objective != null &&
                    this.Objective.Equals(other.Objective)
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
                
                if (this.ProblemType != null)
                    hash = hash * 57 + this.ProblemType.GetHashCode();
                
                if (this.Objective != null)
                    hash = hash * 57 + this.Objective.GetHashCode();
                
                return hash;
            }
        }

    }
}
