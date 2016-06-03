
#include "SWGStop.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGStop::SWGStop(QString* json) {
    init();
    this->fromJson(*json);
}

SWGStop::SWGStop() {
    init();
}

SWGStop::~SWGStop() {
    this->cleanup();
}

void
SWGStop::init() {
    address = new SWGAddress();
    duration = 0L;
    time_windows = new QList<SWGTimeWindow*>();
    
}

void
SWGStop::cleanup() {
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
    
}

SWGStop*
SWGStop::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGStop::fromJsonObject(QJsonObject &pJson) {
    setValue(&address, pJson["address"], "SWGAddress", "SWGAddress");
    setValue(&duration, pJson["duration"], "qint64", "");
    setValue(&time_windows, pJson["time_windows"], "QList", "SWGTimeWindow");
    
}

QString
SWGStop::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGStop::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("address"), address, obj, QString("SWGAddress"));
    
    
    
    obj->insert("duration", QJsonValue(duration));
    
    
    QList<SWGTimeWindow*>* time_windowsList = time_windows;
    QJsonArray time_windowsJsonArray;
    toJsonArray((QList<void*>*)time_windows, &time_windowsJsonArray, "time_windows", "SWGTimeWindow");

    obj->insert("time_windows", time_windowsJsonArray);
    
    
    

    return obj;
}

SWGAddress*
SWGStop::getAddress() {
    return address;
}
void
SWGStop::setAddress(SWGAddress* address) {
    this->address = address;
}

qint64
SWGStop::getDuration() {
    return duration;
}
void
SWGStop::setDuration(qint64 duration) {
    this->duration = duration;
}

QList<SWGTimeWindow*>*
SWGStop::getTimeWindows() {
    return time_windows;
}
void
SWGStop::setTimeWindows(QList<SWGTimeWindow*>* time_windows) {
    this->time_windows = time_windows;
}



} /* namespace Swagger */

