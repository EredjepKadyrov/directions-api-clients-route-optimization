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
  public class Break {
    
    /// <summary>
    /// earliest start of break
    /// </summary>
    /// <value>earliest start of break</value>
    [DataMember(Name="earliest", EmitDefaultValue=false)]
    public long? Earliest { get; set; }

    
    /// <summary>
    /// latest start of break
    /// </summary>
    /// <value>latest start of break</value>
    [DataMember(Name="latest", EmitDefaultValue=false)]
    public long? Latest { get; set; }

    
    /// <summary>
    /// duration of break
    /// </summary>
    /// <value>duration of break</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public long? Duration { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Break {\n");
      
      sb.Append("  Earliest: ").Append(Earliest).Append("\n");
      
      sb.Append("  Latest: ").Append(Latest).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
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
