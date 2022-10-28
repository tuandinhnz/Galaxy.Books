using Galaxy.Books.DataLayer;
using Galaxy.Books.Services;
using Galaxy.Books.Services.Repositories;
using Galaxy.Logging;
using Galaxy.Monitoring;
using Galaxy.Monitoring.Extensions;
using Galaxy.Settings;
using Galaxy.Settings.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseLogging();
builder.Configuration.AddConfigurationFiles(builder.Environment);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IAppSettings>(builder.Configuration.LoadGalaxyConfigurations());
builder.Services.AddBasicHealthChecks();
builder.Services.AddAdditionalStartupHealthChecks<MsSqlStartupHealthCheck>();
builder.Services.AddDbContext<BooksDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetSection("galaxy").GetSection("sqlDatabase")["connectionString"]);
});
builder.Services.AddScoped<IBookInfoRepository, BookInfoRepository>();
builder.Services.AddScoped<IBookInfoService, BookInfoService>();

var app = builder.Build();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<BooksDbContext>();
    //Run the Migration and create a database if we do not already have it.
    await context.Database.MigrateAsync();
    //Adding data to the database is an async action, therefore, we need to await for the result here.
    await SeedSampleData.SeedData(context);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseKubernetesHealthCheck();

app.UseAuthorization();

app.MapControllers();

app.Run();
