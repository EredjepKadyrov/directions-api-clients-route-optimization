# Common files
require 'swagger_client/api_client'
require 'swagger_client/api_error'
require 'swagger_client/version'
require 'swagger_client/configuration'

# Models
require 'swagger_client/models/base_object'
require 'swagger_client/models/job_id'
require 'swagger_client/models/request'
require 'swagger_client/models/vehicle'
require 'swagger_client/models/algorithm'
require 'swagger_client/models/address'
require 'swagger_client/models/break'
require 'swagger_client/models/vehicle_type'
require 'swagger_client/models/service'
require 'swagger_client/models/shipment'
require 'swagger_client/models/stop'
require 'swagger_client/models/time_window'
require 'swagger_client/models/relation'
require 'swagger_client/models/response'
require 'swagger_client/models/solution'
require 'swagger_client/models/route'
require 'swagger_client/models/activity'

# APIs
require 'swagger_client/api/vrp_api'
require 'swagger_client/api/solution_api'

module SwaggerClient
  class << self
    # Configure sdk using block.
    # SwaggerClient.configure do |config|
    #   config.username = "xxx"
    #   config.password = "xxx"
    # end
    # If no block given, return the configuration singleton instance.
    def configure
      if block_given?
        yield Configuration.instance
      else
        Configuration.instance
      end
    end
  end
end
