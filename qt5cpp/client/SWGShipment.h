/*
 * SWGShipment.h
 * 
 * 
 */

#ifndef SWGShipment_H_
#define SWGShipment_H_

#include <QJsonObject>


#include "SWGStop.h"
#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGShipment: public SWGObject {
public:
    SWGShipment();
    SWGShipment(QString* json);
    virtual ~SWGShipment();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGShipment* fromJson(QString &jsonString);

    QString* getId();
    void setId(QString* id);
    QString* getName();
    void setName(QString* name);
    qint32 getPriority();
    void setPriority(qint32 priority);
    SWGStop* getPickup();
    void setPickup(SWGStop* pickup);
    SWGStop* getDelivery();
    void setDelivery(SWGStop* delivery);
    QList<qint32>* getSize();
    void setSize(QList<qint32>* size);
    QList<QString*>* getRequiredSkills();
    void setRequiredSkills(QList<QString*>* required_skills);
    QList<QString*>* getAllowedVehicles();
    void setAllowedVehicles(QList<QString*>* allowed_vehicles);
    

private:
    QString* id;
    QString* name;
    qint32 priority;
    SWGStop* pickup;
    SWGStop* delivery;
    QList<qint32>* size;
    QList<QString*>* required_skills;
    QList<QString*>* allowed_vehicles;
    
};

} /* namespace Swagger */

#endif /* SWGShipment_H_ */
