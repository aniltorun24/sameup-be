Initial Commit

Project Setup 101

dotnet new sln

dotnet new webapi -o GGlease.API
dotnet sln gg-lease-api.sln add GGlease.API
-> Controller Katmanı -> API endpointlerinin bulunduğu yer.

dotnet new classlib -o GGlease.Services
dotnet sln gg-lease-api.sln add GGlease.Services
-> Service Katmanı

dotnet new classlib -o GGlease.Data
dotnet sln gg-lease-api.sln add GGlease.Data
-> DB connection ve migrations erişimleri.

dotnet new classlib -o GGlease.Model
dotnet sln gg-lease-api.sln add GGlease.Model
-> Tüm classların modellerinin olduğu yer.

to see projects: dotnet sln gg-lease-api.sln list

dotnet add package Microsoft.EntityFrameworkCore.Design --version 6.0.4
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 6.0.4
dotnet add package Microsoft.EntityFrameworkCore.Relational --version 6.0.4
dotnet add package AutoMapper

dotnet add reference ../GGlease.Model/GGlease.Model.csproj

dotnet ef migrations add Initial -c GGlease.Data.DataContext -s "../GGlease.API"
dotnet ef migrations remove -c GGlease.Data.DataContext -s "../GGlease.API"
dotnet ef database update -c GGlease.Data.DataContext -s "../GGlease.API"



dotnet ef migrations add AddingTimestamptsToModels -c GGlease.Data.DataContext -s "../GGlease.API"
dotnet ef migrations add NewData -c GGlease.Data.DataContext -s "../GGlease.API"


dotnet add package Newtonsoft.Json --version 13.0.2
dotnet add package Serilog.Extensions.Logging --version 3.1.0
dotnet add package Serilog.Sinks.File --version 5.0.0
dotnet add package Swashbuckle.AspNetCore --version 6.2.3




- Bugs

Equipment - SellerCompany arasında many-to-many ilişki tanımlanacak.

-Publish:
API path'indeyken:
dotnet clean & dotnet build -c Release & dotnet publish -c Release --os win --arch x64