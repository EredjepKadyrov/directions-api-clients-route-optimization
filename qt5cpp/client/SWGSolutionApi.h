#ifndef _SWG_SWGSolutionApi_H_
#define _SWG_SWGSolutionApi_H_

#include "SWGHttpRequest.h"

#include <QString>
#include "SWGResponse.h"

#include <QObject>

namespace Swagger {

class SWGSolutionApi: public QObject {
    Q_OBJECT

public:
    SWGSolutionApi();
    SWGSolutionApi(QString host, QString basePath);
    ~SWGSolutionApi();

    QString host;
    QString basePath;

    void getSolution(QString* key, QString* jobId);
    
private:
    void getSolutionCallback (HttpRequestWorker * worker);
    
signals:
    void getSolutionSignal(SWGResponse* summary);
    
};
}
#endif