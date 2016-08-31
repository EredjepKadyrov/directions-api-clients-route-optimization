# GraphHopper::SolutionApi

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](SolutionApi.md#get_solution) | **GET** /solution/{jobId} | Return the solution associated to the jobId


# **get_solution**
> Response get_solution(key, job_id)

Return the solution associated to the jobId

This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 

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

api_instance = GraphHopper::SolutionApi.new

key = "key_example" # String | your API key

job_id = "job_id_example" # String | Request solution with jobId


begin
  #Return the solution associated to the jobId
  result = api_instance.get_solution(key, job_id)
  p result
rescue GraphHopper::ApiError => e
  puts "Exception when calling SolutionApi->get_solution: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **String**| your API key | 
 **job_id** | **String**| Request solution with jobId | 

### Return type

[**Response**](Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



