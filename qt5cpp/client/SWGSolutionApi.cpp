#include "SWGSolutionApi.h"
#include "SWGHelpers.h"
#include "SWGModelFactory.h"

#include <QJsonArray>
#include <QJsonDocument>

namespace Swagger {
SWGSolutionApi::SWGSolutionApi() {}

SWGSolutionApi::~SWGSolutionApi() {}

SWGSolutionApi::SWGSolutionApi(QString host, QString basePath) {
    this->host = host;
    this->basePath = basePath;
}

void
SWGSolutionApi::getSolution(QString* key, QString* jobId) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/solution/{jobId}");

    
    QString jobIdPathParam("{"); jobIdPathParam.append("jobId").append("}");
    fullPath.replace(jobIdPathParam, stringValue(jobId));
    

    
    
    if(fullPath.indexOf("?") > 0) 
      fullPath.append("&");
    else 
      fullPath.append("?");
    fullPath.append(QUrl::toPercentEncoding("key"))
        .append("=")
        .append(QUrl::toPercentEncoding(stringValue(key)));
    

    
    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "GET");

    

    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGSolutionApi::getSolutionCallback);

    worker->execute(&input);
}

void
SWGSolutionApi::getSolutionCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGResponse* output = static_cast<SWGResponse*>(create(json, QString("SWGResponse")));
    
    
    

    worker->deleteLater();

    emit getSolutionSignal(output);
    
}
} /* namespace Swagger */
