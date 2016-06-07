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
    public class Solution :  IEquatable<Solution>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Solution" /> class.
        /// </summary>
        public Solution()
        {
            
        }

        
        /// <summary>
        /// overall costs of solution
        /// </summary>
        /// <value>overall costs of solution</value>
        [DataMember(Name="costs", EmitDefaultValue=false)]
        public int? Costs { get; set; }
  
        
        /// <summary>
        /// overall travel distance in meters
        /// </summary>
        /// <value>overall travel distance in meters</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public int? Distance { get; set; }
  
        
        /// <summary>
        /// overall travel time in ms
        /// </summary>
        /// <value>overall travel time in ms</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }
  
        
        /// <summary>
        /// number of jobs that could not be assigned to final solution
        /// </summary>
        /// <value>number of jobs that could not be assigned to final solution</value>
        [DataMember(Name="no_unassigned", EmitDefaultValue=false)]
        public int? NoUnassigned { get; set; }
  
        
        /// <summary>
        /// An array of routes
        /// </summary>
        /// <value>An array of routes</value>
        [DataMember(Name="routes", EmitDefaultValue=false)]
        public List<Route> Routes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Unassigned
        /// </summary>
        [DataMember(Name="unassigned", EmitDefaultValue=false)]
        public SolutionUnassigned Unassigned { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Solution {\n");
            sb.Append("  Costs: ").Append(Costs).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  NoUnassigned: ").Append(NoUnassigned).Append("\n");
            sb.Append("  Routes: ").Append(Routes).Append("\n");
            sb.Append("  Unassigned: ").Append(Unassigned).Append("\n");
            
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
            return this.Equals(obj as Solution);
        }

        /// <summary>
        /// Returns true if Solution instances are equal
        /// </summary>
        /// <param name="obj">Instance of Solution to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Solution other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Costs == other.Costs ||
                    this.Costs != null &&
                    this.Costs.Equals(other.Costs)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Time == other.Time ||
                    this.Time != null &&
                    this.Time.Equals(other.Time)
                ) && 
                (
                    this.NoUnassigned == other.NoUnassigned ||
                    this.NoUnassigned != null &&
                    this.NoUnassigned.Equals(other.NoUnassigned)
                ) && 
                (
                    this.Routes == other.Routes ||
                    this.Routes != null &&
                    this.Routes.SequenceEqual(other.Routes)
                ) && 
                (
                    this.Unassigned == other.Unassigned ||
                    this.Unassigned != null &&
                    this.Unassigned.Equals(other.Unassigned)
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
                
                if (this.Costs != null)
                    hash = hash * 57 + this.Costs.GetHashCode();
                
                if (this.Distance != null)
                    hash = hash * 57 + this.Distance.GetHashCode();
                
                if (this.Time != null)
                    hash = hash * 57 + this.Time.GetHashCode();
                
                if (this.NoUnassigned != null)
                    hash = hash * 57 + this.NoUnassigned.GetHashCode();
                
                if (this.Routes != null)
                    hash = hash * 57 + this.Routes.GetHashCode();
                
                if (this.Unassigned != null)
                    hash = hash * 57 + this.Unassigned.GetHashCode();
                
                return hash;
            }
        }

    }
}
