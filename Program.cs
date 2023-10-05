using InterraWebBackend.Data;
using InterraWebBackend.Repository;
using Microsoft.EntityFrameworkCore;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddDbContext<InterraDBContext>();
//builder.Services.AddDbContext<InterraDBContext>(options=>options.UseSqlServer("Server=.;Database=InterraWebDB;Integrated Security=True"));
//getting connection string from appsettings.json
builder.Services.AddDbContext<InterraDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("InterraWebDB")));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IQuickLinkRepository, QuickLinkRepository>();
builder.Services.AddScoped<IDigitalFootprintsRepository, DigitalFootprintsRepository>();
builder.Services.AddScoped<IClientFeedbackRepository, ClientFeedbackRepository>();
builder.Services.AddScoped<IHomePageDataRepository, HomePageDataRepository>();
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
