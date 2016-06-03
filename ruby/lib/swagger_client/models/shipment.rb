module SwaggerClient
  # 
  class Shipment < BaseObject
    attr_accessor :id, :name, :pickup, :delivery, :size, :required_skills, :allowed_vehicles
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # Unique identifier of service
        :'id' => :'id',
        
        # name of shipment
        :'name' => :'name',
        
        # 
        :'pickup' => :'pickup',
        
        # 
        :'delivery' => :'delivery',
        
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
        :'name' => :'String',
        :'pickup' => :'Stop',
        :'delivery' => :'Stop',
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
      
      if attributes[:'name']
        self.name = attributes[:'name']
      end
      
      if attributes[:'pickup']
        self.pickup = attributes[:'pickup']
      end
      
      if attributes[:'delivery']
        self.delivery = attributes[:'delivery']
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

  end
end
