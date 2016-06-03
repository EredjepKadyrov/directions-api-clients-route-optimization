#ifndef _SWG_SWGVrpApi_H_
#define _SWG_SWGVrpApi_H_

#include "SWGHttpRequest.h"

#include <QString>
#include "SWGRequest.h"
#include "SWGJobId.h"

#include <QObject>

namespace Swagger {

class SWGVrpApi: public QObject {
    Q_OBJECT

public:
    SWGVrpApi();
    SWGVrpApi(QString host, QString basePath);
    ~SWGVrpApi();

    QString host;
    QString basePath;

    void postVrp(QString* key, SWGRequest body);
    
private:
    void postVrpCallback (HttpRequestWorker * worker);
    
signals:
    void postVrpSignal(SWGJobId* summary);
    
};
}
#endif