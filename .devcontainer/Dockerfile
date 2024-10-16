# Usar una imagen base de SDK de .NET para compilar la aplicación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar el archivo de proyecto y restaurar las dependencias
COPY src/infiniteworlds_frontend.csproj ./
RUN dotnet restore

# Copiar el resto del código de la aplicación
COPY src/infiniteworlds_frontend.csproj/. ./

# Compilar la aplicación
RUN dotnet publish -c Release -o out

# Usar una imagen base de runtime de .NET para ejecutar la aplicación
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Establecer el directorio de trabajo
WORKDIR /app

# Copiar los archivos compilados desde la etapa de build
COPY --from=build /app/out ./

# Exponer el puerto 80 para la aplicación
EXPOSE 80

# Definir el comando para ejecutar la aplicación
ENTRYPOINT ["dotnet", "infiniteworlds_frontend.dll"] 
