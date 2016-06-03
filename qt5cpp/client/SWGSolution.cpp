
#include "SWGSolution.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGSolution::SWGSolution(QString* json) {
    init();
    this->fromJson(*json);
}

SWGSolution::SWGSolution() {
    init();
}

SWGSolution::~SWGSolution() {
    this->cleanup();
}

void
SWGSolution::init() {
    costs = 0;
    distance = 0;
    time = 0L;
    no_unassigned = 0;
    routes = new QList<SWGRoute*>();
    unassigned = NULL;
    
}

void
SWGSolution::cleanup() {
    
    
    
    
    if(routes != NULL) {
        QList<SWGRoute*>* arr = routes;
        foreach(SWGRoute* o, *arr) {
            delete o;
        }
        delete routes;
    }
    if(unassigned != NULL) {
        delete unassigned;
    }
    
}

SWGSolution*
SWGSolution::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGSolution::fromJsonObject(QJsonObject &pJson) {
    setValue(&costs, pJson["costs"], "qint32", "");
    setValue(&distance, pJson["distance"], "qint32", "");
    setValue(&time, pJson["time"], "qint64", "");
    setValue(&no_unassigned, pJson["no_unassigned"], "qint32", "");
    setValue(&routes, pJson["routes"], "QList", "SWGRoute");
    setValue(&unassigned, pJson["unassigned"], "SWGObject", "SWGObject");
    
}

QString
SWGSolution::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGSolution::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    obj->insert("costs", QJsonValue(costs));
    obj->insert("distance", QJsonValue(distance));
    obj->insert("time", QJsonValue(time));
    obj->insert("no_unassigned", QJsonValue(no_unassigned));
    
    
    QList<SWGRoute*>* routesList = routes;
    QJsonArray routesJsonArray;
    toJsonArray((QList<void*>*)routes, &routesJsonArray, "routes", "SWGRoute");

    obj->insert("routes", routesJsonArray);
    
    
    
    
    toJsonValue(QString("unassigned"), unassigned, obj, QString("SWGObject"));
    
    
    
    

    return obj;
}

qint32
SWGSolution::getCosts() {
    return costs;
}
void
SWGSolution::setCosts(qint32 costs) {
    this->costs = costs;
}

qint32
SWGSolution::getDistance() {
    return distance;
}
void
SWGSolution::setDistance(qint32 distance) {
    this->distance = distance;
}

qint64
SWGSolution::getTime() {
    return time;
}
void
SWGSolution::setTime(qint64 time) {
    this->time = time;
}

qint32
SWGSolution::getNoUnassigned() {
    return no_unassigned;
}
void
SWGSolution::setNoUnassigned(qint32 no_unassigned) {
    this->no_unassigned = no_unassigned;
}

QList<SWGRoute*>*
SWGSolution::getRoutes() {
    return routes;
}
void
SWGSolution::setRoutes(QList<SWGRoute*>* routes) {
    this->routes = routes;
}

SWGObject*
SWGSolution::getUnassigned() {
    return unassigned;
}
void
SWGSolution::setUnassigned(SWGObject* unassigned) {
    this->unassigned = unassigned;
}



} /* namespace Swagger */

