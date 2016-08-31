# WWW::SwaggerClient::SolutionApi

## Load the API package
```perl
use WWW::SwaggerClient::Object::SolutionApi;
```

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**get_solution**](SolutionApi.md#get_solution) | **GET** /solution/{jobId} | Return the solution associated to the jobId


# **get_solution**
> Response get_solution(key => $key, job_id => $job_id)

Return the solution associated to the jobId

This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 

### Example 
```perl
use Data::Dumper;

# Configure API key authorization: api_key
$WWW::SwaggerClient::Configuration::api_key->{'key'} = 'YOUR_API_KEY';
# uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$WWW::SwaggerClient::Configuration::api_key_prefix->{'key'} = "Bearer";

my $api_instance = WWW::SwaggerClient::SolutionApi->new();
my $key = 'key_example'; # string | your API key
my $job_id = 'job_id_example'; # string | Request solution with jobId

eval { 
    my $result = $api_instance->get_solution(key => $key, job_id => $job_id);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling SolutionApi->get_solution: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| your API key | 
 **job_id** | **string**| Request solution with jobId | 

### Return type

[**Response**](Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

