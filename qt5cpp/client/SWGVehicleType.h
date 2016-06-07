/*
 * SWGVehicleType.h
 * 
 * 
 */

#ifndef SWGVehicleType_H_
#define SWGVehicleType_H_

#include <QJsonObject>


#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGVehicleType: public SWGObject {
public:
    SWGVehicleType();
    SWGVehicleType(QString* json);
    virtual ~SWGVehicleType();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGVehicleType* fromJson(QString &jsonString);

    QString* getTypeId();
    void setTypeId(QString* type_id);
    QString* getProfile();
    void setProfile(QString* profile);
    QList<qint32>* getCapacity();
    void setCapacity(QList<qint32>* capacity);
    double getSpeedFactor();
    void setSpeedFactor(double speed_factor);
    double getServiceTimeFactor();
    void setServiceTimeFactor(double service_time_factor);
    

private:
    QString* type_id;
    QString* profile;
    QList<qint32>* capacity;
    double speed_factor;
    double service_time_factor;
    
};

} /* namespace Swagger */

#endif /* SWGVehicleType_H_ */
