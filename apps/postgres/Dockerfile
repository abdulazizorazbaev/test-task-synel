FROM  postgres:latest

ENV POSTGRES_USER postgres_admin
ENV POSTGRES_PASSWORD AAaa@@22
ENV POSTGRES_DB synel-db
COPY  ./apps/postgres/init.sql  /docker-entrypoint-initdb.d/