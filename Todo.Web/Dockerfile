FROM microsoft/aspnetcore-build

WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet build

ENTRYPOINT dotnet run