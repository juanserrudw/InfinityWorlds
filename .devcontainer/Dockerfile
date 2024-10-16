# Usar la imagen base de SQL Server
FROM mcr.microsoft.com/mssql/server:2022-latest

# Establecer las variables de entorno para SQL Server
ENV ACCEPT_EULA=Y
ENV MSSQL_SA_PASSWORD=Jcdo1096@

# Exponer el puerto 1433 para el servicio de SQL Server
EXPOSE 1433

# Comando por defecto al iniciar el contenedor
CMD ["sqlservr"]
