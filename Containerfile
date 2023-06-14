FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine

EXPOSE 5248
ENV DOTNET_EnableDiagnostics=0

RUN apk add --update icu-libs icu-data-full tzdata

COPY . /App
WORKDIR /App

RUN dotnet restore
ENTRYPOINT ["dotnet", "run", "--no-restore", "-c", "release"]
