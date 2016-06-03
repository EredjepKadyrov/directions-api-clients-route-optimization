using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Address {
    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Address {\n");
      
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      
      sb.Append("  Lon: ").Append(Lon).Append("\n");
      
      sb.Append("  Lat: ").Append(Lat).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
