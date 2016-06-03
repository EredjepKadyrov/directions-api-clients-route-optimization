
#include "SWGRequest.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGRequest::SWGRequest(QString* json) {
    init();
    this->fromJson(*json);
}

SWGRequest::SWGRequest() {
    init();
}

SWGRequest::~SWGRequest() {
    this->cleanup();
}

void
SWGRequest::init() {
    vehicles = new QList<SWGVehicle*>();
    vehicle_types = new QList<SWGVehicleType*>();
    services = new QList<SWGService*>();
    shipments = new QList<SWGShipment*>();
    relations = new QList<SWGRelation*>();
    algorithm = new SWGAlgorithm();
    
}

void
SWGRequest::cleanup() {
    if(vehicles != NULL) {
        QList<SWGVehicle*>* arr = vehicles;
        foreach(SWGVehicle* o, *arr) {
            delete o;
        }
        delete vehicles;
    }
    if(vehicle_types != NULL) {
        QList<SWGVehicleType*>* arr = vehicle_types;
        foreach(SWGVehicleType* o, *arr) {
            delete o;
        }
        delete vehicle_types;
    }
    if(services != NULL) {
        QList<SWGService*>* arr = services;
        foreach(SWGService* o, *arr) {
            delete o;
        }
        delete services;
    }
    if(shipments != NULL) {
        QList<SWGShipment*>* arr = shipments;
        foreach(SWGShipment* o, *arr) {
            delete o;
        }
        delete shipments;
    }
    if(relations != NULL) {
        QList<SWGRelation*>* arr = relations;
        foreach(SWGRelation* o, *arr) {
            delete o;
        }
        delete relations;
    }
    if(algorithm != NULL) {
        delete algorithm;
    }
    
}

SWGRequest*
SWGRequest::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGRequest::fromJsonObject(QJsonObject &pJson) {
    setValue(&vehicles, pJson["vehicles"], "QList", "SWGVehicle");
    setValue(&vehicle_types, pJson["vehicle_types"], "QList", "SWGVehicleType");
    setValue(&services, pJson["services"], "QList", "SWGService");
    setValue(&shipments, pJson["shipments"], "QList", "SWGShipment");
    setValue(&relations, pJson["relations"], "QList", "SWGRelation");
    setValue(&algorithm, pJson["algorithm"], "SWGAlgorithm", "SWGAlgorithm");
    
}

QString
SWGRequest::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGRequest::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    QList<SWGVehicle*>* vehiclesList = vehicles;
    QJsonArray vehiclesJsonArray;
    toJsonArray((QList<void*>*)vehicles, &vehiclesJsonArray, "vehicles", "SWGVehicle");

    obj->insert("vehicles", vehiclesJsonArray);
    
    
    
    
    QList<SWGVehicleType*>* vehicle_typesList = vehicle_types;
    QJsonArray vehicle_typesJsonArray;
    toJsonArray((QList<void*>*)vehicle_types, &vehicle_typesJsonArray, "vehicle_types", "SWGVehicleType");

    obj->insert("vehicle_types", vehicle_typesJsonArray);
    
    
    
    
    QList<SWGService*>* servicesList = services;
    QJsonArray servicesJsonArray;
    toJsonArray((QList<void*>*)services, &servicesJsonArray, "services", "SWGService");

    obj->insert("services", servicesJsonArray);
    
    
    
    
    QList<SWGShipment*>* shipmentsList = shipments;
    QJsonArray shipmentsJsonArray;
    toJsonArray((QList<void*>*)shipments, &shipmentsJsonArray, "shipments", "SWGShipment");

    obj->insert("shipments", shipmentsJsonArray);
    
    
    
    
    QList<SWGRelation*>* relationsList = relations;
    QJsonArray relationsJsonArray;
    toJsonArray((QList<void*>*)relations, &relationsJsonArray, "relations", "SWGRelation");

    obj->insert("relations", relationsJsonArray);
    
    
    
    
    toJsonValue(QString("algorithm"), algorithm, obj, QString("SWGAlgorithm"));
    
    
    
    

    return obj;
}

QList<SWGVehicle*>*
SWGRequest::getVehicles() {
    return vehicles;
}
void
SWGRequest::setVehicles(QList<SWGVehicle*>* vehicles) {
    this->vehicles = vehicles;
}

QList<SWGVehicleType*>*
SWGRequest::getVehicleTypes() {
    return vehicle_types;
}
void
SWGRequest::setVehicleTypes(QList<SWGVehicleType*>* vehicle_types) {
    this->vehicle_types = vehicle_types;
}

QList<SWGService*>*
SWGRequest::getServices() {
    return services;
}
void
SWGRequest::setServices(QList<SWGService*>* services) {
    this->services = services;
}

QList<SWGShipment*>*
SWGRequest::getShipments() {
    return shipments;
}
void
SWGRequest::setShipments(QList<SWGShipment*>* shipments) {
    this->shipments = shipments;
}

QList<SWGRelation*>*
SWGRequest::getRelations() {
    return relations;
}
void
SWGRequest::setRelations(QList<SWGRelation*>* relations) {
    this->relations = relations;
}

SWGAlgorithm*
SWGRequest::getAlgorithm() {
    return algorithm;
}
void
SWGRequest::setAlgorithm(SWGAlgorithm* algorithm) {
    this->algorithm = algorithm;
}



} /* namespace Swagger */

