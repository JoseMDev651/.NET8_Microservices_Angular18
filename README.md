# .NET8_Microservices_Angular18
Creating NET8 Microservices_Clean Architectura and angular 18 - Ecommerce

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
	
	
	


