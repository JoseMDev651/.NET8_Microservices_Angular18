# .NET8_Microservices_Angular18
Creating NET8 Microservices Clean Architectura and angular 18 - Ecommerce

1.- Create a solution (SharedLibrary). DemoECommerce.SharedSolution
2.- Create Project eCommerce.SharedLibrary
3.- delete class1.cs
4.- Add Nuget Packages
	JWTBearer
	EfCore
	SqlServer
	Serilog.AspNetCore
4.- Package Manager Console
	- dotnet build
5.- Rebuild Solution
6.- Project eCommerce.SharedLibrary
	Create folder Response
	Add class . response.cs
7.- Project eCommerce.SharedLibrary
	Create folder Logs
	Add class LogException
8.- Project eCommerce.SharedLibrary
	Create folder Interface
	Create interface IGenericInterface
9.- Global Exception Middleware (Shared Library)
	Create folder Middleware
	Create file GlobalException.cs
10.- Middleware (Listen to only API Gateway)
	Middleware folder -> Create class (ListenToOnlyGateway)
	a) Task InvokeAsync
11.- Authentication Scheme
	Create folder DependencyInjection
	créate class file JWTAuthenticationSchema.cs
	-Authetication to API
	Shared Service - Create a class ->SharedServiceContainer ->to make public
		Add Generic Database context
		Configure serilog logging
		Add JWT authentication Scheme
		IapplicationBuilder UseSharedPolicies

-------------------------------------------------------
Creating Product API
-Create new PSolution (DemoECommerce.ProdctApiSolution)
-CReate new class Project (Product.ApiSolution)
-Create new class Project (ProductApi.Domain)
- Create new Class Project. Infrastructure. (ProductApi.Infrastructure)
- Create new Wep API Project. Presentation. (ProductAPI.Presentation)
- Add Project eCommerce.SharedLibrary to Solution
- Delete weather files and http.
- Rebuild Solution
- ProductApi.Presentation
	Add Nuget Dependencies:
		For perform migrations. Microsoft.EntityFrameworkCore.Tools
- ProductApi.Application
	Add Project dependencies:
		eCommerce.SharedLibrary
		Product.Api.Domain
- ProductApi.Infrastructure-
	Add Project References
		ProductApi.Aplication
- ProductApi.Presentation
	Add Project references
		ProductApi.Infrastructure
-Rebuild solution
- ProductApi.Domain
	Add folder Entities
	Entities add class Product.cs
- ProductApi.Application
	Add folder DTOs
	Add class ProductDTO
	DTOs.
		Add  new folder -> Conversions
		Add a product conversión -> Add class Product Conversions -> ProductConversion.cs.
	Add folder interfaces
	Add Interface IProduct : IGenericInterface<Product> -> Before created Shared library (eCommerce.SharedLibrary)
- ProductApi.Infrastructure
	- Creation of a Repo 
	- Create folder Repositories.
	- Add class ProductRepository.cs
	- Implementar interface IProduct
	- Inject generic DBContext (Created in shared Library)
	- Create folder Data
	- Create class ProductDbContext.cs
	- Dependency Injection
		- Add folder DependencyInjection
		- Add class ServiceContainer
			- Add database connectivity
			- Add authentication schema
			- Create Dependency Injection (DI)
			- Register middleware such as:Global Exception: handles external errors.
			- Listen to Only API Gateway: blocks all outsider calls.
------------------------------------------------------------------
- Presentation: ProductApi.Presentation 
	- Launch settings
		- http: aplicationUrl= http://localhost:5001
	- app settings
		- Connections strings
		- Myserilog
		- Authentication (port: 5000)
	- Program.cs
		- Services.AddInfrastructureService(builder.Configuration);
		- app.UseInfrastructurePolicy();
	- Controllers.
		- Add Controller in blank.
		- ProductController.cs
		- Inject IProduct
		- Create endpoints
			- [HttpGet]
				- Get all products from repo
				- Convert data from entity to DTO
			- [HttpGet("{id:int}")]
				- Get single product from the Repo
				- Convert from entity to DTO and return
			- [HttpPost]
				- Check model state is all data annotations are passed
				- Convert to Entity
			- [HttpPut]
				- Check model state is all data annotations are passed
				- Convert to Entity
			- [HttpDelete]
				- Convert to Entity
	- Rebuild the Project
-------------------------------------------------------
- ProductApi.Infrastructure
	- Access Database	
	- Package Manager console -> ProductApi.Infrastructure
		- add-migration First -o Data/Migrations
		- update-database
	- Set as initial Project ProductAPI.Presentation

- Launch http -> Swagger -> Endpoints -> http://localhost:5001/swagger/index.html
-----------------------------------------------
- Create other API (Order API) for Microservice Project
	- Create a new solution	(blank)
	- Add Project OOrderApi.Domai	
	- Add Project OrderApi.Application
	- Add Project OrderApi.Infrastructure
	- Add Web API OrderApi.Presentation
	- Rebuild solution
	- Add Project eCommerce.SharedSolution to Order Api solution.
	- OrderApi.Application dependencies:
		- eCommerce.SharedLibrary
		- OrderApi.Domain
	- OrderApi.Infrastructure dependencies:
		- OrderApi.Application	
	- OrderApi.Presentation dependencies:
		- OrderApi.Infrastructure
	- OrderApi.Application Packages:
		- Microsoft.Extensions.Http
		- Polly.Core
		- Polly.Extensions
	- OrderApi.Infrastructure packages:
		- Microsoft.Extensions.DependencyInjection
		- Microsoft.Extensions.DependencyInjection.Abstractions
	- OrderAPI.Presentation packages:
		- Microsoft.EntityFrameworkCore.Tools
	- Rebuild solution.

- OpenApi.Domain
	- Add new folder Entities
	- Add class Order
- OrderApi.Application
	- Add new folder DTOs
	- Create class OrderDTO.(record)
	- Create class ProductDTO. (record)
	- Create class AppUserDTO. (record)
	- Create class OrderDetailsDTO. (record)
	- Add new folder Conversions (Automapper)
	- Add class OrderConversion
	- Add folder Interfaces
	- Add new Interface (IOrder)
	

	
	


