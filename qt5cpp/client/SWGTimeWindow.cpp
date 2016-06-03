
#include "SWGTimeWindow.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGTimeWindow::SWGTimeWindow(QString* json) {
    init();
    this->fromJson(*json);
}

SWGTimeWindow::SWGTimeWindow() {
    init();
}

SWGTimeWindow::~SWGTimeWindow() {
    this->cleanup();
}

void
SWGTimeWindow::init() {
    earliest = 0L;
    latest = 0L;
    
}

void
SWGTimeWindow::cleanup() {
    
    
    
}

SWGTimeWindow*
SWGTimeWindow::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGTimeWindow::fromJsonObject(QJsonObject &pJson) {
    setValue(&earliest, pJson["earliest"], "qint64", "");
    setValue(&latest, pJson["latest"], "qint64", "");
    
}

QString
SWGTimeWindow::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGTimeWindow::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    obj->insert("earliest", QJsonValue(earliest));
    obj->insert("latest", QJsonValue(latest));
    

    return obj;
}

qint64
SWGTimeWindow::getEarliest() {
    return earliest;
}
void
SWGTimeWindow::setEarliest(qint64 earliest) {
    this->earliest = earliest;
}

qint64
SWGTimeWindow::getLatest() {
    return latest;
}
void
SWGTimeWindow::setLatest(qint64 latest) {
    this->latest = latest;
}



} /* namespace Swagger */

