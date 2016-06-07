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
    public class Address :  IEquatable<Address>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        public Address()
        {
            
        }

        
        /// <summary>
        /// Unique identifier of location
        /// </summary>
        /// <value>Unique identifier of location</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public string LocationId { get; set; }
  
        
        /// <summary>
        /// longitude
        /// </summary>
        /// <value>longitude</value>
        [DataMember(Name="lon", EmitDefaultValue=false)]
        public double? Lon { get; set; }
  
        
        /// <summary>
        /// latitude
        /// </summary>
        /// <value>latitude</value>
        [DataMember(Name="lat", EmitDefaultValue=false)]
        public double? Lat { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  Lon: ").Append(Lon).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="obj">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LocationId == other.LocationId ||
                    this.LocationId != null &&
                    this.LocationId.Equals(other.LocationId)
                ) && 
                (
                    this.Lon == other.Lon ||
                    this.Lon != null &&
                    this.Lon.Equals(other.Lon)
                ) && 
                (
                    this.Lat == other.Lat ||
                    this.Lat != null &&
                    this.Lat.Equals(other.Lat)
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
                
                if (this.LocationId != null)
                    hash = hash * 57 + this.LocationId.GetHashCode();
                
                if (this.Lon != null)
                    hash = hash * 57 + this.Lon.GetHashCode();
                
                if (this.Lat != null)
                    hash = hash * 57 + this.Lat.GetHashCode();
                
                return hash;
            }
        }

    }
}
