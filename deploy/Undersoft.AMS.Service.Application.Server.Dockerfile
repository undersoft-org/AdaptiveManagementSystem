# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

# This stage is used when running from VS in fast mode (Default for Debug configuration)
FROM mcr.microsoft.com/dotnet/aspnet:8.0-noble-chiseled AS base
USER app
WORKDIR /app
EXPOSE 10005
EXPOSE 10006
EXPOSE 4317

# This stage is used to build the service project
FROM mcr.microsoft.com/dotnet/sdk:8.0-noble AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service.Application.Server/Undersoft.AMS.Service.Application.Server.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service.Application.Server/"]
COPY ["SDK/src/Undersoft.SDK.Service.Application.Server/Undersoft.SDK.Service.Application.Server.csproj", "SDK/src/Undersoft.SDK.Service.Application.Server/"]
COPY ["SDK/src/Undersoft.SDK.Service.Application/Undersoft.SDK.Service.Application.csproj", "SDK/src/Undersoft.SDK.Service.Application/"]
COPY ["SDK/src/Undersoft.SDK.Service/Undersoft.SDK.Service.csproj", "SDK/src/Undersoft.SDK.Service/"]
COPY ["SDK/src/Undersoft.SDK/Undersoft.SDK.csproj", "SDK/src/Undersoft.SDK/"]
COPY ["SDK/src/Undersoft.SDK.Service.Infrastructure/Undersoft.SDK.Service.Infrastructure.csproj", "SDK/src/Undersoft.SDK.Service.Infrastructure/"]
COPY ["SDK/src/Undersoft.SDK.Service.Server/Undersoft.SDK.Service.Server.csproj", "SDK/src/Undersoft.SDK.Service.Server/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service.Application.Client/Undersoft.AMS.Service.Application.Client.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service.Application.Client/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service.Application.GUI/Undersoft.AMS.Service.Application.GUI.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service.Application.GUI/"]
COPY ["SDK/src/Undersoft.SDK.Service.Application.GUI/Undersoft.SDK.Service.Application.GUI.csproj", "SDK/src/Undersoft.SDK.Service.Application.GUI/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service.Application/Undersoft.AMS.Service.Application.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service.Application/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service/Undersoft.AMS.Service.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service/"]
COPY ["AMS/src/AMS/src/AMS.Catalog/src/AMS.Catalog.Service/Undersoft.AMS.Catalog.Service.csproj", "AMS/src/AMS/src/AMS.Catalog/src/AMS.Catalog.Service/"]
COPY ["AMS/src/AMS/src/AMS.Document/src/AMS.Document.Service/Undersoft.AMS.Document.Service.csproj", "AMS/src/AMS/src/AMS.Document/src/AMS.Document.Service/"]
COPY ["AMS/src/AMS/src/AMS.Logistic/src/AMS.Logistic.Service/Undersoft.AMS.Logistic.Service.csproj", "AMS/src/AMS/src/AMS.Logistic/src/AMS.Logistic.Service/"]
COPY ["AMS/src/AMS/src/AMS.Market/src/AMS.Market.Service/Undersoft.AMS.Market.Service.csproj", "AMS/src/AMS/src/AMS.Market/src/AMS.Market.Service/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS/Undersoft.AMS.csproj", "AMS/src/AMS/src/AMS/src/AMS/"]
COPY ["AMS/src/AMS/src/AMS/src/AMS.Service.Infrastructure/Undersoft.AMS.Service.Infrastructure.csproj", "AMS/src/AMS/src/AMS/src/AMS.Service.Infrastructure/"]
RUN dotnet restore ./AMS/src/AMS/src/AMS/src/AMS.Service.Application.Server/Undersoft.AMS.Service.Application.Server.csproj
COPY . .
WORKDIR /src/AMS/src/AMS/src/AMS/src/AMS.Service.Application.Server
RUN dotnet build ./Undersoft.AMS.Service.Application.Server.csproj -c $BUILD_CONFIGURATION -o /app/build

# This stage is used to publish the service project to be copied to the final stage
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish ./Undersoft.AMS.Service.Application.Server.csproj -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# This stage is used in production or when running from VS in regular mode (Default when not using the Debug configuration)
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Undersoft.AMS.Service.Application.Server.dll"]