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
  public class TimeWindow {
    
    /// <summary>
    /// earliest start time of corresponding activity
    /// </summary>
    /// <value>earliest start time of corresponding activity</value>
    [DataMember(Name="earliest", EmitDefaultValue=false)]
    public long? Earliest { get; set; }

    
    /// <summary>
    /// latest start time of corresponding activity
    /// </summary>
    /// <value>latest start time of corresponding activity</value>
    [DataMember(Name="latest", EmitDefaultValue=false)]
    public long? Latest { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TimeWindow {\n");
      
      sb.Append("  Earliest: ").Append(Earliest).Append("\n");
      
      sb.Append("  Latest: ").Append(Latest).Append("\n");
      
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
