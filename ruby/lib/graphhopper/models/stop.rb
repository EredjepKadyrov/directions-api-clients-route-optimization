module GraphHopper
  # 
  class Stop < BaseObject
    attr_accessor :address, :duration, :time_windows
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'address' => :'address',
        
        # duration of stop, i.e. time in ms the corresponding activity takes
        :'duration' => :'duration',
        
        # array of time windows. currently, only a single time window is allowed
        :'time_windows' => :'time_windows'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'address' => :'Address',
        :'duration' => :'Integer',
        :'time_windows' => :'Array<TimeWindow>'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
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
      
    end

  end
end
