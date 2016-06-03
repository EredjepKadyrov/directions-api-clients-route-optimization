/*
 * SWGRoute.h
 * 
 * 
 */

#ifndef SWGRoute_H_
#define SWGRoute_H_

#include <QJsonObject>


#include <QList>
#include <QString>
#include "SWGActivity.h"

#include "SWGObject.h"


namespace Swagger {

class SWGRoute: public SWGObject {
public:
    SWGRoute();
    SWGRoute(QString* json);
    virtual ~SWGRoute();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGRoute* fromJson(QString &jsonString);

    QString* getVehicleId();
    void setVehicleId(QString* vehicle_id);
    QList<SWGActivity*>* getActivities();
    void setActivities(QList<SWGActivity*>* activities);
    

private:
    QString* vehicle_id;
    QList<SWGActivity*>* activities;
    
};

} /* namespace Swagger */

#endif /* SWGRoute_H_ */
