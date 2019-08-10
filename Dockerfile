FROM microsoft/dotnet:2.2-sdk AS build-env
WORKDIR /app

COPY leltar.sln ./leltar.sln
##COPY l2l.Data/l2l.Data.csproj ./l2l.Data/l2l.Data.csproj
COPY leltar.csproj ./leltar.csproj
RUN dotnet restore

COPY . ./
RUN dotnet leltar n