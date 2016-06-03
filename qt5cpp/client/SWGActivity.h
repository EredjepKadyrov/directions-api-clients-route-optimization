/*
 * SWGActivity.h
 * 
 * 
 */

#ifndef SWGActivity_H_
#define SWGActivity_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGActivity: public SWGObject {
public:
    SWGActivity();
    SWGActivity(QString* json);
    virtual ~SWGActivity();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGActivity* fromJson(QString &jsonString);

    QString* getType();
    void setType(QString* type);
    QString* getId();
    void setId(QString* id);
    QString* getLocationId();
    void setLocationId(QString* location_id);
    qint64 getArrTime();
    void setArrTime(qint64 arr_time);
    qint64 getEndTime();
    void setEndTime(qint64 end_time);
    

private:
    QString* type;
    QString* id;
    QString* location_id;
    qint64 arr_time;
    qint64 end_time;
    
};

} /* namespace Swagger */

#endif /* SWGActivity_H_ */
