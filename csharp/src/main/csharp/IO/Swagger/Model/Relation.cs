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
  public class Relation {
    
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Relation {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      
      sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
      
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
