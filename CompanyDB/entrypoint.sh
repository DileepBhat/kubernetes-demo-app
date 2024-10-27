#!/bin/bash

/opt/mssql/bin/sqlservr &

/usr/companydbconfig/initialize_db.sh

eval $1