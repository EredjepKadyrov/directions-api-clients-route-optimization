/*
 * SWGVehicle.h
 * 
 * 
 */

#ifndef SWGVehicle_H_
#define SWGVehicle_H_

#include <QJsonObject>


#include <QList>
#include <QString>
#include "SWGAddress.h"
#include "SWGBreak.h"

#include "SWGObject.h"


namespace Swagger {

class SWGVehicle: public SWGObject {
public:
    SWGVehicle();
    SWGVehicle(QString* json);
    virtual ~SWGVehicle();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGVehicle* fromJson(QString &jsonString);

    QString* getVehicleId();
    void setVehicleId(QString* vehicle_id);
    QString* getTypeId();
    void setTypeId(QString* type_id);
    SWGAddress* getStartAddress();
    void setStartAddress(SWGAddress* start_address);
    SWGAddress* getEndAddress();
    void setEndAddress(SWGAddress* end_address);
    SWGBreak* getBreak();
    void setBreak(SWGBreak* break);
    bool getReturnToDepot();
    void setReturnToDepot(bool return_to_depot);
    qint64 getEarliestStart();
    void setEarliestStart(qint64 earliest_start);
    qint64 getLatestEnd();
    void setLatestEnd(qint64 latest_end);
    QList<QString*>* getSkills();
    void setSkills(QList<QString*>* skills);
    

private:
    QString* vehicle_id;
    QString* type_id;
    SWGAddress* start_address;
    SWGAddress* end_address;
    SWGBreak* break;
    bool return_to_depot;
    qint64 earliest_start;
    qint64 latest_end;
    QList<QString*>* skills;
    
};

} /* namespace Swagger */

#endif /* SWGVehicle_H_ */
