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
  public class Activity {
    
    /// <summary>
    /// type of activity
    /// </summary>
    /// <value>type of activity</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    public string Type { get; set; }

    
    /// <summary>
    /// id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to
    /// </summary>
    /// <value>id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    public string Id { get; set; }

    
    /// <summary>
    /// id that refers to address
    /// </summary>
    /// <value>id that refers to address</value>
    [DataMember(Name="location_id", EmitDefaultValue=false)]
    public string LocationId { get; set; }

    
    /// <summary>
    /// arrival time at this activity in ms
    /// </summary>
    /// <value>arrival time at this activity in ms</value>
    [DataMember(Name="arr_time", EmitDefaultValue=false)]
    public long? ArrTime { get; set; }

    
    /// <summary>
    /// end time of and thus departure time at this activity
    /// </summary>
    /// <value>end time of and thus departure time at this activity</value>
    [DataMember(Name="end_time", EmitDefaultValue=false)]
    public long? EndTime { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Activity {\n");
      
      sb.Append("  Type: ").Append(Type).Append("\n");
      
      sb.Append("  Id: ").Append(Id).Append("\n");
      
      sb.Append("  LocationId: ").Append(LocationId).Append("\n");
      
      sb.Append("  ArrTime: ").Append(ArrTime).Append("\n");
      
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      
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
