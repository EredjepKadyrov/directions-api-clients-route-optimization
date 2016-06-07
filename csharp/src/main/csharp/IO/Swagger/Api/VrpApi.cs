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
        /// <returns>ApiResponse of JobId</returns>
        ApiResponse<JobId> PostVrpWithHttpInfo (string key, Request body);

        /// <summary>
        /// Solves large routing problems
        /// </summary>
        /// <remarks>
        /// This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>Task of JobId</returns>
        System.Threading.Tasks.Task<JobId> PostVrpAsync (string key, Request body);

        /// <summary>
        /// Solves large routing problems
        /// </summary>
        /// <remarks>
        /// This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </remarks>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>Task of ApiResponse (JobId)</returns>
        System.Threading.Tasks.Task<ApiResponse<JobId>> PostVrpAsyncWithHttpInfo (string key, Request body);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class VrpApi : IVrpApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VrpApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VrpApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VrpApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VrpApi(Configuration configuration = null)
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
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="body">Request object that contains the problem to be solved</param> 
        /// <returns>JobId</returns>
        public JobId PostVrp (string key, Request body)
        {
             ApiResponse<JobId> response = PostVrpWithHttpInfo(key, body);
             return response.Data;
        }

        /// <summary>
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param> 
        /// <param name="body">Request object that contains the problem to be solved</param> 
        /// <returns>ApiResponse of JobId</returns>
        public ApiResponse< JobId > PostVrpWithHttpInfo (string key, Request body)
        {
            
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling PostVrp");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostVrp");
            
    
            var path_ = "/optimize";
    
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
            
            if (key != null) queryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (api_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                queryParams["key"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostVrp: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostVrp: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JobId>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobId) Configuration.ApiClient.Deserialize(response, typeof(JobId)));
            
        }
    
        /// <summary>
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>Task of JobId</returns>
        public async System.Threading.Tasks.Task<JobId> PostVrpAsync (string key, Request body)
        {
             ApiResponse<JobId> response = await PostVrpAsyncWithHttpInfo(key, body);
             return response.Data;

        }

        /// <summary>
        /// Solves large routing problems This endpoint solves large problems, i.e. traveling salesman or vehicle routing problems, and returns the solution.
        /// </summary>
        /// <param name="key">your API key</param>
        /// <param name="body">Request object that contains the problem to be solved</param>
        /// <returns>Task of ApiResponse (JobId)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JobId>> PostVrpAsyncWithHttpInfo (string key, Request body)
        {
            // verify the required parameter 'key' is set
            if (key == null) throw new ApiException(400, "Missing required parameter 'key' when calling PostVrp");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PostVrp");
            
    
            var path_ = "/optimize";
    
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
            
            if (key != null) queryParams.Add("key", Configuration.ApiClient.ParameterToString(key)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (api_key) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("key");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                queryParams["key"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostVrp: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostVrp: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JobId>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JobId) Configuration.ApiClient.Deserialize(response, typeof(JobId)));
            
        }
        
    }
    
}
