#import "SWGVehicle.h"

@implementation SWGVehicle

/**
 * Maps json key to property name.
 * This method is used by `JSONModel`.
 */
+ (JSONKeyMapper *)keyMapper
{
  return [[JSONKeyMapper alloc] initWithDictionary:@{ @"vehicle_id": @"vehicleId", @"type_id": @"typeId", @"start_address": @"startAddress", @"end_address": @"endAddress", @"break": @"_break", @"return_to_depot": @"returnToDepot", @"earliest_start": @"earliestStart", @"latest_end": @"latestEnd", @"skills": @"skills" }];
}

/**
 * Indicates whether the property with the given name is optional.
 * If `propertyName` is optional, then return `YES`, otherwise return `NO`.
 * This method is used by `JSONModel`.
 */
+ (BOOL)propertyIsOptional:(NSString *)propertyName
{
  NSArray *optionalProperties = @[@"vehicleId", @"typeId", @"startAddress", @"endAddress", @"_break", @"returnToDepot", @"earliestStart", @"latestEnd", @"skills"];

  if ([optionalProperties containsObject:propertyName]) {
    return YES;
  }
  else {
    return NO;
  }
}

/**
 * Gets the string presentation of the object.
 * This method will be called when logging model object using `NSLog`.
 */
- (NSString *)description {
    return [[self toDictionary] description];
}

@end
