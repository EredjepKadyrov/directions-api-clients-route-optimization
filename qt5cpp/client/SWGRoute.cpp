
#include "SWGRoute.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGRoute::SWGRoute(QString* json) {
    init();
    this->fromJson(*json);
}

SWGRoute::SWGRoute() {
    init();
}

SWGRoute::~SWGRoute() {
    this->cleanup();
}

void
SWGRoute::init() {
    vehicle_id = new QString("");
    activities = new QList<SWGActivity*>();
    
}

void
SWGRoute::cleanup() {
    if(vehicle_id != NULL) {
        delete vehicle_id;
    }
    if(activities != NULL) {
        QList<SWGActivity*>* arr = activities;
        foreach(SWGActivity* o, *arr) {
            delete o;
        }
        delete activities;
    }
    
}

SWGRoute*
SWGRoute::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGRoute::fromJsonObject(QJsonObject &pJson) {
    setValue(&vehicle_id, pJson["vehicle_id"], "QString", "QString");
    setValue(&activities, pJson["activities"], "QList", "SWGActivity");
    
}

QString
SWGRoute::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGRoute::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("vehicle_id"), vehicle_id, obj, QString("QString"));
    
    
    
    
    
    QList<SWGActivity*>* activitiesList = activities;
    QJsonArray activitiesJsonArray;
    toJsonArray((QList<void*>*)activities, &activitiesJsonArray, "activities", "SWGActivity");

    obj->insert("activities", activitiesJsonArray);
    
    
    

    return obj;
}

QString*
SWGRoute::getVehicleId() {
    return vehicle_id;
}
void
SWGRoute::setVehicleId(QString* vehicle_id) {
    this->vehicle_id = vehicle_id;
}

QList<SWGActivity*>*
SWGRoute::getActivities() {
    return activities;
}
void
SWGRoute::setActivities(QList<SWGActivity*>* activities) {
    this->activities = activities;
}



} /* namespace Swagger */

