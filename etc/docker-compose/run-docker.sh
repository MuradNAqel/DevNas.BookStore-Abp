#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 55699c0a-6623-4c58-a008-c6dfbafaded4 -t
    fi
    cd ../
fi

docker-compose up -d
