/*
 * SWGService.h
 * 
 * 
 */

#ifndef SWGService_H_
#define SWGService_H_

#include <QJsonObject>


#include "SWGAddress.h"
#include "SWGTimeWindow.h"
#include <QList>
#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGService: public SWGObject {
public:
    SWGService();
    SWGService(QString* json);
    virtual ~SWGService();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGService* fromJson(QString &jsonString);

    QString* getId();
    void setId(QString* id);
    QString* getType();
    void setType(QString* type);
    qint32 getPriority();
    void setPriority(qint32 priority);
    QString* getName();
    void setName(QString* name);
    SWGAddress* getAddress();
    void setAddress(SWGAddress* address);
    qint64 getDuration();
    void setDuration(qint64 duration);
    QList<SWGTimeWindow*>* getTimeWindows();
    void setTimeWindows(QList<SWGTimeWindow*>* time_windows);
    QList<qint32>* getSize();
    void setSize(QList<qint32>* size);
    QList<QString*>* getRequiredSkills();
    void setRequiredSkills(QList<QString*>* required_skills);
    QList<QString*>* getAllowedVehicles();
    void setAllowedVehicles(QList<QString*>* allowed_vehicles);
    

private:
    QString* id;
    QString* type;
    qint32 priority;
    QString* name;
    SWGAddress* address;
    qint64 duration;
    QList<SWGTimeWindow*>* time_windows;
    QList<qint32>* size;
    QList<QString*>* required_skills;
    QList<QString*>* allowed_vehicles;
    
};

} /* namespace Swagger */

#endif /* SWGService_H_ */
