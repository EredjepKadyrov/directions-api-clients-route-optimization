
#include "SWGShipment.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGShipment::SWGShipment(QString* json) {
    init();
    this->fromJson(*json);
}

SWGShipment::SWGShipment() {
    init();
}

SWGShipment::~SWGShipment() {
    this->cleanup();
}

void
SWGShipment::init() {
    id = new QString("");
    name = new QString("");
    priority = 0;
    pickup = new SWGStop();
    delivery = new SWGStop();
    size = new QList<qint32>();
    required_skills = new QList<QString*>();
    allowed_vehicles = new QList<QString*>();
    
}

void
SWGShipment::cleanup() {
    if(id != NULL) {
        delete id;
    }
    if(name != NULL) {
        delete name;
    }
    
    if(pickup != NULL) {
        delete pickup;
    }
    if(delivery != NULL) {
        delete delivery;
    }
    
    if(required_skills != NULL) {
        QList<QString*>* arr = required_skills;
        foreach(QString* o, *arr) {
            delete o;
        }
        delete required_skills;
    }
    if(allowed_vehicles != NULL) {
        QList<QString*>* arr = allowed_vehicles;
        foreach(QString* o, *arr) {
            delete o;
        }
        delete allowed_vehicles;
    }
    
}

SWGShipment*
SWGShipment::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGShipment::fromJsonObject(QJsonObject &pJson) {
    setValue(&id, pJson["id"], "QString", "QString");
    setValue(&name, pJson["name"], "QString", "QString");
    setValue(&priority, pJson["priority"], "qint32", "");
    setValue(&pickup, pJson["pickup"], "SWGStop", "SWGStop");
    setValue(&delivery, pJson["delivery"], "SWGStop", "SWGStop");
    setValue(&size, pJson["size"], "QList", "");
    setValue(&required_skills, pJson["required_skills"], "QList", "QString");
    setValue(&allowed_vehicles, pJson["allowed_vehicles"], "QList", "QString");
    
}

QString
SWGShipment::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGShipment::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("id"), id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("name"), name, obj, QString("QString"));
    
    
    
    obj->insert("priority", QJsonValue(priority));
    
    
    toJsonValue(QString("pickup"), pickup, obj, QString("SWGStop"));
    
    
    
    
    
    toJsonValue(QString("delivery"), delivery, obj, QString("SWGStop"));
    
    
    
    obj->insert("size", QJsonValue(size));
    
    
    QList<QString*>* required_skillsList = required_skills;
    QJsonArray required_skillsJsonArray;
    toJsonArray((QList<void*>*)required_skills, &required_skillsJsonArray, "required_skills", "QString");

    obj->insert("required_skills", required_skillsJsonArray);
    
    
    
    
    QList<QString*>* allowed_vehiclesList = allowed_vehicles;
    QJsonArray allowed_vehiclesJsonArray;
    toJsonArray((QList<void*>*)allowed_vehicles, &allowed_vehiclesJsonArray, "allowed_vehicles", "QString");

    obj->insert("allowed_vehicles", allowed_vehiclesJsonArray);
    
    
    

    return obj;
}

QString*
SWGShipment::getId() {
    return id;
}
void
SWGShipment::setId(QString* id) {
    this->id = id;
}

QString*
SWGShipment::getName() {
    return name;
}
void
SWGShipment::setName(QString* name) {
    this->name = name;
}

qint32
SWGShipment::getPriority() {
    return priority;
}
void
SWGShipment::setPriority(qint32 priority) {
    this->priority = priority;
}

SWGStop*
SWGShipment::getPickup() {
    return pickup;
}
void
SWGShipment::setPickup(SWGStop* pickup) {
    this->pickup = pickup;
}

SWGStop*
SWGShipment::getDelivery() {
    return delivery;
}
void
SWGShipment::setDelivery(SWGStop* delivery) {
    this->delivery = delivery;
}

QList<qint32>*
SWGShipment::getSize() {
    return size;
}
void
SWGShipment::setSize(QList<qint32>* size) {
    this->size = size;
}

QList<QString*>*
SWGShipment::getRequiredSkills() {
    return required_skills;
}
void
SWGShipment::setRequiredSkills(QList<QString*>* required_skills) {
    this->required_skills = required_skills;
}

QList<QString*>*
SWGShipment::getAllowedVehicles() {
    return allowed_vehicles;
}
void
SWGShipment::setAllowedVehicles(QList<QString*>* allowed_vehicles) {
    this->allowed_vehicles = allowed_vehicles;
}



} /* namespace Swagger */

