FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY SignatureService.csproj .
RUN dotnet restore
COPY . .
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app .

# Durable storage volume mount point
VOLUME /app/data

EXPOSE 25
EXPOSE 8080
ENTRYPOINT ["dotnet", "SignatureService.dll"]
