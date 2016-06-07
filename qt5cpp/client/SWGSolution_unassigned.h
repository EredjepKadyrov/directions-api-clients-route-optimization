/*
 * SWGSolution_unassigned.h
 * 
 * 
 */

#ifndef SWGSolution_unassigned_H_
#define SWGSolution_unassigned_H_

#include <QJsonObject>


#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGSolution_unassigned: public SWGObject {
public:
    SWGSolution_unassigned();
    SWGSolution_unassigned(QString* json);
    virtual ~SWGSolution_unassigned();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGSolution_unassigned* fromJson(QString &jsonString);

    QList<QString*>* getServices();
    void setServices(QList<QString*>* services);
    QList<QString*>* getShipments();
    void setShipments(QList<QString*>* shipments);
    

private:
    QList<QString*>* services;
    QList<QString*>* shipments;
    
};

} /* namespace Swagger */

#endif /* SWGSolution_unassigned_H_ */
