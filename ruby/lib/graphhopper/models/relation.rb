module GraphHopper
  # 
  class Relation < BaseObject
    attr_accessor :type, :ids, :vehicle_id
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # identifier of relation
        :'type' => :'type',
        
        # An array of ids that should be related
        :'ids' => :'ids',
        
        # vehicle id
        :'vehicle_id' => :'vehicle_id'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type' => :'String',
        :'ids' => :'Array<String>',
        :'vehicle_id' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
      if attributes[:'ids']
        if (value = attributes[:'ids']).is_a?(Array)
          self.ids = value
        end
      end
      
      if attributes[:'vehicle_id']
        self.vehicle_id = attributes[:'vehicle_id']
      end
      
    end

  end
end
