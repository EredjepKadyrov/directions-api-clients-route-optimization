/*
 * SamiBreak.h
 * 
 * 
 */

#ifndef SamiBreak_H_
#define SamiBreak_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::Long;


namespace Swagger {

class SamiBreak: public SamiObject {
public:
    SamiBreak();
    SamiBreak(String* json);
    virtual ~SamiBreak();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiBreak* fromJson(String* obj);

    
    Long* getPEarliest();
    void setPEarliest(Long* pEarliest);
    
    Long* getPLatest();
    void setPLatest(Long* pLatest);
    
    Long* getPDuration();
    void setPDuration(Long* pDuration);
    

private:
    Long* pEarliest;
    Long* pLatest;
    Long* pDuration;
    
};

} /* namespace Swagger */

#endif /* SamiBreak_H_ */
