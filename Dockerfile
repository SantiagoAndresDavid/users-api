# Establecer la imagen base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 5035
EXPOSE 7062
EXPOSE 8080

# Construir la imagen
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["src/Api/Api.csproj", "src/Api/"]
COPY ["src/Data/Data.csproj", "src/Data/"]
COPY ["src/Entities/Entities.csproj", "src/Entities/"]
COPY ["src/Service/Service.csproj", "src/Service/"]
WORKDIR /test
COPY ["test/CSharpSkeleton.Test/CSharpSkeleton.Test.csproj", "test/CSharpSkeleton.Test/"]
WORKDIR /src
RUN dotnet restore "src/Api/Api.csproj"
COPY . .
RUN dotnet build "src/Api/Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

# Publicar la aplicación
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
RUN dotnet publish "src/Api/Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# Preparar la imagen final
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.dll"]
