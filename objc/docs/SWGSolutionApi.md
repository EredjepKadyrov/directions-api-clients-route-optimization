# SWGSolutionApi

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**getSolution**](SWGSolutionApi.md#getsolution) | **GET** /solution/{jobId} | Return the solution associated to the jobId


# **getSolution**
```objc
-(NSNumber*) getSolutionWithKey: (NSString*) key
    jobId: (NSString*) jobId
        completionHandler: (void (^)(SWGResponse* output, NSError* error)) handler;
```

Return the solution associated to the jobId

This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 

### Example 
```objc
SWGConfiguration *apiConfig = [SWGConfiguration sharedConfig];

// Configure API key authorization: (authentication scheme: api_key)
[apiConfig setApiKey:@"YOUR_API_KEY" forApiKeyIdentifier:@"key"];
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
//[apiConfig setApiKeyPrefix:@"Bearer" forApiKeyIdentifier:@"key"];


NSString* key = @"key_example"; // your API key
NSString* jobId = @"jobId_example"; // Request solution with jobId

SWGSolutionApi*apiInstance = [[SWGSolutionApi alloc] init];

// Return the solution associated to the jobId
[apiInstance getSolutionWithKey:key
              jobId:jobId
          completionHandler: ^(SWGResponse* output, NSError* error) {
                        if (output) {
                            NSLog(@"%@", output);
                        }
                        if (error) {
                            NSLog(@"Error calling SWGSolutionApi->getSolution: %@", error);
                        }
                    }];
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **NSString***| your API key | 
 **jobId** | **NSString***| Request solution with jobId | 

### Return type

[**SWGResponse***](SWGResponse.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

