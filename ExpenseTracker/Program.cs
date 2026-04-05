using ExpenseTracker.Application.Controllers;
using ExpenseTracker.Application.Session;
using ExpenseTracker.Core.Interface;
using ExpenseTracker.Core.Service;
using ExpenseTracker.Infrastructure.Data;
using ExpenseTracker.UI.Menu;
using ExpenseTracker.UI.Screens;
using ExpenseTracker.Utils;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();

var sqlServerConnection =
    Environment.GetEnvironmentVariable("EXPENSETRACKER_SQLSERVER_CONNECTION")
    ?? "Server=(localdb)\\MSSQLLocalDB;Database=ExpenseTracker;Trusted_Connection=True;TrustServerCertificate=True;";

// DB
services.AddDbContext<AppDbContext>(options => options.UseSqlServer(sqlServerConnection));

// DI
services.AddScoped<ConsoleHelper>();
services.AddScoped<IExpenseRepository, ExpenseRepository>();
services.AddScoped<IExpenseService, ExpenseService>();
services.AddScoped<ExpenseController>();
services.AddScoped<AddExpenseScreen>();
services.AddScoped<ViewExpenseScreen>();
services.AddScoped<DeleteExpenseScreen>();
services.AddScoped<MenuManager>();
services.AddScoped<IUserRepository, UserRepository>();
services.AddScoped<AppInitializer>();

// Singleton
services.AddSingleton<UserSession>();

var provider = services.BuildServiceProvider();
using var scope = provider.CreateScope();
scope.ServiceProvider.GetRequiredService<AppDbContext>().Database.EnsureCreated();


var initializer = provider.GetRequiredService<AppInitializer>();
initializer.Initialize();
// Run app
var menu = provider.GetRequiredService<MenuManager>();
menu.DisplayMenu();
