
#include "SWGActivity.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGActivity::SWGActivity(QString* json) {
    init();
    this->fromJson(*json);
}

SWGActivity::SWGActivity() {
    init();
}

SWGActivity::~SWGActivity() {
    this->cleanup();
}

void
SWGActivity::init() {
    type = new QString("");
    id = new QString("");
    location_id = new QString("");
    arr_time = 0L;
    end_time = 0L;
    
}

void
SWGActivity::cleanup() {
    if(type != NULL) {
        delete type;
    }
    if(id != NULL) {
        delete id;
    }
    if(location_id != NULL) {
        delete location_id;
    }
    
    
    
}

SWGActivity*
SWGActivity::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGActivity::fromJsonObject(QJsonObject &pJson) {
    setValue(&type, pJson["type"], "QString", "QString");
    setValue(&id, pJson["id"], "QString", "QString");
    setValue(&location_id, pJson["location_id"], "QString", "QString");
    setValue(&arr_time, pJson["arr_time"], "qint64", "");
    setValue(&end_time, pJson["end_time"], "qint64", "");
    
}

QString
SWGActivity::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGActivity::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("type"), type, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("id"), id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("location_id"), location_id, obj, QString("QString"));
    
    
    
    obj->insert("arr_time", QJsonValue(arr_time));
    obj->insert("end_time", QJsonValue(end_time));
    

    return obj;
}

QString*
SWGActivity::getType() {
    return type;
}
void
SWGActivity::setType(QString* type) {
    this->type = type;
}

QString*
SWGActivity::getId() {
    return id;
}
void
SWGActivity::setId(QString* id) {
    this->id = id;
}

QString*
SWGActivity::getLocationId() {
    return location_id;
}
void
SWGActivity::setLocationId(QString* location_id) {
    this->location_id = location_id;
}

qint64
SWGActivity::getArrTime() {
    return arr_time;
}
void
SWGActivity::setArrTime(qint64 arr_time) {
    this->arr_time = arr_time;
}

qint64
SWGActivity::getEndTime() {
    return end_time;
}
void
SWGActivity::setEndTime(qint64 end_time) {
    this->end_time = end_time;
}



} /* namespace Swagger */

