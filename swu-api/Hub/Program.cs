using SwuApi.Server.Hubs;
using SwuApi.Server.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// just use console logger for development right now
// TODO use different logging when deployed
builder.Logging.ClearProviders()
    .AddDebug()
    .AddConsole();

builder.Services.AddCors();
builder.Services.AddSignalR();

builder.Services.AddHttpClient();
builder.Services.AddSingleton<ISwudbService, SwudbService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
});

app.UseRouting();
app.MapHub<MessageHub>("/messageHub");

app.Run();
