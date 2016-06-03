module GraphHopper
  # 
  class Route < BaseObject
    attr_accessor :vehicle_id, :activities
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # id of vehicle that operates route
        :'vehicle_id' => :'vehicle_id',
        
        # array of activities
        :'activities' => :'activities'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'vehicle_id' => :'String',
        :'activities' => :'Array<Activity>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'vehicle_id']
        self.vehicle_id = attributes[:'vehicle_id']
      end
      
      if attributes[:'activities']
        if (value = attributes[:'activities']).is_a?(Array)
          self.activities = value
        end
      end
      
    end

  end
end
