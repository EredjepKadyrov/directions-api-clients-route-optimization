module GraphHopper
  # 
  class Vehicle < BaseObject
    attr_accessor :vehicle_id, :type_id, :start_address, :end_address, :_break, :return_to_depot, :earliest_start, :latest_end, :skills
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # Unique identifier of vehicle
        :'vehicle_id' => :'vehicle_id',
        
        # Unique identifier referring to the available vehicle types
        :'type_id' => :'type_id',
        
        # 
        :'start_address' => :'start_address',
        
        # 
        :'end_address' => :'end_address',
        
        # 
        :'_break' => :'break',
        
        # Indicates whether vehicle should return to start address or not. If not, it can end at any service activity.
        :'return_to_depot' => :'return_to_depot',
        
        # earliest start of vehicle at its start location
        :'earliest_start' => :'earliest_start',
        
        # latest end of vehicle at its end location
        :'latest_end' => :'latest_end',
        
        # array of skills
        :'skills' => :'skills'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'vehicle_id' => :'String',
        :'type_id' => :'String',
        :'start_address' => :'Address',
        :'end_address' => :'Address',
        :'_break' => :'Break',
        :'return_to_depot' => :'BOOLEAN',
        :'earliest_start' => :'Integer',
        :'latest_end' => :'Integer',
        :'skills' => :'Array<String>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'vehicle_id']
        self.vehicle_id = attributes[:'vehicle_id']
      end
      
      if attributes[:'type_id']
        self.type_id = attributes[:'type_id']
      end
      
      if attributes[:'start_address']
        self.start_address = attributes[:'start_address']
      end
      
      if attributes[:'end_address']
        self.end_address = attributes[:'end_address']
      end
      
      if attributes[:'break']
        self._break = attributes[:'break']
      end
      
      if attributes[:'return_to_depot']
        self.return_to_depot = attributes[:'return_to_depot']
      end
      
      if attributes[:'earliest_start']
        self.earliest_start = attributes[:'earliest_start']
      end
      
      if attributes[:'latest_end']
        self.latest_end = attributes[:'latest_end']
      end
      
      if attributes[:'skills']
        if (value = attributes[:'skills']).is_a?(Array)
          self.skills = value
        end
      end
      
    end

  end
end
