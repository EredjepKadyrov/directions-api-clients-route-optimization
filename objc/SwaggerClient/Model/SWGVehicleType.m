#import "SWGVehicleType.h"

@implementation SWGVehicleType

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
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"type_id": @"typeId", @"profile": @"profile", @"capacity": @"capacity", @"speed_factor": @"speedFactor", @"service_time_factor": @"serviceTimeFactor" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"typeId", @"profile", @"capacity", @"speedFactor", @"serviceTimeFactor"];
  return [optionalProperties containsObject:propertyName];
}

@end
