FROM mcr.microsoft.com/dotnet/sdk:10.0 AS publish
WORKDIR /src

COPY . .

RUN dotnet restore "coreOnBoarding.csproj"
RUN dotnet publish "coreOnBoarding.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

COPY Views ./Views
COPY --from=publish /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "coreOnBoarding.dll"]