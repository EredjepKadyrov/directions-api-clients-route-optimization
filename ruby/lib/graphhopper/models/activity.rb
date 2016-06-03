module GraphHopper
  # 
  class Activity < BaseObject
    attr_accessor :type, :id, :location_id, :arr_time, :end_time
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # type of activity
        :'type' => :'type',
        
        # id referring to the underlying service or shipment, i.e. the shipment or service this activity belongs to
        :'id' => :'id',
        
        # id that refers to address
        :'location_id' => :'location_id',
        
        # arrival time at this activity in ms
        :'arr_time' => :'arr_time',
        
        # end time of and thus departure time at this activity
        :'end_time' => :'end_time'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'type' => :'String',
        :'id' => :'String',
        :'location_id' => :'String',
        :'arr_time' => :'Integer',
        :'end_time' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'type']
        self.type = attributes[:'type']
      end
      
      if attributes[:'id']
        self.id = attributes[:'id']
      end
      
      if attributes[:'location_id']
        self.location_id = attributes[:'location_id']
      end
      
      if attributes[:'arr_time']
        self.arr_time = attributes[:'arr_time']
      end
      
      if attributes[:'end_time']
        self.end_time = attributes[:'end_time']
      end
      
    end

    def type=(type)
      allowed_values = ["start", "end", "service", "pickupShipment", "deliverShipment"]
      if type && !allowed_values.include?(type)
        fail "invalid value for 'type', must be one of #{allowed_values}"
      end
      @type = type
    end

  end
end
