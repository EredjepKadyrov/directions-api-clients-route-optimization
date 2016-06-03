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
  public class Route {
    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Route {\n");
      
      sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
      
      sb.Append("  Activities: ").Append(Activities).Append("\n");
      
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
