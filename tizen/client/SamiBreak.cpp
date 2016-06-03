
#include "SamiBreak.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiBreak::SamiBreak() {
    init();
}

SamiBreak::~SamiBreak() {
    this->cleanup();
}

void
SamiBreak::init() {
    pEarliest = null;
    pLatest = null;
    pDuration = null;
    
}

void
SamiBreak::cleanup() {
    if(pEarliest != null) {
        
        delete pEarliest;
        pEarliest = null;
    }
    if(pLatest != null) {
        
        delete pLatest;
        pLatest = null;
    }
    if(pDuration != null) {
        
        delete pDuration;
        pDuration = null;
    }
    
}


SamiBreak*
SamiBreak::fromJson(String* json) {
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
SamiBreak::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pEarliestKey = new JsonString(L"earliest");
        IJsonValue* pEarliestVal = null;
        pJsonObject->GetValue(pEarliestKey, pEarliestVal);
        if(pEarliestVal != null) {
            
            pEarliest = new Long();
            jsonToValue(pEarliest, pEarliestVal, L"Long", L"Long");
        }
        delete pEarliestKey;
        JsonString* pLatestKey = new JsonString(L"latest");
        IJsonValue* pLatestVal = null;
        pJsonObject->GetValue(pLatestKey, pLatestVal);
        if(pLatestVal != null) {
            
            pLatest = new Long();
            jsonToValue(pLatest, pLatestVal, L"Long", L"Long");
        }
        delete pLatestKey;
        JsonString* pDurationKey = new JsonString(L"duration");
        IJsonValue* pDurationVal = null;
        pJsonObject->GetValue(pDurationKey, pDurationVal);
        if(pDurationVal != null) {
            
            pDuration = new Long();
            jsonToValue(pDuration, pDurationVal, L"Long", L"Long");
        }
        delete pDurationKey;
        
    }
}

SamiBreak::SamiBreak(String* json) {
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
SamiBreak::asJson ()
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
SamiBreak::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pEarliestKey = new JsonString(L"earliest");
    pJsonObject->Add(pEarliestKey, toJson(getPEarliest(), "Long", ""));

    
    JsonString *pLatestKey = new JsonString(L"latest");
    pJsonObject->Add(pLatestKey, toJson(getPLatest(), "Long", ""));

    
    JsonString *pDurationKey = new JsonString(L"duration");
    pJsonObject->Add(pDurationKey, toJson(getPDuration(), "Long", ""));

    
    return pJsonObject;
}

Long*
SamiBreak::getPEarliest() {
    return pEarliest;
}
void
SamiBreak::setPEarliest(Long* pEarliest) {
    this->pEarliest = pEarliest;
}

Long*
SamiBreak::getPLatest() {
    return pLatest;
}
void
SamiBreak::setPLatest(Long* pLatest) {
    this->pLatest = pLatest;
}

Long*
SamiBreak::getPDuration() {
    return pDuration;
}
void
SamiBreak::setPDuration(Long* pDuration) {
    this->pDuration = pDuration;
}



} /* namespace Swagger */

