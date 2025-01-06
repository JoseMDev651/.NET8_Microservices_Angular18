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
		
	

	
	
	


