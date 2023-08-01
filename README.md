# ProcessRUs

## Endpoints
Login: https://localhost:7089/api/v1/login

 Access: https://localhost:7089/api/v1/access/fruit?type=3

## User Credentials for testing
Email= "frontoffice@processrus.com"
Password = "FrontOffice@01"

Email= "backoffice@processrus.com"
Password = "BackOffice@01

Email= "admin@processrus.com"
Password = "Admin@01"

## Direction for testing
1. Run  Application (At the root of the project, type the command     **dotnet run**    and press enter)
2. Insert URLs into Postman request
3. Pass the bearer token to the Authorization tab when testing the Access Endpoint. (You can get the token from the response payload of the Login endpoint)
