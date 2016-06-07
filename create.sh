#!/bin/bash

SPEC=https://graphhopper.com/api/1/vrp/swagger.json
DIR=.

FILE=swagger-codegen-cli-2.1.5.jar

if [[ ! -f $FILE ]]; then
  wget http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.1.5/$FILE -O $FILE
  if [[ ! -f $FILE ]]; then
    curl http://repo1.maven.org/maven2/io/swagger/swagger-codegen-cli/2.1.5/$FILE -O $FILE  
  fi
fi

function create {
  LANG=$1
  CONFIG=""
  ADD_PARAMS=""
  
  case "$LANG" in
	java)
		PKG="com.graphhopper.routeopt.client"
		CONFIG="--artifact-version 0.7-SNAPSHOT --api-package $PKG.api --invoker-package $PKG --model-package $PKG.model --artifact-id directions-api-java-client-route-opt --group-id com.graphhopper --library okhttp-gson"
		;;
	ruby)
		CONFIG="-c ruby.json"
		;;
	go)		
		CONFIG="-t modules/swagger-codegen/src/main/resources/go"
		ADD_PARAMS="-DpackageName=graphhopper"
		;;
	swift)
		CONFIG="-c swift.json"
		;;
	javascript)
		CONFIG="-t modules/swagger-codegen/src/main/resources/Javascript"
		;;
	haskell)
		CONFIG="-t modules/swagger-codegen/src/main/resources/haskell-servant"
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
  create sinatra
  create python
  create perl
  create scala
  create tizen
  create csharp
  create swift
  create objc
  create dart
  create nodejs
  create qt5cpp
    
  # cannot make it working?
  # create javascript
  # create go
  # create clojure
  # create haskell
fi
