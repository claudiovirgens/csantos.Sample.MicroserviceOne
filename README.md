# csantos.Sample.MicroserviceOne

Example Microservice - Order REST API Para ter acesso a Documentação acesse: http://localhost:5000/swagger/index.html

http://localhost:5000/api/v1/Order/GetById/1

http://localhost:5000/api/v1/Order/Add

![Microservice Captura de tela 2020-11-01 104012](https://user-images.githubusercontent.com/22963012/97807138-de1da680-1c3d-11eb-8e9b-2a544db96d28.png)

Add - This Endpoint is To Create a new Order (Este endpoint é para criação de uma novo registro na Entidade Order)
Cancel - To Cancel an existing Order ( Este endpoint é para cancelar um Order existente)
GetById - This Endpoind is To Get Order By ID (This Endpoint is para obter um Order com base no seu Id)
GetByCostomerId - Get All orders for Customer Id (This Endpoint is para obter todas Orders com base no Id do Customer)

OBS:
Customer and Product are others Microservices, Order Microservice contains just customerId and productId.
Logging Feature must be configured for save log files outside of dockers containers because if you store in the containers then there is a possibility of losing that data.


.NET Core version 3.1.403
Entity Framework CORE
Api Versioning
Serilog (Logging Implementation)
SQL Server Express (LocalDb)
Docker Containerization
Healthchecks - You Can check the service health using URL: http://serverip:port/checkhealth
Documentations Wiht Swashbucked Swagger http://localhost:5000/swagger/index.html

HealthChecks:

![healthChecksCaptura de tela 2020-11-01 123212](https://user-images.githubusercontent.com/22963012/97807210-55ebd100-1c3e-11eb-865d-5d074e043450.png)

DockerFile:
![DockerMicroservice_Captura de tela 2020-11-01 123519](https://user-images.githubusercontent.com/22963012/97807304-d3174600-1c3e-11eb-8662-c7db0961bdc3.png)
