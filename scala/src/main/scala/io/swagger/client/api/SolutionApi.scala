package io.swagger.client.api

import io.swagger.client.model.Response
import io.swagger.client.ApiInvoker
import io.swagger.client.ApiException

import com.sun.jersey.multipart.FormDataMultiPart
import com.sun.jersey.multipart.file.FileDataBodyPart

import javax.ws.rs.core.MediaType

import java.io.File
import java.util.Date

import scala.collection.mutable.HashMap

class SolutionApi(val defBasePath: String = "https://graphhopper.com/api/1/vrp",
                        defApiInvoker: ApiInvoker = ApiInvoker) {
  var basePath = defBasePath
  var apiInvoker = defApiInvoker

  def addHeader(key: String, value: String) = apiInvoker.defaultHeaders += key -> value 

  
  /**
   * Return the solution associated to the jobId
   * This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
   * @param key your API key
   * @param jobId Request solution with jobId
   * @return Response
   */
  def getSolution (key: String, jobId: String) : Option[Response] = {
    // create path and map variables
    val path = "/solution/{jobId}".replaceAll("\\{format\\}","json").replaceAll("\\{" + "jobId" + "\\}",apiInvoker.escape(jobId))

    

    val contentTypes = List("application/json", "application/json")
    val contentType = contentTypes(0)

    // query params
    val queryParams = new HashMap[String, String]
    val headerParams = new HashMap[String, String]
    val formParams = new HashMap[String, String]

    

    if(String.valueOf(key) != "null") queryParams += "key" -> key.toString
    
    
    

    var postBody: AnyRef = null

    if(contentType.startsWith("multipart/form-data")) {
      val mp = new FormDataMultiPart()
      
      postBody = mp
    }
    else {
      
    }

    try {
      apiInvoker.invokeApi(basePath, path, "GET", queryParams.toMap, formParams.toMap, postBody, headerParams.toMap, contentType) match {
        case s: String =>
           Some(ApiInvoker.deserialize(s, "", classOf[Response]).asInstanceOf[Response])
         
        case _ => None
      }
    } catch {
      case ex: ApiException if ex.code == 404 => None
      case ex: ApiException => throw ex
    }
  }
  
}
