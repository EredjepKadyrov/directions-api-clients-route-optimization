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
  public class Solution {
    
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
    public Object Unassigned { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
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
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
