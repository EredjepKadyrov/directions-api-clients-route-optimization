#import "SWGSolutionApi.h"
#import "SWGQueryParamCollection.h"
#import "SWGResponse.h"


@interface SWGSolutionApi ()
    @property (readwrite, nonatomic, strong) NSMutableDictionary *defaultHeaders;
@end

@implementation SWGSolutionApi

static SWGSolutionApi* singletonAPI = nil;

#pragma mark - Initialize methods

- (id) init {
    self = [super init];
    if (self) {
        SWGConfiguration *config = [SWGConfiguration sharedConfig];
        if (config.apiClient == nil) {
            config.apiClient = [[SWGApiClient alloc] init];
        }
        self.apiClient = config.apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

- (id) initWithApiClient:(SWGApiClient *)apiClient {
    self = [super init];
    if (self) {
        self.apiClient = apiClient;
        self.defaultHeaders = [NSMutableDictionary dictionary];
    }
    return self;
}

#pragma mark -

+(SWGSolutionApi*) apiWithHeader:(NSString*)headerValue key:(NSString*)key {

    if (singletonAPI == nil) {
        singletonAPI = [[SWGSolutionApi alloc] init];
        [singletonAPI addHeader:headerValue forKey:key];
    }
    return singletonAPI;
}

+(SWGSolutionApi*) sharedAPI {

    if (singletonAPI == nil) {
        singletonAPI = [[SWGSolutionApi alloc] init];
    }
    return singletonAPI;
}

-(void) addHeader:(NSString*)value forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(void) setHeaderValue:(NSString*) value
           forKey:(NSString*)key {
    [self.defaultHeaders setValue:value forKey:key];
}

-(unsigned long) requestQueueSize {
    return [SWGApiClient requestQueueSize];
}

#pragma mark - Api Methods

///
/// Return the solution associated to the jobId
/// This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent.
///  @param key your API key
///
///  @param jobId Request solution with jobId
///
///  @returns SWGResponse*
///
-(NSNumber*) getSolutionWithCompletionBlock: (NSString*) key
         jobId: (NSString*) jobId
        
        completionHandler: (void (^)(SWGResponse* output, NSError* error))completionBlock { 
        

    
    // verify the required parameter 'key' is set
    if (key == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `key` when calling `getSolution`"];
    }
    
    // verify the required parameter 'jobId' is set
    if (jobId == nil) {
        [NSException raise:@"Invalid parameter" format:@"Missing the required parameter `jobId` when calling `getSolution`"];
    }
    

    NSMutableString* resourcePath = [NSMutableString stringWithFormat:@"/solution/{jobId}"];

    // remove format in URL if needed
    if ([resourcePath rangeOfString:@".{format}"].location != NSNotFound) {
        [resourcePath replaceCharactersInRange: [resourcePath rangeOfString:@".{format}"] withString:@".json"];
    }

    NSMutableDictionary *pathParams = [[NSMutableDictionary alloc] init];
    if (jobId != nil) {
        pathParams[@"jobId"] = jobId;
    }
    

    NSMutableDictionary* queryParams = [[NSMutableDictionary alloc] init];
    if(key != nil) {
        
        queryParams[@"key"] = key;
    }
    
    NSMutableDictionary* headerParams = [NSMutableDictionary dictionaryWithDictionary:self.defaultHeaders];

    

    // HTTP header `Accept`
    headerParams[@"Accept"] = [SWGApiClient selectHeaderAccept:@[@"application/json"]];
    if ([headerParams[@"Accept"] length] == 0) {
        [headerParams removeObjectForKey:@"Accept"];
    }

    // response content type
    NSString *responseContentType;
    if ([headerParams objectForKey:@"Accept"]) {
        responseContentType = [headerParams[@"Accept"] componentsSeparatedByString:@", "][0];
    }
    else {
        responseContentType = @"";
    }

    // request content type
    NSString *requestContentType = [SWGApiClient selectHeaderContentType:@[@"application/json"]];

    // Authentication setting
    NSArray *authSettings = @[@"api_key"];

    id bodyParam = nil;
    NSMutableDictionary *formParams = [[NSMutableDictionary alloc] init];
    NSMutableDictionary *files = [[NSMutableDictionary alloc] init];
    
    
    

    
    return [self.apiClient requestWithCompletionBlock: resourcePath
                                               method: @"GET"
                                           pathParams: pathParams
                                          queryParams: queryParams
                                           formParams: formParams
                                                files: files
                                                 body: bodyParam
                                         headerParams: headerParams
                                         authSettings: authSettings
                                   requestContentType: requestContentType
                                  responseContentType: responseContentType
                                         responseType: @"SWGResponse*"
                                      completionBlock: ^(id data, NSError *error) {
                  
                  completionBlock((SWGResponse*)data, error);
              }
          ];
}



@end
