docker build --no-cache --platform linux/amd64 -f .\\CompanyDB\\Dockerfile -t companydb:latest .
docker build --no-cache --platform linux/amd64 -f .\\EmployeeWebApi\\Dockerfile -t employeewebapi:latest .
docker build --no-cache --platform linux/amd64 -f .\\EmployeeWebApp\\Dockerfile -t employeewebapp:latest .