
# BookStore sample API

This API was created to get better understanding about ASP.NET CORE.



## Prerequirements
1. [.NET core and version](https://dotnet.microsoft.com/en-us/download) 5
2. Visual studio

There is [Swagger Client](https://swagger.io/tools/swagger-codegen/) available 💖. 
![swagger](https://user-images.githubusercontent.com/64850016/152136249-79eccb9f-38e9-4a04-b3c0-66c9f1e90657.png)

## Installation

Install these required libraries using **Manage Nuget Packages**
```bash
Autofac.Extensions.DependencyInjection 
AutoMapper.Extensions.Microsoft.DependencyInjection


```
On Terminal, run to check .NET version
```bash
  dotnet --version
```


## Inversion of control (IoC)
Inversion of control (IoC) is a design principle in computer software where the control flow of a program is inverted, meaning that the code that calls a module or function is separated from the code that is executed. This allows for greater flexibility and modularity, as the code that is executed can be replaced or customized without affecting the code that calls it. IoC is often used in the context of dependency injection, where an external framework or library provides the dependencies for a module or object, rather than the module or object declaring and instantiating its own dependencies.
## Dependancy Injection
Dependency Injection (DI) is a design pattern in ASP.NET Core that allows for the separation of concerns and the creation of loosely coupled, testable and maintainable code. In DI, dependencies are not hardcoded within a class, but instead are injected from outside of the class, typically by a DI container. In ASP.NET Core, the built-in DI container can be used to manage and resolve dependencies.
## Why need dependancy injection
1. Unit Testing: DI makes it easy to write unit tests by allowing developers to mock or substitute dependencies. This makes it easier to isolate the behavior of individual components and verify their correctness in isolation.

2. Decoupled Code: DI helps to decouple code by allowing components to be loosely coupled to their dependencies. This makes it easier to maintain and modify code because changes in one component will not necessarily impact other components.

3. Modular Design: DI supports modular design by allowing components to be composed from smaller, reusable components. This makes it easier to create, test, and deploy code, as well as making it easier to maintain and modify code in the future.

4. Configuration Management: DI makes it easy to manage configuration by allowing dependencies to be swapped out or reconfigured at runtime. This makes it easier to manage the behavior of an application in different environments or situations.

5. Improved Reusability: DI supports reusability by allowing components to be used in different contexts and environments. This makes it easier to reuse code and reduces the need for duplicated code.

## Here's a simple example of how DI works in ASP.NET Core:
1. Define an interface that represents a service:

```bash
       public interface IExampleService
{
    void DoWork();
}

```
2. Implement the interface:
```bash
     public class ExampleService : IExampleService
{
    public void DoWork()
    {
        // Implementation details
    }
}
```
3. Register the service with the DI container in Startup.cs:
```bash
 public void ConfigureServices(IServiceCollection services)
{
    services.AddTransient<IExampleService, ExampleService>();
}

```
4. Inject the service into a controller:
```bash
public class ExampleController : Controller
{
    private readonly IExampleService _exampleService;

    public ExampleController(IExampleService exampleService)
    {
        _exampleService = exampleService;
    }

    public IActionResult DoWork()
    {
        _exampleService.DoWork();
        return View();
    }
}
```
_**In this example, the ExampleController class does not need to know about the implementation of the ExampleService class. Instead, the DI container will resolve the ExampleService class and provide it to the ExampleController class when it is requested. This allows for greater flexibility and modularity, as the implementation of the ExampleService class can be changed or swapped out without affecting the ExampleController class.**_

## Development

1. Create models, services and controllers for Book entity and Author enity.
2. Use DataAccess folder to manage database connection.
```bash
 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("BookStoreDB");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
```
3. Define the connection strings in appsettings.json.
```bash
  "ConnectionStrings": {
    "BookStoreDB": "Data Source=RASHMI-D;Initial Catalog=BOOKSTORE;User ID=ras;Password=******"
  }
```

4. Apply migrations.
```bash
 dotnet tool install --global dotnet-ef
 dotnet ef migrations add InitialCreate
 dotnet ef database update
```

5. Dependency injection using  **AutoFac library**.
To achieve this I used separate folder called Dependency register for register all dependencies.

 

```bash
  protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<BookSqlService>().As<IbookRepository>().InstancePerLifetimeScope();
            builder.RegisterType<AuthorSqlService>().As<IAuthorRepository>().InstancePerLifetimeScope();
        }
```

6. Specify mapping configuration in AutoMapper is by using profiles.
```bash
     public AuthorProfile()
        {
            CreateMap<Author, AutorDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FirstName + " " + src.lastName));
        }
```





    
