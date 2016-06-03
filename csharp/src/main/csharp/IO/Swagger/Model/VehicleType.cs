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
  public class VehicleType {
    
    /// <summary>
    /// Unique identifier for the vehicle type
    /// </summary>
    /// <value>Unique identifier for the vehicle type</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    public string TypeId { get; set; }

    
    /// <summary>
    /// Profile of vehicle type
    /// </summary>
    /// <value>Profile of vehicle type</value>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    public string Profile { get; set; }

    
    /// <summary>
    /// array of capacity dimensions
    /// </summary>
    /// <value>array of capacity dimensions</value>
    [DataMember(Name="capacity", EmitDefaultValue=false)]
    public List<int?> Capacity { get; set; }

    
    /// <summary>
    /// speed_factor of vehicle type
    /// </summary>
    /// <value>speed_factor of vehicle type</value>
    [DataMember(Name="speed_factor", EmitDefaultValue=false)]
    public double? SpeedFactor { get; set; }

    
    /// <summary>
    /// service time factor of vehicle type
    /// </summary>
    /// <value>service time factor of vehicle type</value>
    [DataMember(Name="service_time_factor", EmitDefaultValue=false)]
    public double? ServiceTimeFactor { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VehicleType {\n");
      
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      
      sb.Append("  Capacity: ").Append(Capacity).Append("\n");
      
      sb.Append("  SpeedFactor: ").Append(SpeedFactor).Append("\n");
      
      sb.Append("  ServiceTimeFactor: ").Append(ServiceTimeFactor).Append("\n");
      
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
