#ifndef ModelFactory_H_
#define ModelFactory_H_

#include "SamiObject.h"

#include "SamiJobId.h"
#include "SamiRequest.h"
#include "SamiVehicle.h"
#include "SamiAlgorithm.h"
#include "SamiAddress.h"
#include "SamiBreak.h"
#include "SamiVehicleType.h"
#include "SamiService.h"
#include "SamiShipment.h"
#include "SamiStop.h"
#include "SamiTimeWindow.h"
#include "SamiRelation.h"
#include "SamiResponse.h"
#include "SamiSolution.h"
#include "SamiRoute.h"
#include "SamiActivity.h"
#include "SamiSolution_unassigned.h"

namespace Swagger {
  void*
  create(String type) {
    if(type.Equals(L"SamiJobId", true)) {
      return new SamiJobId();
    }
    if(type.Equals(L"SamiRequest", true)) {
      return new SamiRequest();
    }
    if(type.Equals(L"SamiVehicle", true)) {
      return new SamiVehicle();
    }
    if(type.Equals(L"SamiAlgorithm", true)) {
      return new SamiAlgorithm();
    }
    if(type.Equals(L"SamiAddress", true)) {
      return new SamiAddress();
    }
    if(type.Equals(L"SamiBreak", true)) {
      return new SamiBreak();
    }
    if(type.Equals(L"SamiVehicleType", true)) {
      return new SamiVehicleType();
    }
    if(type.Equals(L"SamiService", true)) {
      return new SamiService();
    }
    if(type.Equals(L"SamiShipment", true)) {
      return new SamiShipment();
    }
    if(type.Equals(L"SamiStop", true)) {
      return new SamiStop();
    }
    if(type.Equals(L"SamiTimeWindow", true)) {
      return new SamiTimeWindow();
    }
    if(type.Equals(L"SamiRelation", true)) {
      return new SamiRelation();
    }
    if(type.Equals(L"SamiResponse", true)) {
      return new SamiResponse();
    }
    if(type.Equals(L"SamiSolution", true)) {
      return new SamiSolution();
    }
    if(type.Equals(L"SamiRoute", true)) {
      return new SamiRoute();
    }
    if(type.Equals(L"SamiActivity", true)) {
      return new SamiActivity();
    }
    if(type.Equals(L"SamiSolution_unassigned", true)) {
      return new SamiSolution_unassigned();
    }
    
    if(type.Equals(L"String", true)) {
      return new String();
    }
    if(type.Equals(L"Integer", true)) {
      return new Integer();
    }
    if(type.Equals(L"Long", true)) {
      return new Long();
    }
    if(type.Equals(L"DateTime", true)) {
      return new DateTime();
    }
    return null;
  }
} /* namespace Swagger */

#endif /* ModelFactory_H_ */
