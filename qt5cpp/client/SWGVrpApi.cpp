#include "SWGVrpApi.h"
#include "SWGHelpers.h"
#include "SWGModelFactory.h"

#include <QJsonArray>
#include <QJsonDocument>

namespace Swagger {
SWGVrpApi::SWGVrpApi() {}

SWGVrpApi::~SWGVrpApi() {}

SWGVrpApi::SWGVrpApi(QString host, QString basePath) {
    this->host = host;
    this->basePath = basePath;
}

void
SWGVrpApi::postVrp(QString* key, SWGRequest body) {
    QString fullPath;
    fullPath.append(this->host).append(this->basePath).append("/optimize");

    

    
    
    if(fullPath.indexOf("?") > 0) 
      fullPath.append("&");
    else 
      fullPath.append("?");
    fullPath.append(QUrl::toPercentEncoding("key"))
        .append("=")
        .append(QUrl::toPercentEncoding(stringValue(key)));
    

    
    

    HttpRequestWorker *worker = new HttpRequestWorker();
    HttpRequestInput input(fullPath, "POST");

    

    
    
    
    QString output = body.asJson();
    input.request_body.append(output);
    

    

    connect(worker,
            &HttpRequestWorker::on_execution_finished,
            this,
            &SWGVrpApi::postVrpCallback);

    worker->execute(&input);
}

void
SWGVrpApi::postVrpCallback(HttpRequestWorker * worker) {
    QString msg;
    if (worker->error_type == QNetworkReply::NoError) {
        msg = QString("Success! %1 bytes").arg(worker->response.length());
    }
    else {
        msg = "Error: " + worker->error_str;
    }

    

    
    
    
    QString json(worker->response);
    SWGJobId* output = static_cast<SWGJobId*>(create(json, QString("SWGJobId")));
    
    
    

    worker->deleteLater();

    emit postVrpSignal(output);
    
}
} /* namespace Swagger */
