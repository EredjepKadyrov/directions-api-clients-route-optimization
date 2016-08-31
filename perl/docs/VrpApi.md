# WWW::SwaggerClient::VrpApi

## Load the API package
```perl
use WWW::SwaggerClient::Object::VrpApi;
```

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**post_vrp**](VrpApi.md#post_vrp) | **POST** /optimize | Solves vehicle routing problems


# **post_vrp**
> JobId post_vrp(key => $key, body => $body)

Solves vehicle routing problems

This endpoint for solving vehicle routing problems, i.e. traveling salesman or vehicle routing problems, and returns the solution. 

### Example 
```perl
use Data::Dumper;

# Configure API key authorization: api_key
$WWW::SwaggerClient::Configuration::api_key->{'key'} = 'YOUR_API_KEY';
# uncomment below to setup prefix (e.g. Bearer) for API key, if needed
#$WWW::SwaggerClient::Configuration::api_key_prefix->{'key'} = "Bearer";

my $api_instance = WWW::SwaggerClient::VrpApi->new();
my $key = 'key_example'; # string | your API key
my $body = WWW::SwaggerClient::Object::Request->new(); # Request | Request object that contains the problem to be solved

eval { 
    my $result = $api_instance->post_vrp(key => $key, body => $body);
    print Dumper($result);
};
if ($@) {
    warn "Exception when calling VrpApi->post_vrp: $@\n";
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| your API key | 
 **body** | [**Request**](Request.md)| Request object that contains the problem to be solved | 

### Return type

[**JobId**](JobId.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

