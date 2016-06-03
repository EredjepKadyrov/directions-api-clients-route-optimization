/*
 * SWGRequest.h
 * 
 * 
 */

#ifndef SWGRequest_H_
#define SWGRequest_H_

#include <QJsonObject>


#include <QList>
#include "SWGVehicleType.h"
#include "SWGService.h"
#include "SWGRelation.h"
#include "SWGAlgorithm.h"
#include "SWGShipment.h"
#include "SWGVehicle.h"

#include "SWGObject.h"


namespace Swagger {

class SWGRequest: public SWGObject {
public:
    SWGRequest();
    SWGRequest(QString* json);
    virtual ~SWGRequest();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGRequest* fromJson(QString &jsonString);

    QList<SWGVehicle*>* getVehicles();
    void setVehicles(QList<SWGVehicle*>* vehicles);
    QList<SWGVehicleType*>* getVehicleTypes();
    void setVehicleTypes(QList<SWGVehicleType*>* vehicle_types);
    QList<SWGService*>* getServices();
    void setServices(QList<SWGService*>* services);
    QList<SWGShipment*>* getShipments();
    void setShipments(QList<SWGShipment*>* shipments);
    QList<SWGRelation*>* getRelations();
    void setRelations(QList<SWGRelation*>* relations);
    SWGAlgorithm* getAlgorithm();
    void setAlgorithm(SWGAlgorithm* algorithm);
    

private:
    QList<SWGVehicle*>* vehicles;
    QList<SWGVehicleType*>* vehicle_types;
    QList<SWGService*>* services;
    QList<SWGShipment*>* shipments;
    QList<SWGRelation*>* relations;
    SWGAlgorithm* algorithm;
    
};

} /* namespace Swagger */

#endif /* SWGRequest_H_ */
