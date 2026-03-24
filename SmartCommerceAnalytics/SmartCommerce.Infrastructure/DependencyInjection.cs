using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using SmartCommerce.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using SmartCommerce.Application.Services;
using SmartCommerce.Application.Interfaces;
using SmartCommerce.Infrastructure.Repositories;


namespace SmartCommerce.Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IUserRepository,UserRepository>();

            return services;
        }

    }
}
