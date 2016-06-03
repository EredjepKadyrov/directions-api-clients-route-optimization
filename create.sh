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
		ADD_PARAMS="-DpackageName=graphhopper"
		;;
	swift)
		CONFIG="-c swift.json"
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
  create python
  create perl
  create scala
  create tizen
  create csharp
  create swift
  create objc
  
  # cannot make it working?
  # create go
  # create nodejs-server
fi
