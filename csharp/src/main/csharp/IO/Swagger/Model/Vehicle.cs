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
  public class Vehicle {
    
    /// <summary>
    /// Unique identifier of vehicle
    /// </summary>
    /// <value>Unique identifier of vehicle</value>
    [DataMember(Name="vehicle_id", EmitDefaultValue=false)]
    public string VehicleId { get; set; }

    
    /// <summary>
    /// Unique identifier referring to the available vehicle types
    /// </summary>
    /// <value>Unique identifier referring to the available vehicle types</value>
    [DataMember(Name="type_id", EmitDefaultValue=false)]
    public string TypeId { get; set; }

    
    /// <summary>
    /// Gets or Sets StartAddress
    /// </summary>
    [DataMember(Name="start_address", EmitDefaultValue=false)]
    public Address StartAddress { get; set; }

    
    /// <summary>
    /// Gets or Sets EndAddress
    /// </summary>
    [DataMember(Name="end_address", EmitDefaultValue=false)]
    public Address EndAddress { get; set; }

    
    /// <summary>
    /// Gets or Sets Break
    /// </summary>
    [DataMember(Name="break", EmitDefaultValue=false)]
    public Break Break { get; set; }

    
    /// <summary>
    /// Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.
    /// </summary>
    /// <value>Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.</value>
    [DataMember(Name="return_to_depot", EmitDefaultValue=false)]
    public bool? ReturnToDepot { get; set; }

    
    /// <summary>
    /// earliest start of vehicle at its start location
    /// </summary>
    /// <value>earliest start of vehicle at its start location</value>
    [DataMember(Name="earliest_start", EmitDefaultValue=false)]
    public long? EarliestStart { get; set; }

    
    /// <summary>
    /// latest end of vehicle at its end location
    /// </summary>
    /// <value>latest end of vehicle at its end location</value>
    [DataMember(Name="latest_end", EmitDefaultValue=false)]
    public long? LatestEnd { get; set; }

    
    /// <summary>
    /// array of skills
    /// </summary>
    /// <value>array of skills</value>
    [DataMember(Name="skills", EmitDefaultValue=false)]
    public List<string> Skills { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Vehicle {\n");
      
      sb.Append("  VehicleId: ").Append(VehicleId).Append("\n");
      
      sb.Append("  TypeId: ").Append(TypeId).Append("\n");
      
      sb.Append("  StartAddress: ").Append(StartAddress).Append("\n");
      
      sb.Append("  EndAddress: ").Append(EndAddress).Append("\n");
      
      sb.Append("  Break: ").Append(Break).Append("\n");
      
      sb.Append("  ReturnToDepot: ").Append(ReturnToDepot).Append("\n");
      
      sb.Append("  EarliestStart: ").Append(EarliestStart).Append("\n");
      
      sb.Append("  LatestEnd: ").Append(LatestEnd).Append("\n");
      
      sb.Append("  Skills: ").Append(Skills).Append("\n");
      
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
