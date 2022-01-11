using P1CoffeeShopAPI.Data;
using P1CoffeeShopAPI.DataStorage;

var builder = WebApplication.CreateBuilder(args);
bool prettyPrinJson = builder.Configuration.GetValue<string>("PrettyPrintJsonOutput") == "true";

//Project1 way to connect
string connectionString = builder.Configuration.GetConnectionString("SQLDatabase");

builder.Services.AddControllers();
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//singleton
builder.Services.AddSingleton<IRepository>(sp => new SqlRepository(connectionString));

var app = builder.Build();
//app.UseRouting()
//    app.UseEndpoints(routerBuilder =>
//        {
//            routerBuilder.MapControllers();
//        });
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
