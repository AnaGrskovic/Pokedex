using PokeDex.Contracts.Models;
using PokeDex.Contracts.Repositories;
using PokeDex.Contracts.Services;
using PokeDex.Data.Db.Configurations;
using PokeDex.Data.Db.Repositories;
using PokeDex.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.IO;

[assembly: FunctionsStartup(typeof(PokeDex.Functions.Startup))]

namespace PokeDex.Functions
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlServer(
                    config.GetConnectionString("LibraryDB"),
                    opt => opt.MigrationsAssembly("Library.AnaGrskovic.Data.Db"));
            });

            builder.Services.Configure<EmailSettings>(config.GetSection("EmailSettings"));

            builder.Services.AddScoped<IEmailService, EmailService>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
