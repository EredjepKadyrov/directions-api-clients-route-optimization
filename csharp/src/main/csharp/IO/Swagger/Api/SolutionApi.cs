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
    public interface ISolutionApi
    {
        
        /// <summary>
        /// Return the solution associated to the jobId
        /// </summary>
        /// <remarks>
        /// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Response</returns>
        Response GetSolution (string key, string jobId);
  
        /// <summary>
        /// Return the solution associated to the jobId
        /// </summary>
        /// <remarks>
        /// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Response</returns>
        System.Threading.Tasks.Task<Response> GetSolutionAsync (string key, string jobId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SolutionApi : ISolutionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SolutionApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SolutionApi(String basePath)
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
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="jobId">Request solution with jobId</param> 
        /// <returns>Response</returns>            
        public Response GetSolution (string key, string jobId)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSolution");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetSolution");
            
    
            var path = "/solution/{jobId}";
    
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
            if (jobId != null) pathParams.Add("jobId", ApiClient.ParameterToString(jobId)); // path parameter
            
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSolution: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSolution: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Response) ApiClient.Deserialize(response.Content, typeof(Response), response.Headers);
        }
    
        /// <summary>
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Response</returns>
        public async System.Threading.Tasks.Task<Response> GetSolutionAsync (string key, string jobId)
        {
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSolution");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetSolution");
            
    
            var path = "/solution/{jobId}";
    
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
            if (jobId != null) pathParams.Add("jobId", ApiClient.ParameterToString(jobId)); // path parameter
            
            if (key != null) queryParams.Add("key", ApiClient.ParameterToString(key)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "api_key" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSolution: " + response.Content, response.Content);

            return (Response) ApiClient.Deserialize(response.Content, typeof(Response), response.Headers);
        }
        
    }
    
}
