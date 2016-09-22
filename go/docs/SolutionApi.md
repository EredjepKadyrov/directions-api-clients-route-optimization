# \SolutionApi

All URIs are relative to *https://graphhopper.com/api/1/vrp*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSolution**](SolutionApi.md#GetSolution) | **Get** /solution/{jobId} | Return the solution associated to the jobId


# **GetSolution**
> Response GetSolution($key, $jobId)

Return the solution associated to the jobId

This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| your API key | 
 **jobId** | **string**| Request solution with jobId | 

### Return type

[**Response**](Response.md)

### Authorization

[api_key](../README.md#api_key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

