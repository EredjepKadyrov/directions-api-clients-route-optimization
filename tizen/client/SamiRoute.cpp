
#include "SamiRoute.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiRoute::SamiRoute() {
    init();
}

SamiRoute::~SamiRoute() {
    this->cleanup();
}

void
SamiRoute::init() {
    pVehicle_id = null;
pActivities = null;
}

void
SamiRoute::cleanup() {
    if(pVehicle_id != null) {
        
        delete pVehicle_id;
        pVehicle_id = null;
    }
if(pActivities != null) {
        pActivities->RemoveAll(true);
        delete pActivities;
        pActivities = null;
    }
}


SamiRoute*
SamiRoute::fromJson(String* json) {
    this->cleanup();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
    return this;
}


void
SamiRoute::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pVehicle_idKey = new JsonString(L"vehicle_id");
        IJsonValue* pVehicle_idVal = null;
        pJsonObject->GetValue(pVehicle_idKey, pVehicle_idVal);
        if(pVehicle_idVal != null) {
            
            pVehicle_id = new String();
            jsonToValue(pVehicle_id, pVehicle_idVal, L"String", L"String");
        }
        delete pVehicle_idKey;
JsonString* pActivitiesKey = new JsonString(L"activities");
        IJsonValue* pActivitiesVal = null;
        pJsonObject->GetValue(pActivitiesKey, pActivitiesVal);
        if(pActivitiesVal != null) {
            pActivities = new ArrayList();
            
            jsonToValue(pActivities, pActivitiesVal, L"IList", L"SamiActivity");
        }
        delete pActivitiesKey;
    }
}

SamiRoute::SamiRoute(String* json) {
    init();
    String str(json->GetPointer());
    int length = str.GetLength();

    ByteBuffer buffer;
    buffer.Construct(length);

    for (int i = 0; i < length; ++i) {
       byte b = str[i];
       buffer.SetByte(b);
    }

    IJsonValue* pJson = JsonParser::ParseN(buffer);
    fromJsonObject(pJson);
    if (pJson->GetType() == JSON_TYPE_OBJECT) {
       JsonObject* pObject = static_cast< JsonObject* >(pJson);
       pObject->RemoveAll(true);
    }
    else if (pJson->GetType() == JSON_TYPE_ARRAY) {
       JsonArray* pArray = static_cast< JsonArray* >(pJson);
       pArray->RemoveAll(true);
    }
    delete pJson;
}

String
SamiRoute::asJson ()
{
    JsonObject* pJsonObject = asJsonObject();

    char *pComposeBuf = new char[256];
    JsonWriter::Compose(pJsonObject, pComposeBuf, 256);
    String s = String(pComposeBuf);

    delete pComposeBuf;
    pJsonObject->RemoveAll(true);
    delete pJsonObject;

    return s;
}

JsonObject*
SamiRoute::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    JsonString *pVehicle_idKey = new JsonString(L"vehicle_id");
    pJsonObject->Add(pVehicle_idKey, toJson(getPVehicleId(), "String", ""));

    JsonString *pActivitiesKey = new JsonString(L"activities");
    pJsonObject->Add(pActivitiesKey, toJson(getPActivities(), "SamiActivity", "array"));

    return pJsonObject;
}

String*
SamiRoute::getPVehicleId() {
    return pVehicle_id;
}
void
SamiRoute::setPVehicleId(String* pVehicle_id) {
    this->pVehicle_id = pVehicle_id;
}

IList*
SamiRoute::getPActivities() {
    return pActivities;
}
void
SamiRoute::setPActivities(IList* pActivities) {
    this->pActivities = pActivities;
}



} /* namespace Swagger */

