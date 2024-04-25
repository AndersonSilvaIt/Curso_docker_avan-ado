#### Estágio 1 - Obter o source e gerar o Build ###
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS build
WORKDIR /app
COPY . /app
RUN dotnet restore .\TesteDocker.csproj
RUN dotnet publish .\TesteDocker.csproj -c Release -o /app/publish 

### Estágio 2 - Subir a aplicação através dos binários ###
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "TesteDocker.dll"]



#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

#FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
#USER app
#WORKDIR /app
#EXPOSE 8080
#EXPOSE 8081
#
#FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
#ARG BUILD_CONFIGURATION=Release
#WORKDIR /src
#COPY ["TesteDocker.csproj", "."]
#RUN dotnet restore "./TesteDocker.csproj"
#COPY . .
#WORKDIR "/src/."
#RUN dotnet build "./TesteDocker.csproj" -c $BUILD_CONFIGURATION -o /app/build
#
#FROM build AS publish
#ARG BUILD_CONFIGURATION=Release
#RUN dotnet publish "./TesteDocker.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app/publish .
#ENTRYPOINT ["dotnet", "TesteDocker.dll"]