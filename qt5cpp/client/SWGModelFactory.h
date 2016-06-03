#ifndef ModelFactory_H_
#define ModelFactory_H_


#include "SWGJobId.h"
#include "SWGRequest.h"
#include "SWGVehicle.h"
#include "SWGAlgorithm.h"
#include "SWGAddress.h"
#include "SWGBreak.h"
#include "SWGVehicleType.h"
#include "SWGService.h"
#include "SWGShipment.h"
#include "SWGStop.h"
#include "SWGTimeWindow.h"
#include "SWGRelation.h"
#include "SWGResponse.h"
#include "SWGSolution.h"
#include "SWGRoute.h"
#include "SWGActivity.h"

namespace Swagger {
  inline void* create(QString type) {
    if(QString("SWGJobId").compare(type) == 0) {
      return new SWGJobId();
    }
    if(QString("SWGRequest").compare(type) == 0) {
      return new SWGRequest();
    }
    if(QString("SWGVehicle").compare(type) == 0) {
      return new SWGVehicle();
    }
    if(QString("SWGAlgorithm").compare(type) == 0) {
      return new SWGAlgorithm();
    }
    if(QString("SWGAddress").compare(type) == 0) {
      return new SWGAddress();
    }
    if(QString("SWGBreak").compare(type) == 0) {
      return new SWGBreak();
    }
    if(QString("SWGVehicleType").compare(type) == 0) {
      return new SWGVehicleType();
    }
    if(QString("SWGService").compare(type) == 0) {
      return new SWGService();
    }
    if(QString("SWGShipment").compare(type) == 0) {
      return new SWGShipment();
    }
    if(QString("SWGStop").compare(type) == 0) {
      return new SWGStop();
    }
    if(QString("SWGTimeWindow").compare(type) == 0) {
      return new SWGTimeWindow();
    }
    if(QString("SWGRelation").compare(type) == 0) {
      return new SWGRelation();
    }
    if(QString("SWGResponse").compare(type) == 0) {
      return new SWGResponse();
    }
    if(QString("SWGSolution").compare(type) == 0) {
      return new SWGSolution();
    }
    if(QString("SWGRoute").compare(type) == 0) {
      return new SWGRoute();
    }
    if(QString("SWGActivity").compare(type) == 0) {
      return new SWGActivity();
    }
    
    return NULL;
  }

  inline void* create(QString json, QString type) {
    void* val = create(type);
    if(val != NULL) {
      SWGObject* obj = static_cast<SWGObject*>(val);
      return obj->fromJson(json);
    }
    if(type.startsWith("QString")) {
      return new QString();
    }
    return NULL;
  }
} /* namespace Swagger */

#endif /* ModelFactory_H_ */
