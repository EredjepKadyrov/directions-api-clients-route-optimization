#import "SWGSolution.h"

@implementation SWGSolution

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
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"costs": @"costs", @"distance": @"distance", @"time": @"time", @"transport_time": @"transportTime", @"max_operation_time": @"maxOperationTime", @"waiting_time": @"waitingTime", @"no_vehicles": @"noVehicles", @"no_unassigned": @"noUnassigned", @"routes": @"routes", @"unassigned": @"unassigned" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName {

  NSArray *optionalProperties = @[@"costs", @"distance", @"time", @"transportTime", @"maxOperationTime", @"waitingTime", @"noVehicles", @"noUnassigned", @"routes", @"unassigned"];
  return [optionalProperties containsObject:propertyName];
}

@end
