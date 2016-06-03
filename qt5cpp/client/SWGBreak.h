/*
 * SWGBreak.h
 * 
 * 
 */

#ifndef SWGBreak_H_
#define SWGBreak_H_

#include <QJsonObject>



#include "SWGObject.h"


namespace Swagger {

class SWGBreak: public SWGObject {
public:
    SWGBreak();
    SWGBreak(QString* json);
    virtual ~SWGBreak();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGBreak* fromJson(QString &jsonString);

    qint64 getEarliest();
    void setEarliest(qint64 earliest);
    qint64 getLatest();
    void setLatest(qint64 latest);
    qint64 getDuration();
    void setDuration(qint64 duration);
    

private:
    qint64 earliest;
    qint64 latest;
    qint64 duration;
    
};

} /* namespace Swagger */

#endif /* SWGBreak_H_ */
