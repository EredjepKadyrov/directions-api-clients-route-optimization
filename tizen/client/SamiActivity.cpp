
#include "SamiActivity.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiActivity::SamiActivity() {
    init();
}

SamiActivity::~SamiActivity() {
    this->cleanup();
}

void
SamiActivity::init() {
    pType = null;
    pId = null;
    pLocation_id = null;
    pArr_time = null;
    pEnd_time = null;
    
}

void
SamiActivity::cleanup() {
    if(pType != null) {
        
        delete pType;
        pType = null;
    }
    if(pId != null) {
        
        delete pId;
        pId = null;
    }
    if(pLocation_id != null) {
        
        delete pLocation_id;
        pLocation_id = null;
    }
    if(pArr_time != null) {
        
        delete pArr_time;
        pArr_time = null;
    }
    if(pEnd_time != null) {
        
        delete pEnd_time;
        pEnd_time = null;
    }
    
}


SamiActivity*
SamiActivity::fromJson(String* json) {
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
SamiActivity::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pTypeKey = new JsonString(L"type");
        IJsonValue* pTypeVal = null;
        pJsonObject->GetValue(pTypeKey, pTypeVal);
        if(pTypeVal != null) {
            
            pType = new String();
            jsonToValue(pType, pTypeVal, L"String", L"String");
        }
        delete pTypeKey;
        JsonString* pIdKey = new JsonString(L"id");
        IJsonValue* pIdVal = null;
        pJsonObject->GetValue(pIdKey, pIdVal);
        if(pIdVal != null) {
            
            pId = new String();
            jsonToValue(pId, pIdVal, L"String", L"String");
        }
        delete pIdKey;
        JsonString* pLocation_idKey = new JsonString(L"location_id");
        IJsonValue* pLocation_idVal = null;
        pJsonObject->GetValue(pLocation_idKey, pLocation_idVal);
        if(pLocation_idVal != null) {
            
            pLocation_id = new String();
            jsonToValue(pLocation_id, pLocation_idVal, L"String", L"String");
        }
        delete pLocation_idKey;
        JsonString* pArr_timeKey = new JsonString(L"arr_time");
        IJsonValue* pArr_timeVal = null;
        pJsonObject->GetValue(pArr_timeKey, pArr_timeVal);
        if(pArr_timeVal != null) {
            
            pArr_time = new Long();
            jsonToValue(pArr_time, pArr_timeVal, L"Long", L"Long");
        }
        delete pArr_timeKey;
        JsonString* pEnd_timeKey = new JsonString(L"end_time");
        IJsonValue* pEnd_timeVal = null;
        pJsonObject->GetValue(pEnd_timeKey, pEnd_timeVal);
        if(pEnd_timeVal != null) {
            
            pEnd_time = new Long();
            jsonToValue(pEnd_time, pEnd_timeVal, L"Long", L"Long");
        }
        delete pEnd_timeKey;
        
    }
}

SamiActivity::SamiActivity(String* json) {
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
SamiActivity::asJson ()
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
SamiActivity::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pTypeKey = new JsonString(L"type");
    pJsonObject->Add(pTypeKey, toJson(getPType(), "String", ""));

    
    JsonString *pIdKey = new JsonString(L"id");
    pJsonObject->Add(pIdKey, toJson(getPId(), "String", ""));

    
    JsonString *pLocation_idKey = new JsonString(L"location_id");
    pJsonObject->Add(pLocation_idKey, toJson(getPLocationId(), "String", ""));

    
    JsonString *pArr_timeKey = new JsonString(L"arr_time");
    pJsonObject->Add(pArr_timeKey, toJson(getPArrTime(), "Long", ""));

    
    JsonString *pEnd_timeKey = new JsonString(L"end_time");
    pJsonObject->Add(pEnd_timeKey, toJson(getPEndTime(), "Long", ""));

    
    return pJsonObject;
}

String*
SamiActivity::getPType() {
    return pType;
}
void
SamiActivity::setPType(String* pType) {
    this->pType = pType;
}

String*
SamiActivity::getPId() {
    return pId;
}
void
SamiActivity::setPId(String* pId) {
    this->pId = pId;
}

String*
SamiActivity::getPLocationId() {
    return pLocation_id;
}
void
SamiActivity::setPLocationId(String* pLocation_id) {
    this->pLocation_id = pLocation_id;
}

Long*
SamiActivity::getPArrTime() {
    return pArr_time;
}
void
SamiActivity::setPArrTime(Long* pArr_time) {
    this->pArr_time = pArr_time;
}

Long*
SamiActivity::getPEndTime() {
    return pEnd_time;
}
void
SamiActivity::setPEndTime(Long* pEnd_time) {
    this->pEnd_time = pEnd_time;
}



} /* namespace Swagger */

