FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false LC_ALL=en_US.UTF-8 LANG=en_US.UTF-8
RUN apk add --no-cache icu-data-full icu-libs

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR .

COPY ["EmployeeWebApp/EmployeeWebApp.csproj", "EmployeeWebApp/"]
COPY ["Employee.EFDAL/EmployeeData.EFDAL.csproj", "Employee.EFDAL/"]

RUN dotnet restore EmployeeWebApp/EmployeeWebApp.csproj
COPY . .
WORKDIR /EmployeeWebApp
RUN dotnet build EmployeeWebApp.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish EmployeeWebApp.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeWebApp.dll"]
