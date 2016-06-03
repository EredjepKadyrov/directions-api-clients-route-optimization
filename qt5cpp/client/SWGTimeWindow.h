/*
 * SWGTimeWindow.h
 * 
 * 
 */

#ifndef SWGTimeWindow_H_
#define SWGTimeWindow_H_

#include <QJsonObject>



#include "SWGObject.h"


namespace Swagger {

class SWGTimeWindow: public SWGObject {
public:
    SWGTimeWindow();
    SWGTimeWindow(QString* json);
    virtual ~SWGTimeWindow();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGTimeWindow* fromJson(QString &jsonString);

    qint64 getEarliest();
    void setEarliest(qint64 earliest);
    qint64 getLatest();
    void setLatest(qint64 latest);
    

private:
    qint64 earliest;
    qint64 latest;
    
};

} /* namespace Swagger */

#endif /* SWGTimeWindow_H_ */
