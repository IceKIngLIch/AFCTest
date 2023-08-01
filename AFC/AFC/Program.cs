using AFC.Application.RequestModels;
using AFC.Repository;
using AFC.Repository.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net.NetworkInformation;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddDbContext<MyDbContext>(o =>
    //"Server=127.0.0.1;User Id=postgres;Password=password;Port=5432;Database=BookStore;
        //o.UseNpgsql("host=localhost port=5432 dbname=userdb user=postgres password=root sslmode=prefer connect_timeout=10"),ServiceLifetime.Singleton)     //TODO добавь строку подключение
    o.UseNpgsql("Server=127.0.0.1;User Id=postgres;Password=root;Port=5432;Database=userdb"),ServiceLifetime.Singleton)  
    .AddTransient<IRepository<Client>, ClientsAccessor>() 
    .AddTransient<IRepository<Employee>, EmployeersAccessor>()
    .AddTransient<IRepository<Hall>, HallsAccessor>()
    .AddTransient<IRepository<Schedule>, SchedulersAccessor>()
    .AddTransient<IRepository<Service>, ServicesAccessor>()
    .AddTransient<IRepository<Subscription>, SubscriptionsAccessor>()

    .AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(ClientCreateModel).Assembly))
    .AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(ClientReadModel).Assembly))
    .AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(ClientDeleteModel).Assembly))
    .AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(ClientUpdateModel).Assembly))
    .AddControllers();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
} 

app.UseRouting();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.Run();
