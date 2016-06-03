module SwaggerClient
  # 
  class JobId < BaseObject
    attr_accessor :job_id
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # unique id for your job/request with which you can fetch your solution
        :'job_id' => :'job_id'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'job_id' => :'String'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'job_id']
        self.job_id = attributes[:'job_id']
      end
      
    end

  end
end
