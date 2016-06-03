module GraphHopper
  # 
  class Request < BaseObject
    attr_accessor :vehicles, :vehicle_types, :services, :shipments, :relations, :algorithm
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # An array of vehicles that can be employed
        :'vehicles' => :'vehicles',
        
        # An array of vehicle types
        :'vehicle_types' => :'vehicle_types',
        
        # An array of services
        :'services' => :'services',
        
        # An array of shipments
        :'shipments' => :'shipments',
        
        # An array of relations
        :'relations' => :'relations',
        
        # 
        :'algorithm' => :'algorithm'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'vehicles' => :'Array<Vehicle>',
        :'vehicle_types' => :'Array<VehicleType>',
        :'services' => :'Array<Service>',
        :'shipments' => :'Array<Shipment>',
        :'relations' => :'Array<Relation>',
        :'algorithm' => :'Algorithm'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'vehicles']
        if (value = attributes[:'vehicles']).is_a?(Array)
          self.vehicles = value
        end
      end
      
      if attributes[:'vehicle_types']
        if (value = attributes[:'vehicle_types']).is_a?(Array)
          self.vehicle_types = value
        end
      end
      
      if attributes[:'services']
        if (value = attributes[:'services']).is_a?(Array)
          self.services = value
        end
      end
      
      if attributes[:'shipments']
        if (value = attributes[:'shipments']).is_a?(Array)
          self.shipments = value
        end
      end
      
      if attributes[:'relations']
        if (value = attributes[:'relations']).is_a?(Array)
          self.relations = value
        end
      end
      
      if attributes[:'algorithm']
        self.algorithm = attributes[:'algorithm']
      end
      
    end

  end
end
