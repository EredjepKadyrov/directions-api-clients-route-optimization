
#include "SWGBreak.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGBreak::SWGBreak(QString* json) {
    init();
    this->fromJson(*json);
}

SWGBreak::SWGBreak() {
    init();
}

SWGBreak::~SWGBreak() {
    this->cleanup();
}

void
SWGBreak::init() {
    earliest = 0L;
    latest = 0L;
    duration = 0L;
    
}

void
SWGBreak::cleanup() {
    
    
    
    
}

SWGBreak*
SWGBreak::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGBreak::fromJsonObject(QJsonObject &pJson) {
    setValue(&earliest, pJson["earliest"], "qint64", "");
    setValue(&latest, pJson["latest"], "qint64", "");
    setValue(&duration, pJson["duration"], "qint64", "");
    
}

QString
SWGBreak::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGBreak::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    obj->insert("earliest", QJsonValue(earliest));
    obj->insert("latest", QJsonValue(latest));
    obj->insert("duration", QJsonValue(duration));
    

    return obj;
}

qint64
SWGBreak::getEarliest() {
    return earliest;
}
void
SWGBreak::setEarliest(qint64 earliest) {
    this->earliest = earliest;
}

qint64
SWGBreak::getLatest() {
    return latest;
}
void
SWGBreak::setLatest(qint64 latest) {
    this->latest = latest;
}

qint64
SWGBreak::getDuration() {
    return duration;
}
void
SWGBreak::setDuration(qint64 duration) {
    this->duration = duration;
}



} /* namespace Swagger */

