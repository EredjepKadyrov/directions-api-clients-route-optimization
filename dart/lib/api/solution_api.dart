part of api;


class SolutionApi {
  String basePath = "https://graphhopper.com/api/1/vrp";
  ApiClient apiClient = ApiClient.defaultApiClient;

  SolutionApi([ApiClient apiClient]) {
    if (apiClient != null) {
      this.apiClient = apiClient;
    }
  }

  
  /// Return the solution associated to the jobId
  ///
  /// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
  Future<Response> getSolution(String key, String jobId) {
    Object postBody = null;
    

    // create path and map variables
    String path = "/solution/{jobId}".replaceAll("{format}","json").replaceAll("{" + "jobId" + "}", jobId.toString());

    // query params
    Map<String, String> queryParams = {};
    Map<String, String> headerParams = {};
    Map<String, String> formParams = {};
    if("null" != key)
      queryParams["key"] = key is List ? key.join(',') : key;
    
    

    List<String> contentTypes = ["application/json"];

    String contentType = contentTypes.length > 0 ? contentTypes[0] : "application/json";
    List<String> authNames = ["api_key"];

    if(contentType.startsWith("multipart/form-data")) {
      bool hasFields = false;
      MultipartRequest mp = new MultipartRequest(null, null);
      
      if(hasFields)
        postBody = mp;
    }
    else {
      
    }

    return apiClient.invokeAPI(basePath, path, 'GET', queryParams, postBody, headerParams, formParams, contentType, authNames).then((response) {
      if(response.statusCode >= 400) {
        throw new ApiException(response.statusCode, response.body);
      }
      else if(response.body != null){
        return ApiClient.deserialize(response.body, Response);
      }
      else {
        return null;
      }
    });
  }
  
}
