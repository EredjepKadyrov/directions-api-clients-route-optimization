/*
 * SWGJobId.h
 * 
 * 
 */

#ifndef SWGJobId_H_
#define SWGJobId_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGJobId: public SWGObject {
public:
    SWGJobId();
    SWGJobId(QString* json);
    virtual ~SWGJobId();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGJobId* fromJson(QString &jsonString);

    QString* getJobId();
    void setJobId(QString* job_id);
    

private:
    QString* job_id;
    
};

} /* namespace Swagger */

#endif /* SWGJobId_H_ */
