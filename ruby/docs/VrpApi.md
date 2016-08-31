# GraphHopper::VrpApi

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**post_vrp**](VrpApi.md#post_vrp) | **POST** /optimize | Solves vehicle routing problems


# **post_vrp**
> JobId post_vrp(key, body)

Solves vehicle routing problems

This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution. 

### Example
```ruby
# load the gem
require 'graphhopper'
# setup authorization
GraphHopper.configure do |config|
  # Configure API key authorization: api_key
  config.api_key['key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['key'] = 'Bearer'
end

api_instance = GraphHopper::VrpApi.new

key = "key_example" # String | your API key

body = GraphHopper::Request.new # Request | Request object that contains the problem to be solved


begin
  #Solves vehicle routing problems
  result = api_instance.post_vrp(key, body)
  p result
rescue GraphHopper::ApiError => e
  puts "Exception when calling VrpApi->post_vrp: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **String**| your API key | 
 **body** | [**Request**](Request.md)| Request object that contains the problem to be solved | 

### Return type

[**JobId**](JobId.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



