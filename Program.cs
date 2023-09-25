using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure Kestrel to listen on a specific IP address and port
//app.Urls.Add("http://192.168.200.146:44377");
// Configure Kestrel to listen on multiple endpoints
app.Urls.Add("http://192.168.200.146:44377");
//app.Urls.Add("https://192.168.200.146:44378");
app.Urls.Add("http://localhost:5066");
//app.Urls.Add("https://localhost:5000");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
