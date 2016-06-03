using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVrpApi
    {
        
        /// <summary>
        /// Solves large routing problems
        /// </summary>
        /// <remarks>
        /// This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>JobId</returns>
        JobId PostVrp (string key, Request body);
  
        /// <summary>
        /// Solves large routing problems
        /// </summary>
        /// <remarks>
        /// This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>JobId</returns>
        System.Threading.Tasks.Task<JobId> PostVrpAsync (string key, Request body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VrpApi : IVrpApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VrpApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public VrpApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VrpApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VrpApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="body">Request object that contains the problem to be solved</param> 
        /// <returns>JobId</returns>            
        public JobId PostVrp (string key, Request body)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling PostVrp");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostVrp");
            
    
            var path = "/optimize";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostVrp: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling PostVrp: " + response.ErrorMessage, response.ErrorMessage);
    
            return (JobId) ApiClient.Deserialize(response.Content, typeof(JobId), response.Headers);
        }
    
        /// <summary>
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>JobId</returns>
        public async System.Threading.Tasks.Task<JobId> PostVrpAsync (string key, Request body)
        {
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling PostVrp");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostVrp");
            
    
            var path = "/optimize";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            
            
            
            postBody = ApiClient.Serialize(body); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling PostVrp: " + response.Content, response.Content);

            return (JobId) ApiClient.Deserialize(response.Content, typeof(JobId), response.Headers);
        }
        
    }
    
}
