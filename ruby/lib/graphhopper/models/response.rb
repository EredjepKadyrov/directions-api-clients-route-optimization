module GraphHopper
  # 
  class Response < BaseObject
    attr_accessor :job_id, :status, :waiting_in_queue, :processing_time, :solution
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # unique identify of job - which you get when posting your request to the large problem solver
        :'job_id' => :'job_id',
        
        # indicates the current status of the job
        :'status' => :'status',
        
        # waiting time in ms
        :'waiting_in_queue' => :'waiting_in_queue',
        
        # processing time in ms. if job is still waiting in queue, processing_time is 0
        :'processing_time' => :'processing_time',
        
        # the solution. only available if status field indicates finished
        :'solution' => :'solution'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'job_id' => :'String',
        :'status' => :'String',
        :'waiting_in_queue' => :'Integer',
        :'processing_time' => :'Integer',
        :'solution' => :'Solution'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'job_id']
        self.job_id = attributes[:'job_id']
      end
      
      if attributes[:'status']
        self.status = attributes[:'status']
      end
      
      if attributes[:'waiting_in_queue']
        self.waiting_in_queue = attributes[:'waiting_in_queue']
      end
      
      if attributes[:'processing_time']
        self.processing_time = attributes[:'processing_time']
      end
      
      if attributes[:'solution']
        self.solution = attributes[:'solution']
      end
      
    end

    def status=(status)
      allowed_values = ["waiting_in_queue", "processing", "finished"]
      if status && !allowed_values.include?(status)
        fail "invalid value for 'status', must be one of #{allowed_values}"
      end
      @status = status
    end

  end
end
