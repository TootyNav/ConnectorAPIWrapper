using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Connector.Data;
using Connector.Repo;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ConnectorContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectorContext") ?? throw new InvalidOperationException("Connection string 'ConnectorContext' not found.")));

builder.Services.AddHttpClient("cqc", client =>
{
    client.BaseAddress = new Uri("https://api.cqc.org.uk/");
});

builder.Services.AddTransient<ICqcRepoService, CqcRepoService>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
