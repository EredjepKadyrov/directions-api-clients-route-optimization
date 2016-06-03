/*
 * SamiActivity.h
 * 
 * 
 */

#ifndef SamiActivity_H_
#define SamiActivity_H_

#include <FApp.h>
#include <FBase.h>
#include <FSystem.h>
#include <FWebJson.h>
#include "SamiHelpers.h"
#include "SamiObject.h"

using namespace Tizen::Web::Json;


using Tizen::Base::Long;
using Tizen::Base::String;


namespace Swagger {

class SamiActivity: public SamiObject {
public:
    SamiActivity();
    SamiActivity(String* json);
    virtual ~SamiActivity();

    void init();

    void cleanup();

    String asJson ();

    JsonObject* asJsonObject();

    void fromJsonObject(IJsonValue* json);

    SamiActivity* fromJson(String* obj);

    
    String* getPType();
    void setPType(String* pType);
    
    String* getPId();
    void setPId(String* pId);
    
    String* getPLocationId();
    void setPLocationId(String* pLocation_id);
    
    Long* getPArrTime();
    void setPArrTime(Long* pArr_time);
    
    Long* getPEndTime();
    void setPEndTime(Long* pEnd_time);
    

private:
    String* pType;
    String* pId;
    String* pLocation_id;
    Long* pArr_time;
    Long* pEnd_time;
    
};

} /* namespace Swagger */

#endif /* SamiActivity_H_ */
