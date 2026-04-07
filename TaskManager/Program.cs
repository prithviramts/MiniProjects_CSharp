

using Microsoft.Extensions.DependencyInjection;
using TaskManager.Infrastructure;

var services = new ServiceCollection();

var sqlServerConnection =
    Environment.GetEnvironmentVariable("EXPENSETRACKER_SQLSERVER_CONNECTION")
    ?? "Server=(localdb)\\MSSQLLocalDB;Database=TaskManagerDB;Trusted_Connection=True;TrustServerCertificate=True;";

// DB
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(sqlServerConnection));

var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();
scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();


