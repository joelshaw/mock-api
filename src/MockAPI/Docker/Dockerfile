FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY ../engine/examples ./
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app

COPY --from=build-env /app/out .
WORKDIR /app
ENTRYPOINT [ "dotnet", "aspnetapp.dll" ]