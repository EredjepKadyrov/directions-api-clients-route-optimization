module GraphHopper
  # 
  class Solution < BaseObject
    attr_accessor :costs, :distance, :time, :no_unassigned, :routes, :unassigned
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # overall costs of solution
        :'costs' => :'costs',
        
        # overall travel distance in meters
        :'distance' => :'distance',
        
        # overall travel time in ms
        :'time' => :'time',
        
        # number of jobs that could not be assigned to final solution
        :'no_unassigned' => :'no_unassigned',
        
        # An array of routes
        :'routes' => :'routes',
        
        # 
        :'unassigned' => :'unassigned'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'costs' => :'Integer',
        :'distance' => :'Integer',
        :'time' => :'Integer',
        :'no_unassigned' => :'Integer',
        :'routes' => :'Array<Route>',
        :'unassigned' => :'Object'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'costs']
        self.costs = attributes[:'costs']
      end
      
      if attributes[:'distance']
        self.distance = attributes[:'distance']
      end
      
      if attributes[:'time']
        self.time = attributes[:'time']
      end
      
      if attributes[:'no_unassigned']
        self.no_unassigned = attributes[:'no_unassigned']
      end
      
      if attributes[:'routes']
        if (value = attributes[:'routes']).is_a?(Array)
          self.routes = value
        end
      end
      
      if attributes[:'unassigned']
        self.unassigned = attributes[:'unassigned']
      end
      
    end

  end
end
