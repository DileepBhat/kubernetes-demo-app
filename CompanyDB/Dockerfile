FROM mcr.microsoft.com/mssql/server:2017-latest

#Create a directory for sql configuration
RUN mkdir -p /usr/companydbconfig

#Copy all files to newly created directory
COPY /CompanyDB /usr/companydbconfig
WORKDIR /usr/companydbconfig

#Grant permissions to execute
RUN chmod +x entrypoint.sh
RUN chmod +x initialize_db.sh

ENTRYPOINT ["./entrypoint.sh"]

# Tail the setup logs to trap the process
CMD ["tail -f /dev/null"]

HEALTHCHECK --interval=15s CMD /opt/mssql-tools/bin/sqlcmd -U sa -P $SA_PASSWORD -Q "select 1" && grep -q "MSSQL CONFIG COMPLETE" ./config.log