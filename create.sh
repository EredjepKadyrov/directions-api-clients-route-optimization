#!/bin/bash

SPEC=https://graphhopper.com/api/1/vrp/swagger.json
DIR=.

function create {
  LANG=$1
  CONFIG=""
  ADD_PARAMS=""
  
  case "$LANG" in
	java)
		CONFIG="-c java.json"
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
  SH="java -jar swagger-codegen/modules/swagger-codegen-cli/target/swagger-codegen-cli.jar generate -i $SPEC -l $LANG $CONFIG -o $DIR/$LANG $ADD_PARAMS"
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
