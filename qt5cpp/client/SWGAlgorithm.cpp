
#include "SWGAlgorithm.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGAlgorithm::SWGAlgorithm(QString* json) {
    init();
    this->fromJson(*json);
}

SWGAlgorithm::SWGAlgorithm() {
    init();
}

SWGAlgorithm::~SWGAlgorithm() {
    this->cleanup();
}

void
SWGAlgorithm::init() {
    problem_type = new QString("");
    objective = new QString("");
    
}

void
SWGAlgorithm::cleanup() {
    if(problem_type != NULL) {
        delete problem_type;
    }
    if(objective != NULL) {
        delete objective;
    }
    
}

SWGAlgorithm*
SWGAlgorithm::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGAlgorithm::fromJsonObject(QJsonObject &pJson) {
    setValue(&problem_type, pJson["problem_type"], "QString", "QString");
    setValue(&objective, pJson["objective"], "QString", "QString");
    
}

QString
SWGAlgorithm::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGAlgorithm::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    
    toJsonValue(QString("problem_type"), problem_type, obj, QString("QString"));
    
    
    
    
    
    toJsonValue(QString("objective"), objective, obj, QString("QString"));
    
    
    
    

    return obj;
}

QString*
SWGAlgorithm::getProblemType() {
    return problem_type;
}
void
SWGAlgorithm::setProblemType(QString* problem_type) {
    this->problem_type = problem_type;
}

QString*
SWGAlgorithm::getObjective() {
    return objective;
}
void
SWGAlgorithm::setObjective(QString* objective) {
    this->objective = objective;
}



} /* namespace Swagger */

