
#include "SWGVehicle.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGVehicle::SWGVehicle(QString* json) {
    init();
    this->fromJson(*json);
}

SWGVehicle::SWGVehicle() {
    init();
}

SWGVehicle::~SWGVehicle() {
    this->cleanup();
}

void
SWGVehicle::init() {
    vehicle_id = new QString("");
    type_id = new QString("");
    start_address = new SWGAddress();
    end_address = new SWGAddress();
    break = new SWGBreak();
    return_to_depot = false;
    earliest_start = 0L;
    latest_end = 0L;
    skills = new QList<QString*>();
    
}

void
SWGVehicle::cleanup() {
    if(vehicle_id != NULL) {
        delete vehicle_id;
    }
    if(type_id != NULL) {
        delete type_id;
    }
    if(start_address != NULL) {
        delete start_address;
    }
    if(end_address != NULL) {
        delete end_address;
    }
    if(break != NULL) {
        delete break;
    }
    
    
    
    if(skills != NULL) {
        QList<QString*>* arr = skills;
        foreach(QString* o, *arr) {
            delete o;
        }
        delete skills;
    }
    
}

SWGVehicle*
SWGVehicle::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGVehicle::fromJsonObject(QJsonObject &pJson) {
    setValue(&vehicle_id, pJson["vehicle_id"], "QString", "QString");
    setValue(&type_id, pJson["type_id"], "QString", "QString");
    setValue(&start_address, pJson["start_address"], "SWGAddress", "SWGAddress");
    setValue(&end_address, pJson["end_address"], "SWGAddress", "SWGAddress");
    setValue(&break, pJson["break"], "SWGBreak", "SWGBreak");
    setValue(&return_to_depot, pJson["return_to_depot"], "bool", "");
    setValue(&earliest_start, pJson["earliest_start"], "qint64", "");
    setValue(&latest_end, pJson["latest_end"], "qint64", "");
    setValue(&skills, pJson["skills"], "QList", "QString");
    
}

QString
SWGVehicle::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGVehicle::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("vehicle_id"), vehicle_id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("type_id"), type_id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("start_address"), start_address, obj, QString("SWGAddress"));
    
    
    
    
    
    toJsonValue(QString("end_address"), end_address, obj, QString("SWGAddress"));
    
    
    
    
    
    toJsonValue(QString("break"), break, obj, QString("SWGBreak"));
    
    
    
    obj->insert("return_to_depot", QJsonValue(return_to_depot));
    obj->insert("earliest_start", QJsonValue(earliest_start));
    obj->insert("latest_end", QJsonValue(latest_end));
    
    
    QList<QString*>* skillsList = skills;
    QJsonArray skillsJsonArray;
    toJsonArray((QList<void*>*)skills, &skillsJsonArray, "skills", "QString");

    obj->insert("skills", skillsJsonArray);
    
    
    

    return obj;
}

QString*
SWGVehicle::getVehicleId() {
    return vehicle_id;
}
void
SWGVehicle::setVehicleId(QString* vehicle_id) {
    this->vehicle_id = vehicle_id;
}

QString*
SWGVehicle::getTypeId() {
    return type_id;
}
void
SWGVehicle::setTypeId(QString* type_id) {
    this->type_id = type_id;
}

SWGAddress*
SWGVehicle::getStartAddress() {
    return start_address;
}
void
SWGVehicle::setStartAddress(SWGAddress* start_address) {
    this->start_address = start_address;
}

SWGAddress*
SWGVehicle::getEndAddress() {
    return end_address;
}
void
SWGVehicle::setEndAddress(SWGAddress* end_address) {
    this->end_address = end_address;
}

SWGBreak*
SWGVehicle::getBreak() {
    return break;
}
void
SWGVehicle::setBreak(SWGBreak* break) {
    this->break = break;
}

bool
SWGVehicle::getReturnToDepot() {
    return return_to_depot;
}
void
SWGVehicle::setReturnToDepot(bool return_to_depot) {
    this->return_to_depot = return_to_depot;
}

qint64
SWGVehicle::getEarliestStart() {
    return earliest_start;
}
void
SWGVehicle::setEarliestStart(qint64 earliest_start) {
    this->earliest_start = earliest_start;
}

qint64
SWGVehicle::getLatestEnd() {
    return latest_end;
}
void
SWGVehicle::setLatestEnd(qint64 latest_end) {
    this->latest_end = latest_end;
}

QList<QString*>*
SWGVehicle::getSkills() {
    return skills;
}
void
SWGVehicle::setSkills(QList<QString*>* skills) {
    this->skills = skills;
}



} /* namespace Swagger */

