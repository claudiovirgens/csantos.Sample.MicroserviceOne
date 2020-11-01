# csantos.Sample.MicroserviceOne

Example Microservice - Order REST API Para ter acesso a Documentação acesse: http://localhost:5000/swagger/index.html

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
Docker - DockerFile
Healthchecks - You Can check the service health using URL: http://serverip:port/checkhealth
Documentations Wiht Swashbucked Swagger http://localhost:5000/swagger/index.html
