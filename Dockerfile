#shaneboyherversion
#Note, Dockerfile.aspnetcorebase will create core base from aspnetcore and run dnu restore
#that is not part of docker-compose since it only needs to be built once
FROM corewithdependencies

COPY . /app
WORKDIR /app
RUN ["dnu", "restore"]

EXPOSE 5001/tcp
ENTRYPOINT ["dnx", "-p", "project.json", "web"]