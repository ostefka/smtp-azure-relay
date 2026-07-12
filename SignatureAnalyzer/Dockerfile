FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY SignatureService/SignatureService.csproj SignatureService/
COPY SignatureAnalyzer/SignatureAnalyzer.csproj SignatureAnalyzer/
RUN dotnet restore SignatureAnalyzer/SignatureAnalyzer.csproj
COPY SignatureService/ SignatureService/
COPY SignatureAnalyzer/ SignatureAnalyzer/
RUN dotnet publish SignatureAnalyzer/SignatureAnalyzer.csproj -c Release -o /app

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /app .
COPY SignatureService/templates/ /app/templates/
ENTRYPOINT ["dotnet", "SignatureAnalyzer.dll"]
