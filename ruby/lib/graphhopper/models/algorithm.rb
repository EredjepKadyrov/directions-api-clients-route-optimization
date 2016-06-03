module GraphHopper
  # 
  class Algorithm < BaseObject
    attr_accessor :problem_type, :objective
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'problem_type' => :'problem_type',
        
        # 
        :'objective' => :'objective'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'problem_type' => :'String',
        :'objective' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'problem_type']
        self.problem_type = attributes[:'problem_type']
      end
      
      if attributes[:'objective']
        self.objective = attributes[:'objective']
      end
      
    end

    def problem_type=(problem_type)
      allowed_values = ["min", "min-max"]
      if problem_type && !allowed_values.include?(problem_type)
        fail "invalid value for 'problem_type', must be one of #{allowed_values}"
      end
      @problem_type = problem_type
    end

    def objective=(objective)
      allowed_values = ["transport_time", "completion_time"]
      if objective && !allowed_values.include?(objective)
        fail "invalid value for 'objective', must be one of #{allowed_values}"
      end
      @objective = objective
    end

  end
end
