#import "SWGRequest.h"

@implementation SWGRequest

- (instancetype)init {
  self = [super init];
  if (self) {
    // initialize property's default value, if any
    
  }
  return self;
}


/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper {
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"vehicles": @"vehicles", @"vehicle_types": @"vehicleTypes", @"services": @"services", @"shipments": @"shipments", @"relations": @"relations", @"algorithm": @"algorithm", @"objectives": @"objectives", @"cost_matrices": @"costMatrices" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"vehicles", @"vehicleTypes", @"services", @"shipments", @"relations", @"algorithm", @"objectives", @"costMatrices"];
  return [optionalProperties containsObject:propertyName];
}

@end
