module GraphHopper
  # 
  class Service < BaseObject
    attr_accessor :id, :type, :name, :address, :duration, :time_windows, :size, :required_skills, :allowed_vehicles
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # Unique identifier of service
        :'id' => :'id',
        
        # type of service
        :'type' => :'type',
        
        # name of service
        :'name' => :'name',
        
        # 
        :'address' => :'address',
        
        # duration of service, i.e. time in ms the corresponding activity takes
        :'duration' => :'duration',
        
        # array of time windows. currently, only a single time window is allowed
        :'time_windows' => :'time_windows',
        
        # array of capacity dimensions
        :'size' => :'size',
        
        # array of required skills
        :'required_skills' => :'required_skills',
        
        # array of allowed vehicle ids
        :'allowed_vehicles' => :'allowed_vehicles'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'id' => :'String',
        :'type' => :'String',
        :'name' => :'String',
        :'address' => :'Address',
        :'duration' => :'Integer',
        :'time_windows' => :'Array<TimeWindow>',
        :'size' => :'Array<Integer>',
        :'required_skills' => :'Array<String>',
        :'allowed_vehicles' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'address']
        self.address = attributes[:'address']
      end
      
      if attributes[:'duration']
        self.duration = attributes[:'duration']
      end
      
      if attributes[:'time_windows']
        if (value = attributes[:'time_windows']).is_a?(Array)
          self.time_windows = value
        end
      end
      
      if attributes[:'size']
        if (value = attributes[:'size']).is_a?(Array)
          self.size = value
        end
      end
      
      if attributes[:'required_skills']
        if (value = attributes[:'required_skills']).is_a?(Array)
          self.required_skills = value
        end
      end
      
      if attributes[:'allowed_vehicles']
        if (value = attributes[:'allowed_vehicles']).is_a?(Array)
          self.allowed_vehicles = value
        end
      end
      
    end

    def type=(type)
      allowed_values = ["service", "pickup", "delivery"]
      if type && !allowed_values.include?(type)
        fail "invalid value for 'type', must be one of #{allowed_values}"
      end
      @type = type
    end

  end
end
