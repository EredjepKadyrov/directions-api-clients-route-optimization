/*
 * SamiRequest.h
 * 
 * 
 */

#ifndef SamiRequest_H_
#define SamiRequest_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


#include "SamiVehicle.h"
#include "SamiAlgorithm.h"
#include "SamiRelation.h"
#include "SamiVehicleType.h"
using Tizen::Base::Collection::IList;
#include "SamiService.h"
#include "SamiShipment.h"


namespace Swagger {

class SamiRequest: public SamiObject {
public:
    SamiRequest();
    SamiRequest(String* json);
    virtual ~SamiRequest();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiRequest* fromJson(String* obj);

    
    IList* getPVehicles();
    void setPVehicles(IList* pVehicles);
    
    IList* getPVehicleTypes();
    void setPVehicleTypes(IList* pVehicle_types);
    
    IList* getPServices();
    void setPServices(IList* pServices);
    
    IList* getPShipments();
    void setPShipments(IList* pShipments);
    
    IList* getPRelations();
    void setPRelations(IList* pRelations);
    
    SamiAlgorithm* getPAlgorithm();
    void setPAlgorithm(SamiAlgorithm* pAlgorithm);
    

private:
    IList* pVehicles;
    IList* pVehicle_types;
    IList* pServices;
    IList* pShipments;
    IList* pRelations;
    SamiAlgorithm* pAlgorithm;
    
};

} /* namespace Swagger */

#endif /* SamiRequest_H_ */
