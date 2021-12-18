using Autofac;
using Autofac.Extensions.DependencyInjection;
using GQLWebApi.Data;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
ConfigureHostBuilder configureHostBuilder = builder.Host;

configureHostBuilder.UseServiceProviderFactory<ContainerBuilder>(new AutofacServiceProviderFactory());


IConfiguration configuration = builder.Configuration;
IServiceCollection serviceCollection = builder.Services;

serviceCollection.AddLogging();
serviceCollection.AddControllers();
serviceCollection.AddEndpointsApiExplorer();
serviceCollection.AddSwaggerGen();
//serviceCollection.AddDbContext<AppDbContext>(options => 
//{
//    options.UseSqlServer(configuration.GetConnectionString("Local"));

//});
configureHostBuilder.ConfigureContainer<ContainerBuilder>(containerBuilder =>
{
    containerBuilder
        .RegisterType<AppDbContext>()
        .WithParameter("dbContextOptions", new DbContextOptionsBuilder<AppDbContext>().UseSqlServer(configuration.GetConnectionString("Local")).Options)
        .InstancePerLifetimeScope();

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
