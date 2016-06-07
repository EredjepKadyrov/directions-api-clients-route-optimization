/*
 * SWGAddress.h
 * 
 * 
 */

#ifndef SWGAddress_H_
#define SWGAddress_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGAddress: public SWGObject {
public:
    SWGAddress();
    SWGAddress(QString* json);
    virtual ~SWGAddress();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGAddress* fromJson(QString &jsonString);

    QString* getLocationId();
    void setLocationId(QString* location_id);
    double getLon();
    void setLon(double lon);
    double getLat();
    void setLat(double lat);
    

private:
    QString* location_id;
    double lon;
    double lat;
    
};

} /* namespace Swagger */

#endif /* SWGAddress_H_ */
