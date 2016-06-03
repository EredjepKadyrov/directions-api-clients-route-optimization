
#include "SWGRelation.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGRelation::SWGRelation(QString* json) {
    init();
    this->fromJson(*json);
}

SWGRelation::SWGRelation() {
    init();
}

SWGRelation::~SWGRelation() {
    this->cleanup();
}

void
SWGRelation::init() {
    type = new QString("");
    ids = new QList<QString*>();
    vehicle_id = new QString("");
    
}

void
SWGRelation::cleanup() {
    if(type != NULL) {
        delete type;
    }
    if(ids != NULL) {
        QList<QString*>* arr = ids;
        foreach(QString* o, *arr) {
            delete o;
        }
        delete ids;
    }
    if(vehicle_id != NULL) {
        delete vehicle_id;
    }
    
}

SWGRelation*
SWGRelation::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGRelation::fromJsonObject(QJsonObject &pJson) {
    setValue(&type, pJson["type"], "QString", "QString");
    setValue(&ids, pJson["ids"], "QList", "QString");
    setValue(&vehicle_id, pJson["vehicle_id"], "QString", "QString");
    
}

QString
SWGRelation::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGRelation::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("type"), type, obj, QString("QString"));
    
    
    
    
    
    QList<QString*>* idsList = ids;
    QJsonArray idsJsonArray;
    toJsonArray((QList<void*>*)ids, &idsJsonArray, "ids", "QString");

    obj->insert("ids", idsJsonArray);
    
    
    
    
    toJsonValue(QString("vehicle_id"), vehicle_id, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGRelation::getType() {
    return type;
}
void
SWGRelation::setType(QString* type) {
    this->type = type;
}

QList<QString*>*
SWGRelation::getIds() {
    return ids;
}
void
SWGRelation::setIds(QList<QString*>* ids) {
    this->ids = ids;
}

QString*
SWGRelation::getVehicleId() {
    return vehicle_id;
}
void
SWGRelation::setVehicleId(QString* vehicle_id) {
    this->vehicle_id = vehicle_id;
}



} /* namespace Swagger */

