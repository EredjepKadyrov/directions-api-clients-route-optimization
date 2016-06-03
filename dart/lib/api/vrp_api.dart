part of api;


class VrpApi {
  String basePath = "https://graphhopper.com/api/1/vrp";
  ApiClient apiClient = ApiClient.defaultApiClient;

  VrpApi([ApiClient apiClient]) {
    if (apiClient != null) {
      this.apiClient = apiClient;
    }
  }

  
  /// Solves large routing problems
  ///
  /// This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
  Future<JobId> postVrp(String key, Request body) {
    Object postBody = body;
    

    // create path and map variables
    String path = "/optimize".replaceAll("{format}","json");

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

    return apiClient.invokeAPI(basePath, path, 'POST', queryParams, postBody, headerParams, formParams, contentType, authNames).then((response) {
      if(response.statusCode >= 400) {
        throw new ApiException(response.statusCode, response.body);
      }
      else if(response.body != null){
        return ApiClient.deserialize(response.body, JobId);
      }
      else {
        return null;
      }
    });
  }
  
}
