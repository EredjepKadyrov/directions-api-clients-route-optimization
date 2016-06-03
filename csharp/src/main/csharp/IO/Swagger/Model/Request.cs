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
  public class Request {
    
    /// <summary>
    /// An array of vehicles that can be employed
    /// </summary>
    /// <value>An array of vehicles that can be employed</value>
    [DataMember(Name="vehicles", EmitDefaultValue=false)]
    public List<Vehicle> Vehicles { get; set; }

    
    /// <summary>
    /// An array of vehicle types
    /// </summary>
    /// <value>An array of vehicle types</value>
    [DataMember(Name="vehicle_types", EmitDefaultValue=false)]
    public List<VehicleType> VehicleTypes { get; set; }

    
    /// <summary>
    /// An array of services
    /// </summary>
    /// <value>An array of services</value>
    [DataMember(Name="services", EmitDefaultValue=false)]
    public List<Service> Services { get; set; }

    
    /// <summary>
    /// An array of shipments
    /// </summary>
    /// <value>An array of shipments</value>
    [DataMember(Name="shipments", EmitDefaultValue=false)]
    public List<Shipment> Shipments { get; set; }

    
    /// <summary>
    /// An array of relations
    /// </summary>
    /// <value>An array of relations</value>
    [DataMember(Name="relations", EmitDefaultValue=false)]
    public List<Relation> Relations { get; set; }

    
    /// <summary>
    /// Gets or Sets Algorithm
    /// </summary>
    [DataMember(Name="algorithm", EmitDefaultValue=false)]
    public Algorithm Algorithm { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Request {\n");
      
      sb.Append("  Vehicles: ").Append(Vehicles).Append("\n");
      
      sb.Append("  VehicleTypes: ").Append(VehicleTypes).Append("\n");
      
      sb.Append("  Services: ").Append(Services).Append("\n");
      
      sb.Append("  Shipments: ").Append(Shipments).Append("\n");
      
      sb.Append("  Relations: ").Append(Relations).Append("\n");
      
      sb.Append("  Algorithm: ").Append(Algorithm).Append("\n");
      
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
