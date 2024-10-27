FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=false LC_ALL=en_US.UTF-8 LANG=en_US.UTF-8
RUN apk add --no-cache icu-data-full icu-libs

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR .

COPY ["EmployeeWebApi/EmployeeWebApi.csproj", "EmployeeWebApi/"]
COPY ["Employee.EFDAL/EmployeeData.EFDAL.csproj", "Employee.EFDAL/"]

RUN dotnet restore EmployeeWebApi/EmployeeWebApi.csproj
COPY . .
WORKDIR /EmployeeWebApi
RUN dotnet build EmployeeWebApi.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish EmployeeWebApi.csproj -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EmployeeWebApi.dll"]
