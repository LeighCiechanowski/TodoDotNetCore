#FROM microsoft/aspnetcore:2.0
#ARG source
#WORKDIR /app
#EXPOSE 80
#COPY ${source:-obj/Docker/publish} .
#ENTRYPOINT ["dotnet", "Todo.Api.dll"]

FROM microsoft/aspnetcore-build

WORKDIR /app

COPY . .

RUN dotnet restore

RUN dotnet build

ENTRYPOINT dotnet run