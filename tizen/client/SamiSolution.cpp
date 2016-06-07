
#include "SamiSolution.h"
#include <FLocales.h>

using namespace Tizen::Base;
using namespace Tizen::System;
using namespace Tizen::Base::Utility;
using namespace Tizen::Base::Collection;
using namespace Tizen::Web::Json;
using namespace Tizen::Locales;


namespace Swagger {

SamiSolution::SamiSolution() {
    init();
}

SamiSolution::~SamiSolution() {
    this->cleanup();
}

void
SamiSolution::init() {
    pCosts = null;
    pDistance = null;
    pTime = null;
    pNo_unassigned = null;
    pRoutes = null;
    pUnassigned = null;
    
}

void
SamiSolution::cleanup() {
    if(pCosts != null) {
        
        delete pCosts;
        pCosts = null;
    }
    if(pDistance != null) {
        
        delete pDistance;
        pDistance = null;
    }
    if(pTime != null) {
        
        delete pTime;
        pTime = null;
    }
    if(pNo_unassigned != null) {
        
        delete pNo_unassigned;
        pNo_unassigned = null;
    }
    if(pRoutes != null) {
        pRoutes->RemoveAll(true);
        delete pRoutes;
        pRoutes = null;
    }
    if(pUnassigned != null) {
        
        delete pUnassigned;
        pUnassigned = null;
    }
    
}


SamiSolution*
SamiSolution::fromJson(String* json) {
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
SamiSolution::fromJsonObject(IJsonValue* pJson) {
    JsonObject* pJsonObject = static_cast< JsonObject* >(pJson);

    if(pJsonObject != null) {
        JsonString* pCostsKey = new JsonString(L"costs");
        IJsonValue* pCostsVal = null;
        pJsonObject->GetValue(pCostsKey, pCostsVal);
        if(pCostsVal != null) {
            
            pCosts = new Integer();
            jsonToValue(pCosts, pCostsVal, L"Integer", L"Integer");
        }
        delete pCostsKey;
        JsonString* pDistanceKey = new JsonString(L"distance");
        IJsonValue* pDistanceVal = null;
        pJsonObject->GetValue(pDistanceKey, pDistanceVal);
        if(pDistanceVal != null) {
            
            pDistance = new Integer();
            jsonToValue(pDistance, pDistanceVal, L"Integer", L"Integer");
        }
        delete pDistanceKey;
        JsonString* pTimeKey = new JsonString(L"time");
        IJsonValue* pTimeVal = null;
        pJsonObject->GetValue(pTimeKey, pTimeVal);
        if(pTimeVal != null) {
            
            pTime = new Long();
            jsonToValue(pTime, pTimeVal, L"Long", L"Long");
        }
        delete pTimeKey;
        JsonString* pNo_unassignedKey = new JsonString(L"no_unassigned");
        IJsonValue* pNo_unassignedVal = null;
        pJsonObject->GetValue(pNo_unassignedKey, pNo_unassignedVal);
        if(pNo_unassignedVal != null) {
            
            pNo_unassigned = new Integer();
            jsonToValue(pNo_unassigned, pNo_unassignedVal, L"Integer", L"Integer");
        }
        delete pNo_unassignedKey;
        JsonString* pRoutesKey = new JsonString(L"routes");
        IJsonValue* pRoutesVal = null;
        pJsonObject->GetValue(pRoutesKey, pRoutesVal);
        if(pRoutesVal != null) {
            pRoutes = new ArrayList();
            
            jsonToValue(pRoutes, pRoutesVal, L"IList", L"SamiRoute");
        }
        delete pRoutesKey;
        JsonString* pUnassignedKey = new JsonString(L"unassigned");
        IJsonValue* pUnassignedVal = null;
        pJsonObject->GetValue(pUnassignedKey, pUnassignedVal);
        if(pUnassignedVal != null) {
            
            pUnassigned = new SamiSolution_unassigned();
            jsonToValue(pUnassigned, pUnassignedVal, L"SamiSolution_unassigned", L"SamiSolution_unassigned");
        }
        delete pUnassignedKey;
        
    }
}

SamiSolution::SamiSolution(String* json) {
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
SamiSolution::asJson ()
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
SamiSolution::asJsonObject() {
    JsonObject *pJsonObject = new JsonObject();
    pJsonObject->Construct();

    
    JsonString *pCostsKey = new JsonString(L"costs");
    pJsonObject->Add(pCostsKey, toJson(getPCosts(), "Integer", ""));

    
    JsonString *pDistanceKey = new JsonString(L"distance");
    pJsonObject->Add(pDistanceKey, toJson(getPDistance(), "Integer", ""));

    
    JsonString *pTimeKey = new JsonString(L"time");
    pJsonObject->Add(pTimeKey, toJson(getPTime(), "Long", ""));

    
    JsonString *pNo_unassignedKey = new JsonString(L"no_unassigned");
    pJsonObject->Add(pNo_unassignedKey, toJson(getPNoUnassigned(), "Integer", ""));

    
    JsonString *pRoutesKey = new JsonString(L"routes");
    pJsonObject->Add(pRoutesKey, toJson(getPRoutes(), "SamiRoute", "array"));

    
    JsonString *pUnassignedKey = new JsonString(L"unassigned");
    pJsonObject->Add(pUnassignedKey, toJson(getPUnassigned(), "SamiSolution_unassigned", ""));

    
    return pJsonObject;
}

Integer*
SamiSolution::getPCosts() {
    return pCosts;
}
void
SamiSolution::setPCosts(Integer* pCosts) {
    this->pCosts = pCosts;
}

Integer*
SamiSolution::getPDistance() {
    return pDistance;
}
void
SamiSolution::setPDistance(Integer* pDistance) {
    this->pDistance = pDistance;
}

Long*
SamiSolution::getPTime() {
    return pTime;
}
void
SamiSolution::setPTime(Long* pTime) {
    this->pTime = pTime;
}

Integer*
SamiSolution::getPNoUnassigned() {
    return pNo_unassigned;
}
void
SamiSolution::setPNoUnassigned(Integer* pNo_unassigned) {
    this->pNo_unassigned = pNo_unassigned;
}

IList*
SamiSolution::getPRoutes() {
    return pRoutes;
}
void
SamiSolution::setPRoutes(IList* pRoutes) {
    this->pRoutes = pRoutes;
}

SamiSolution_unassigned*
SamiSolution::getPUnassigned() {
    return pUnassigned;
}
void
SamiSolution::setPUnassigned(SamiSolution_unassigned* pUnassigned) {
    this->pUnassigned = pUnassigned;
}



} /* namespace Swagger */

