
#include "SWGJobId.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGJobId::SWGJobId(QString* json) {
    init();
    this->fromJson(*json);
}

SWGJobId::SWGJobId() {
    init();
}

SWGJobId::~SWGJobId() {
    this->cleanup();
}

void
SWGJobId::init() {
    job_id = new QString("");
    
}

void
SWGJobId::cleanup() {
    if(job_id != NULL) {
        delete job_id;
    }
    
}

SWGJobId*
SWGJobId::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGJobId::fromJsonObject(QJsonObject &pJson) {
    setValue(&job_id, pJson["job_id"], "QString", "QString");
    
}

QString
SWGJobId::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGJobId::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("job_id"), job_id, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGJobId::getJobId() {
    return job_id;
}
void
SWGJobId::setJobId(QString* job_id) {
    this->job_id = job_id;
}



} /* namespace Swagger */

