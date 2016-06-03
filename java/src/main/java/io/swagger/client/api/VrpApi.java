package io.swagger.client.api;

import io.swagger.client.ApiCallback;
import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;

import com.google.gson.reflect.TypeToken;

import com.squareup.okhttp.Call;

import io.swagger.client.model.JobId;
import io.swagger.client.model.Request;

import java.lang.reflect.Type;
import java.util.*;

public class VrpApi {
  private ApiClient apiClient;

  public VrpApi() {
    this(Configuration.getDefaultApiClient());
  }

  public VrpApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  
  /* Build call for postVrp */
  private Call postVrpCall(String key, Request body) throws ApiException {
    Object postBody = body;
    
    // verify the required parameter 'key' is set
    if (key == null) {
       throw new ApiException("Missing the required parameter 'key' when calling postVrp(Async)");
    }
    
    // verify the required parameter 'body' is set
    if (body == null) {
       throw new ApiException("Missing the required parameter 'body' when calling postVrp(Async)");
    }
    

    // create path and map variables
    String path = "/optimize".replaceAll("\\{format\\}","json");

    List<Pair> queryParams = new ArrayList<Pair>();
    if (key != null)
      queryParams.addAll(apiClient.parameterToPairs("", "key", key));

    Map<String, String> headerParams = new HashMap<String, String>();

    Map<String, Object> formParams = new HashMap<String, Object>();

    final String[] accepts = {
      "application/json"
    };
    final String accept = apiClient.selectHeaderAccept(accepts);
    if (accept != null) headerParams.put("Accept", accept);

    final String[] contentTypes = {
      "application/json"
    };
    final String contentType = apiClient.selectHeaderContentType(contentTypes);
    headerParams.put("Content-Type", contentType);

    String[] authNames = new String[] { "api_key" };
    return apiClient.buildCall(path, "POST", queryParams, postBody, headerParams, formParams, authNames);
  }

  /**
   * Solves large routing problems
   * This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
   * @param key your API key
   * @param body Request object that contains the problem to be solved
   * @return JobId
   */
  public JobId postVrp(String key, Request body) throws ApiException {
    Call call = postVrpCall(key, body);
    Type returnType = new TypeToken<JobId>(){}.getType();
    return apiClient.execute(call, returnType);
  }

  /**
   * Solves large routing problems (asynchronously)
   * This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
   * @param key your API key
   * @param body Request object that contains the problem to be solved
   * @param callback The callback to be executed when the API call finishes
   * @return The request call
   */
  public Call postVrpAsync(String key, Request body, ApiCallback<JobId> callback) throws ApiException {
    Call call = postVrpCall(key, body);
    Type returnType = new TypeToken<JobId>(){}.getType();
    apiClient.executeAsync(call, returnType, callback);
    return call;
  }
  
}
