# Usar una imagen base de Ubuntu
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env
WORKDIR /app

# Instalar Apache y otras dependencias
RUN apt-get update && \
    apt-get install -y apache2 && \
    apt-get install -y libapache2-mod-proxy && \
    apt-get install -y apt-transport-https && \
    apt-get install -y sql-server-linux


# Copiar el archivo de solución y restaurar las dependencias
COPY *.sln ./
COPY [TuProyecto]/*.csproj [TuProyecto]/
RUN dotnet restore

# Copiar el resto de la aplicación y compilar
COPY . ./
RUN dotnet publish -c Release -o out

# Configuración de Apache
RUN echo "ProxyPass / http://localhost:5000/" >> /etc/apache2/sites-available/000-default.conf && \
    echo "ProxyPassReverse / http://localhost:5000/" >> /etc/apache2/sites-available/000-default.conf && \
    a2enmod proxy && \
    a2enmod proxy_http

# Exponer el puerto 80
EXPOSE 80

# Comando para ejecutar Apache y tu aplicación
CMD service apache2 start && dotnet out/[TuAplicacion].dll
