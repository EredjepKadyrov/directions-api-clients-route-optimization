using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
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
        /// <returns>ApiResponse of Response</returns>
        ApiResponse<Response> GetSolutionWithHttpInfo (string key, string jobId);

        /// <summary>
        /// Return the solution associated to the jobId
        /// </summary>
        /// <remarks>
        /// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Task of Response</returns>
        System.Threading.Tasks.Task<Response> GetSolutionAsync (string key, string jobId);

        /// <summary>
        /// Return the solution associated to the jobId
        /// </summary>
        /// <remarks>
        /// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<Response>> GetSolutionAsyncWithHttpInfo (string key, string jobId);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SolutionApi : ISolutionApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SolutionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SolutionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SolutionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="jobId">Request solution with jobId</param> 
        /// <returns>Response</returns>
        public Response GetSolution (string key, string jobId)
        {
             ApiResponse<Response> response = GetSolutionWithHttpInfo(key, jobId);
             return response.Data;
        }

        /// <summary>
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="jobId">Request solution with jobId</param> 
        /// <returns>ApiResponse of Response</returns>
        public ApiResponse< Response > GetSolutionWithHttpInfo (string key, string jobId)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSolution");
            
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetSolution");
            
    
            var path_ = "/solution/{jobId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            if (key != null) queryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                queryParams["key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSolution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSolution: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
    
        /// <summary>
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Task of Response</returns>
        public async System.Threading.Tasks.Task<Response> GetSolutionAsync (string key, string jobId)
        {
             ApiResponse<Response> response = await GetSolutionAsyncWithHttpInfo(key, jobId);
             return response.Data;

        }

        /// <summary>
        /// Return the solution associated to the jobId This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="jobId">Request solution with jobId</param>
        /// <returns>Task of ApiResponse (Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Response>> GetSolutionAsyncWithHttpInfo (string key, string jobId)
        {
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling GetSolution");
            // verify the required parameter 'jobId' is set
            if (jobId == null) throw new ApiException(400, "Missing required parameter 'jobId' when calling GetSolution");
            
    
            var path_ = "/solution/{jobId}";
    
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
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (jobId != null) pathParams.Add("jobId", Configuration.ApiClient.ParameterToString(jobId)); // path parameter
            
            if (key != null) queryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            

            
            // authentication (api_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                queryParams["key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSolution: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSolution: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Response>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Response) Configuration.ApiClient.Deserialize(response, typeof(Response)));
            
        }
        
    }
    
}
