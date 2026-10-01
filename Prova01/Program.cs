
using CascaApi.Models;
using CascaApi.Repository;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddSingleton<ListaEleitores>();
builder.Services.AddSingleton<ListaTurno>();
builder.Services.AddSingleton<IEleitorRepository, EleitorRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
