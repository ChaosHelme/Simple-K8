FROM mcr.microsoft.com/dotnet/runtime:9.0 AS base
USER $APP_UID
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["SimpleK8.Core/SimpleK8.Core.csproj", "SimpleK8.Core/"]
COPY ["SimpleK8.Services/SimpleK8.Services.csproj", "SimpleK8.Services/"]
RUN dotnet restore "SimpleK8.Services/SimpleK8.Services.csproj"
COPY . .
WORKDIR "/src/SimpleK8.Services"
RUN dotnet build "SimpleK8.Services.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "SimpleK8.Services.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SimpleK8.Services.dll"]
