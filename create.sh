#!/bin/bash

SPEC=https://graphhopper.com/api/1/vrp/swagger.json
DIR=.

VERSION=0.8-SNAPSHOT
SW_VERSION=2.2.1
FILE=swagger-codegen-cli-$SW_VERSION.jar

if [[ ! -f $FILE ]]; then
  wget http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/$SW_VERSION/$FILE -O $FILE
  if [[ ! -f $FILE ]]; then
    curl http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/$SW_VERSION/$FILE -O $FILE  
  fi
fi

function create {
  LANG=$1
  CONFIG=""
  ADD_PARAMS=""
  
  case "$LANG" in
	java)
		PKG="com.graphhopper.routeopt.client"
		CONFIG="--artifact-version $VERSION --api-package $PKG.api --invoker-package $PKG --model-package $PKG.model --artifact-id directions-api-java-client-route-opt --group-id com.graphhopper --library okhttp-gson"
		;;
	ruby)
		CONFIG="-c ruby.json"
		;;
	go)		
		# CONFIG="-t modules/swagger-codegen/src/main/resources/go"
		ADD_PARAMS="-DpackageName=graphhopper"
		;;
	swift)
		CONFIG="-c swift.json"
		;;
	javascript)
		CONFIG="-t modules/swagger-codegen/src/main/resources/Javascript"
		;;
	haskell)
		;;
	php)
		CONFIG="--artifact-version $VERSION --git-repo-id directions-api-clients-route-optimization --git-user-id graphhopper --api-package graphhopper"
		;;
  	*)
		;;  
  esac
  
  # echo "create $LANG, config: $CONFIG, additional params: $ADD_PARAMS"
  rm -rf $DIR/$LANG
  SH="java -jar $FILE generate -i $SPEC -l $LANG $CONFIG -o $DIR/$LANG $ADD_PARAMS"
  echo $SH
  $SH
}

LANG=$1
if [[ "$LANG" != "" ]]; then
  create $LANG
  exit 0
else
  echo "creating all"
  create java
  create php
  create ruby
  create python
  create perl
  create scala
  create tizen
  create csharp
  create swift
  create objc
  create nodejs-server
  create qt5cpp
  create go
  create clojure
  create haskell
  
  # create javascript -> nodejs-server    
  # create dart       
  # create sinatra    
fi
