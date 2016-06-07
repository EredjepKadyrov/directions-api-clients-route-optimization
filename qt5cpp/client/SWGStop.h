/*
 * SWGStop.h
 * 
 * 
 */

#ifndef SWGStop_H_
#define SWGStop_H_

#include <QJsonObject>


#include "SWGAddress.h"
#include "SWGTimeWindow.h"
#include <QList>

#include "SWGObject.h"


namespace Swagger {

class SWGStop: public SWGObject {
public:
    SWGStop();
    SWGStop(QString* json);
    virtual ~SWGStop();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGStop* fromJson(QString &jsonString);

    SWGAddress* getAddress();
    void setAddress(SWGAddress* address);
    qint64 getDuration();
    void setDuration(qint64 duration);
    QList<SWGTimeWindow*>* getTimeWindows();
    void setTimeWindows(QList<SWGTimeWindow*>* time_windows);
    

private:
    SWGAddress* address;
    qint64 duration;
    QList<SWGTimeWindow*>* time_windows;
    
};

} /* namespace Swagger */

#endif /* SWGStop_H_ */
