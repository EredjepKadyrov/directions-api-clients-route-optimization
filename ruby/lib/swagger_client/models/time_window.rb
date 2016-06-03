module SwaggerClient
  # 
  class TimeWindow < BaseObject
    attr_accessor :earliest, :latest
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # earliest start time of corresponding activity
        :'earliest' => :'earliest',
        
        # latest start time of corresponding activity
        :'latest' => :'latest'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'earliest' => :'Integer',
        :'latest' => :'Integer'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'earliest']
        self.earliest = attributes[:'earliest']
      end
      
      if attributes[:'latest']
        self.latest = attributes[:'latest']
      end
      
    end

  end
end
