
#include "SWGVehicleType.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGVehicleType::SWGVehicleType(QString* json) {
    init();
    this->fromJson(*json);
}

SWGVehicleType::SWGVehicleType() {
    init();
}

SWGVehicleType::~SWGVehicleType() {
    this->cleanup();
}

void
SWGVehicleType::init() {
    type_id = new QString("");
    profile = new QString("");
    capacity = new QList<qint32>();
    speed_factor = 0.0;
    service_time_factor = 0.0;
    
}

void
SWGVehicleType::cleanup() {
    if(type_id != NULL) {
        delete type_id;
    }
    if(profile != NULL) {
        delete profile;
    }
    
    
    
    
}

SWGVehicleType*
SWGVehicleType::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGVehicleType::fromJsonObject(QJsonObject &pJson) {
    setValue(&type_id, pJson["type_id"], "QString", "QString");
    setValue(&profile, pJson["profile"], "QString", "QString");
    setValue(&capacity, pJson["capacity"], "QList", "");
    setValue(&speed_factor, pJson["speed_factor"], "double", "");
    setValue(&service_time_factor, pJson["service_time_factor"], "double", "");
    
}

QString
SWGVehicleType::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGVehicleType::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("type_id"), type_id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("profile"), profile, obj, QString("QString"));
    
    
    
    obj->insert("capacity", QJsonValue(capacity));
    obj->insert("speed_factor", QJsonValue(speed_factor));
    obj->insert("service_time_factor", QJsonValue(service_time_factor));
    

    return obj;
}

QString*
SWGVehicleType::getTypeId() {
    return type_id;
}
void
SWGVehicleType::setTypeId(QString* type_id) {
    this->type_id = type_id;
}

QString*
SWGVehicleType::getProfile() {
    return profile;
}
void
SWGVehicleType::setProfile(QString* profile) {
    this->profile = profile;
}

QList<qint32>*
SWGVehicleType::getCapacity() {
    return capacity;
}
void
SWGVehicleType::setCapacity(QList<qint32>* capacity) {
    this->capacity = capacity;
}

double
SWGVehicleType::getSpeedFactor() {
    return speed_factor;
}
void
SWGVehicleType::setSpeedFactor(double speed_factor) {
    this->speed_factor = speed_factor;
}

double
SWGVehicleType::getServiceTimeFactor() {
    return service_time_factor;
}
void
SWGVehicleType::setServiceTimeFactor(double service_time_factor) {
    this->service_time_factor = service_time_factor;
}



} /* namespace Swagger */

