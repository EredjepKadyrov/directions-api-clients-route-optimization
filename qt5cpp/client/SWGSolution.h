/*
 * SWGSolution.h
 * 
 * 
 */

#ifndef SWGSolution_H_
#define SWGSolution_H_

#include <QJsonObject>


#include "SWGRoute.h"
#include "SWGSolution_unassigned.h"
#include <QList>

#include "SWGObject.h"


namespace Swagger {

class SWGSolution: public SWGObject {
public:
    SWGSolution();
    SWGSolution(QString* json);
    virtual ~SWGSolution();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGSolution* fromJson(QString &jsonString);

    qint32 getCosts();
    void setCosts(qint32 costs);
    qint32 getDistance();
    void setDistance(qint32 distance);
    qint64 getTime();
    void setTime(qint64 time);
    qint32 getNoUnassigned();
    void setNoUnassigned(qint32 no_unassigned);
    QList<SWGRoute*>* getRoutes();
    void setRoutes(QList<SWGRoute*>* routes);
    SWGSolution_unassigned* getUnassigned();
    void setUnassigned(SWGSolution_unassigned* unassigned);
    

private:
    qint32 costs;
    qint32 distance;
    qint64 time;
    qint32 no_unassigned;
    QList<SWGRoute*>* routes;
    SWGSolution_unassigned* unassigned;
    
};

} /* namespace Swagger */

#endif /* SWGSolution_H_ */
