/*
 * SWGAlgorithm.h
 * 
 * 
 */

#ifndef SWGAlgorithm_H_
#define SWGAlgorithm_H_

#include <QJsonObject>


#include <QString>

#include "SWGObject.h"


namespace Swagger {

class SWGAlgorithm: public SWGObject {
public:
    SWGAlgorithm();
    SWGAlgorithm(QString* json);
    virtual ~SWGAlgorithm();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGAlgorithm* fromJson(QString &jsonString);

    QString* getProblemType();
    void setProblemType(QString* problem_type);
    QString* getObjective();
    void setObjective(QString* objective);
    

private:
    QString* problem_type;
    QString* objective;
    
};

} /* namespace Swagger */

#endif /* SWGAlgorithm_H_ */
