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
  public class Shipment {
    
    /// <summary>
    /// Unique identifier of service
    /// </summary>
    /// <value>Unique identifier of service</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /// <summary>
    /// name of shipment
    /// </summary>
    /// <value>name of shipment</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Pickup
    /// </summary>
    [DataMember(Name="pickup", EmitDefaultValue=false)]
    public Stop Pickup { get; set; }

    
    /// <summary>
    /// Gets or Sets Delivery
    /// </summary>
    [DataMember(Name="delivery", EmitDefaultValue=false)]
    public Stop Delivery { get; set; }

    
    /// <summary>
    /// array of capacity dimensions
    /// </summary>
    /// <value>array of capacity dimensions</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    public List<int?> Size { get; set; }

    
    /// <summary>
    /// array of required skills
    /// </summary>
    /// <value>array of required skills</value>
    [DataMember(Name="required_skills", EmitDefaultValue=false)]
    public List<string> RequiredSkills { get; set; }

    
    /// <summary>
    /// array of allowed vehicle ids
    /// </summary>
    /// <value>array of allowed vehicle ids</value>
    [DataMember(Name="allowed_vehicles", EmitDefaultValue=false)]
    public List<string> AllowedVehicles { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Shipment {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Pickup: ").Append(Pickup).Append("\n");
      
      sb.Append("  Delivery: ").Append(Delivery).Append("\n");
      
      sb.Append("  Size: ").Append(Size).Append("\n");
      
      sb.Append("  RequiredSkills: ").Append(RequiredSkills).Append("\n");
      
      sb.Append("  AllowedVehicles: ").Append(AllowedVehicles).Append("\n");
      
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
