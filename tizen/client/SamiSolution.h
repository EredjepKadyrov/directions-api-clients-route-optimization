/*
 * SamiSolution.h
 * 
 * 
 */

#ifndef SamiSolution_H_
#define SamiSolution_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::Long;
#include "SamiObject.h"
#include "SamiRoute.h"
using Tizen::Base::Collection::IList;
using Tizen::Base::Integer;


namespace Swagger {

class SamiSolution: public SamiObject {
public:
    SamiSolution();
    SamiSolution(String* json);
    virtual ~SamiSolution();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiSolution* fromJson(String* obj);

    
    Integer* getPCosts();
    void setPCosts(Integer* pCosts);
    
    Integer* getPDistance();
    void setPDistance(Integer* pDistance);
    
    Long* getPTime();
    void setPTime(Long* pTime);
    
    Integer* getPNoUnassigned();
    void setPNoUnassigned(Integer* pNo_unassigned);
    
    IList* getPRoutes();
    void setPRoutes(IList* pRoutes);
    
    SamiObject* getPUnassigned();
    void setPUnassigned(SamiObject* pUnassigned);
    

private:
    Integer* pCosts;
    Integer* pDistance;
    Long* pTime;
    Integer* pNo_unassigned;
    IList* pRoutes;
    SamiObject* pUnassigned;
    
};

} /* namespace Swagger */

#endif /* SamiSolution_H_ */
