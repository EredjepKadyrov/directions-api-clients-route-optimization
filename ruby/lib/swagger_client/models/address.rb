module SwaggerClient
  # 
  class Address < BaseObject
    attr_accessor :location_id, :lon, :lat
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # Unique identifier of location
        :'location_id' => :'location_id',
        
        # longitude
        :'lon' => :'lon',
        
        # latitude
        :'lat' => :'lat'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'location_id' => :'String',
        :'lon' => :'Float',
        :'lat' => :'Float'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'location_id']
        self.location_id = attributes[:'location_id']
      end
      
      if attributes[:'lon']
        self.lon = attributes[:'lon']
      end
      
      if attributes[:'lat']
        self.lat = attributes[:'lat']
      end
      
    end

  end
end
