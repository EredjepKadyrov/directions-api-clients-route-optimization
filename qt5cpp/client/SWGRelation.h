/*
 * SWGRelation.h
 * 
 * 
 */

#ifndef SWGRelation_H_
#define SWGRelation_H_

#include <QJsonObject>


#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGRelation: public SWGObject {
public:
    SWGRelation();
    SWGRelation(QString* json);
    virtual ~SWGRelation();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGRelation* fromJson(QString &jsonString);

    QString* getType();
    void setType(QString* type);
    QList<QString*>* getIds();
    void setIds(QList<QString*>* ids);
    QString* getVehicleId();
    void setVehicleId(QString* vehicle_id);
    

private:
    QString* type;
    QList<QString*>* ids;
    QString* vehicle_id;
    
};

} /* namespace Swagger */

#endif /* SWGRelation_H_ */
