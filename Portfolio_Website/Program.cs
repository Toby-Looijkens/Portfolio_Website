using DB_Library;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
ConfigureDbContext<DBContext>(builder.Services, builder.Configuration);

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

public partial class Program
{
    private static void ConfigureDbContext<TContext>(IServiceCollection services, IConfiguration configurations)
    where TContext : DbContext
    {
        services.AddDbContext<TContext>(options =>
        {
            options.UseSqlServer("Server=localhost; Database=S3-Site-DB;User Id = DESKTOP-GHB40U5\\looij; Password=; TrustServerCertificate=true; Integrated Security = true;");
        });
    }

}