
# BookStore sample API

This API was created to get better understanding about ASP.NET CORE.



## Prerequirements
1. [.NET core and version](https://dotnet.microsoft.com/en-us/download) 5
2. Visual studio

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


##


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





    
