FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SimpleK8.Api/SimpleK8.Api.csproj", "SimpleK8.Api/"]
COPY ["SimpleK8.Application/SimpleK8.Application.csproj", "SimpleK8.Application/"]
COPY ["SimpleK8.Core/SimpleK8.Core.csproj", "SimpleK8.Core/"]
COPY ["SimpleK8.DataContracts/SimpleK8.DataContracts.csproj", "SimpleK8.DataContracts/"]
COPY ["SimpleK8.Worker/SimpleK8.Worker.csproj", "SimpleK8.Worker/"]
COPY ["SimpleK8.Infrastructure/SimpleK8.Infrastructure.csproj", "SimpleK8.Infrastructure/"]
RUN dotnet restore "SimpleK8.Api/SimpleK8.Api.csproj"
COPY . .
WORKDIR "/src/SimpleK8.Api"
RUN dotnet build "SimpleK8.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SimpleK8.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleK8.Api.dll"]
