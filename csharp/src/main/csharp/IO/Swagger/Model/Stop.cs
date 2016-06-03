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
  public class Stop {
    
    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    public Address Address { get; set; }

    
    /// <summary>
    /// duration of stop, i.e. time in ms the corresponding activity takes
    /// </summary>
    /// <value>duration of stop, i.e. time in ms the corresponding activity takes</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    public long? Duration { get; set; }

    
    /// <summary>
    /// array of time windows. currently, only a single time window is allowed
    /// </summary>
    /// <value>array of time windows. currently, only a single time window is allowed</value>
    [DataMember(Name="time_windows", EmitDefaultValue=false)]
    public List<TimeWindow> TimeWindows { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Stop {\n");
      
      sb.Append("  Address: ").Append(Address).Append("\n");
      
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      
      sb.Append("  TimeWindows: ").Append(TimeWindows).Append("\n");
      
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
