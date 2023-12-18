using CardService.api.v1.Database;
using Microsoft.EntityFrameworkCore;

namespace CardService;

class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<CardContext>();

        var app = builder.Build();
        
        var serviceScope = app.Services.CreateScope();
        var dbcontext = serviceScope.ServiceProvider.GetService<CardContext>();
        dbcontext?.Database.Migrate();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}