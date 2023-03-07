FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY DemoMicroService.csproj .
run dotnet restore
COPY . .
RUN dotnet publish -c release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:7.0.3-bullseye-slim-arm32v7
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "DemoMicroService.dll"]