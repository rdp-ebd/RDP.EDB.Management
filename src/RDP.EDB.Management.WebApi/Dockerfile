#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/RDP.EDB.Management.WebApi/RDP.EDB.Management.WebApi.csproj", "src/RDP.EDB.Management.WebApi/"]
COPY ["src/RDP.EDB.Management.Application/RDP.EDB.Management.Application.csproj", "src/RDP.EDB.Management.Application/"]
COPY ["src/RDP.EDB.Management.Domain/RDP.EDB.Management.Domain.csproj", "src/RDP.EDB.Management.Domain/"]
COPY ["src/RDP.EDB.Management.Infra/RDP.EDB.Management.Infra.csproj", "src/RDP.EDB.Management.Infra/"]
RUN dotnet restore "./src/RDP.EDB.Management.WebApi/RDP.EDB.Management.WebApi.csproj"
COPY . .
WORKDIR "/src/src/RDP.EDB.Management.WebApi"
RUN dotnet build "./RDP.EDB.Management.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./RDP.EDB.Management.WebApi.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "RDP.EDB.Management.WebApi.dll"]