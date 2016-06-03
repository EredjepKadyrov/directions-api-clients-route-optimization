module SwaggerClient
  # 
  class Break < BaseObject
    attr_accessor :earliest, :latest, :duration
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # earliest start of break
        :'earliest' => :'earliest',
        
        # latest start of break
        :'latest' => :'latest',
        
        # duration of break
        :'duration' => :'duration'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'earliest' => :'Integer',
        :'latest' => :'Integer',
        :'duration' => :'Integer'
        
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
      
      if attributes[:'duration']
        self.duration = attributes[:'duration']
      end
      
    end

  end
end
