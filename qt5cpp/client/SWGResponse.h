/*
 * SWGResponse.h
 * 
 * 
 */

#ifndef SWGResponse_H_
#define SWGResponse_H_

#include <QJsonObject>


#include "SWGSolution.h"
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGResponse: public SWGObject {
public:
    SWGResponse();
    SWGResponse(QString* json);
    virtual ~SWGResponse();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGResponse* fromJson(QString &jsonString);

    QString* getJobId();
    void setJobId(QString* job_id);
    QString* getStatus();
    void setStatus(QString* status);
    qint64 getWaitingInQueue();
    void setWaitingInQueue(qint64 waiting_in_queue);
    qint64 getProcessingTime();
    void setProcessingTime(qint64 processing_time);
    SWGSolution* getSolution();
    void setSolution(SWGSolution* solution);
    

private:
    QString* job_id;
    QString* status;
    qint64 waiting_in_queue;
    qint64 processing_time;
    SWGSolution* solution;
    
};

} /* namespace Swagger */

#endif /* SWGResponse_H_ */
