
#include "SWGResponse.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGResponse::SWGResponse(QString* json) {
    init();
    this->fromJson(*json);
}

SWGResponse::SWGResponse() {
    init();
}

SWGResponse::~SWGResponse() {
    this->cleanup();
}

void
SWGResponse::init() {
    job_id = new QString("");
    status = new QString("");
    waiting_in_queue = 0L;
    processing_time = 0L;
    solution = new SWGSolution();
    
}

void
SWGResponse::cleanup() {
    if(job_id != NULL) {
        delete job_id;
    }
    if(status != NULL) {
        delete status;
    }
    
    
    if(solution != NULL) {
        delete solution;
    }
    
}

SWGResponse*
SWGResponse::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGResponse::fromJsonObject(QJsonObject &pJson) {
    setValue(&job_id, pJson["job_id"], "QString", "QString");
    setValue(&status, pJson["status"], "QString", "QString");
    setValue(&waiting_in_queue, pJson["waiting_in_queue"], "qint64", "");
    setValue(&processing_time, pJson["processing_time"], "qint64", "");
    setValue(&solution, pJson["solution"], "SWGSolution", "SWGSolution");
    
}

QString
SWGResponse::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGResponse::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("job_id"), job_id, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("status"), status, obj, QString("QString"));
    
    
    
    obj->insert("waiting_in_queue", QJsonValue(waiting_in_queue));
    obj->insert("processing_time", QJsonValue(processing_time));
    
    
    toJsonValue(QString("solution"), solution, obj, QString("SWGSolution"));
    
    
    
    

    return obj;
}

QString*
SWGResponse::getJobId() {
    return job_id;
}
void
SWGResponse::setJobId(QString* job_id) {
    this->job_id = job_id;
}

QString*
SWGResponse::getStatus() {
    return status;
}
void
SWGResponse::setStatus(QString* status) {
    this->status = status;
}

qint64
SWGResponse::getWaitingInQueue() {
    return waiting_in_queue;
}
void
SWGResponse::setWaitingInQueue(qint64 waiting_in_queue) {
    this->waiting_in_queue = waiting_in_queue;
}

qint64
SWGResponse::getProcessingTime() {
    return processing_time;
}
void
SWGResponse::setProcessingTime(qint64 processing_time) {
    this->processing_time = processing_time;
}

SWGSolution*
SWGResponse::getSolution() {
    return solution;
}
void
SWGResponse::setSolution(SWGSolution* solution) {
    this->solution = solution;
}



} /* namespace Swagger */

