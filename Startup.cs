using Identity.Data.Context;
using Identity.Data.Repositories;
using Identity.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(Identity.Startup))]

namespace Identity
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<DbContexto>(options =>
            // options.UseSqlServer(Configuration.GetConnectionString("Connect")));


            //Serviço para login
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<DbContexto>()
                .AddDefaultTokenProviders();

            //Configurando senha
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireDigit = true;

            });


            services.AddScoped<IDadosEmpresa, DadosEmpresaRepository>();
            services.AddScoped<IDadosSocio, DadosSocioRepository>();
        }
    }
}
