using P1CoffeeShopAPI.Data;
using P1CoffeeShopAPI.DataStorage;

var builder = WebApplication.CreateBuilder(args);

//connection string
string connectionString = await File.ReadAllTextAsync("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
builder.Services.AddControllers();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//singleton
builder.Services.AddSingleton<IRepository>(sp => new SqlRepository(connectionString));

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
