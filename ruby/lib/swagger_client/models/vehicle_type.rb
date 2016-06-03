module SwaggerClient
  # 
  class VehicleType < BaseObject
    attr_accessor :type_id, :profile, :capacity, :speed_factor, :service_time_factor
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # Unique identifier for the vehicle type
        :'type_id' => :'type_id',
        
        # Profile of vehicle type
        :'profile' => :'profile',
        
        # array of capacity dimensions
        :'capacity' => :'capacity',
        
        # speed_factor of vehicle type
        :'speed_factor' => :'speed_factor',
        
        # service time factor of vehicle type
        :'service_time_factor' => :'service_time_factor'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type_id' => :'String',
        :'profile' => :'String',
        :'capacity' => :'Array<Integer>',
        :'speed_factor' => :'Float',
        :'service_time_factor' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'type_id']
        self.type_id = attributes[:'type_id']
      end
      
      if attributes[:'profile']
        self.profile = attributes[:'profile']
      end
      
      if attributes[:'capacity']
        if (value = attributes[:'capacity']).is_a?(Array)
          self.capacity = value
        end
      end
      
      if attributes[:'speed_factor']
        self.speed_factor = attributes[:'speed_factor']
      end
      
      if attributes[:'service_time_factor']
        self.service_time_factor = attributes[:'service_time_factor']
      end
      
    end

    def profile=(profile)
      allowed_values = ["car", "bike", "foot", "mtb", "motorcycle", "racingbike", "truck", "small_truck", "bus"]
      if profile && !allowed_values.include?(profile)
        fail "invalid value for 'profile', must be one of #{allowed_values}"
      end
      @profile = profile
    end

  end
end
