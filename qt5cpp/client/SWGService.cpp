
#include "SWGService.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGService::SWGService(QString* json) {
    init();
    this->fromJson(*json);
}

SWGService::SWGService() {
    init();
}

SWGService::~SWGService() {
    this->cleanup();
}

void
SWGService::init() {
    id = new QString("");
    type = new QString("");
    priority = 0;
    name = new QString("");
    address = new SWGAddress();
    duration = 0L;
    time_windows = new QList<SWGTimeWindow*>();
    size = new QList<qint32>();
    required_skills = new QList<QString*>();
    allowed_vehicles = new QList<QString*>();
    
}

void
SWGService::cleanup() {
    if(id != NULL) {
        delete id;
    }
    if(type != NULL) {
        delete type;
    }
    
    if(name != NULL) {
        delete name;
    }
    if(address != NULL) {
        delete address;
    }
    
    if(time_windows != NULL) {
        QList<SWGTimeWindow*>* arr = time_windows;
        foreach(SWGTimeWindow* o, *arr) {
            delete o;
        }
        delete time_windows;
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

SWGService*
SWGService::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGService::fromJsonObject(QJsonObject &pJson) {
    setValue(&id, pJson["id"], "QString", "QString");
    setValue(&type, pJson["type"], "QString", "QString");
    setValue(&priority, pJson["priority"], "qint32", "");
    setValue(&name, pJson["name"], "QString", "QString");
    setValue(&address, pJson["address"], "SWGAddress", "SWGAddress");
    setValue(&duration, pJson["duration"], "qint64", "");
    setValue(&time_windows, pJson["time_windows"], "QList", "SWGTimeWindow");
    setValue(&size, pJson["size"], "QList", "");
    setValue(&required_skills, pJson["required_skills"], "QList", "QString");
    setValue(&allowed_vehicles, pJson["allowed_vehicles"], "QList", "QString");
    
}

QString
SWGService::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGService::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("id"), id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("type"), type, obj, QString("QString"));
    
    
    
    obj->insert("priority", QJsonValue(priority));
    
    
    toJsonValue(QString("name"), name, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("address"), address, obj, QString("SWGAddress"));
    
    
    
    obj->insert("duration", QJsonValue(duration));
    
    
    QList<SWGTimeWindow*>* time_windowsList = time_windows;
    QJsonArray time_windowsJsonArray;
    toJsonArray((QList<void*>*)time_windows, &time_windowsJsonArray, "time_windows", "SWGTimeWindow");

    obj->insert("time_windows", time_windowsJsonArray);
    
    
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
SWGService::getId() {
    return id;
}
void
SWGService::setId(QString* id) {
    this->id = id;
}

QString*
SWGService::getType() {
    return type;
}
void
SWGService::setType(QString* type) {
    this->type = type;
}

qint32
SWGService::getPriority() {
    return priority;
}
void
SWGService::setPriority(qint32 priority) {
    this->priority = priority;
}

QString*
SWGService::getName() {
    return name;
}
void
SWGService::setName(QString* name) {
    this->name = name;
}

SWGAddress*
SWGService::getAddress() {
    return address;
}
void
SWGService::setAddress(SWGAddress* address) {
    this->address = address;
}

qint64
SWGService::getDuration() {
    return duration;
}
void
SWGService::setDuration(qint64 duration) {
    this->duration = duration;
}

QList<SWGTimeWindow*>*
SWGService::getTimeWindows() {
    return time_windows;
}
void
SWGService::setTimeWindows(QList<SWGTimeWindow*>* time_windows) {
    this->time_windows = time_windows;
}

QList<qint32>*
SWGService::getSize() {
    return size;
}
void
SWGService::setSize(QList<qint32>* size) {
    this->size = size;
}

QList<QString*>*
SWGService::getRequiredSkills() {
    return required_skills;
}
void
SWGService::setRequiredSkills(QList<QString*>* required_skills) {
    this->required_skills = required_skills;
}

QList<QString*>*
SWGService::getAllowedVehicles() {
    return allowed_vehicles;
}
void
SWGService::setAllowedVehicles(QList<QString*>* allowed_vehicles) {
    this->allowed_vehicles = allowed_vehicles;
}



} /* namespace Swagger */

