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
  public class Service {
    
    /// <summary>
    /// Unique identifier of service
    /// </summary>
    /// <value>Unique identifier of service</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /// <summary>
    /// type of service
    /// </summary>
    /// <value>type of service</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// name of service
    /// </summary>
    /// <value>name of service</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    public string Name { get; set; }

    
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    public Address Address { get; set; }

    
    /// <summary>
    /// duration of service, i.e. time in ms the corresponding activity takes
    /// </summary>
    /// <value>duration of service, i.e. time in ms the corresponding activity takes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public long? Duration { get; set; }

    
    /// <summary>
    /// array of time windows. currently, only a single time window is allowed
    /// </summary>
    /// <value>array of time windows. currently, only a single time window is allowed</value>
    [DataMember(Name="time_windows", EmitDefaultValue=false)]
    public List<TimeWindow> TimeWindows { get; set; }

    
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
      sb.Append("class Service {\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("  Address: ").Append(Address).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
      sb.Append("  TimeWindows: ").Append(TimeWindows).Append("\n");
      
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
