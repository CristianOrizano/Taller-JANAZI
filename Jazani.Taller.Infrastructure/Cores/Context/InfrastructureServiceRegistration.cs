
using Jazani.Taller.Domain.Admins.Repositories;
using Jazani.Taller.Infrastructure.Admins.Persistences;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace Jazani.Taller.Infrastructure.Cores.Context
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection addInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //dbContext para conexion con base de datos
            services.AddDbContext<AplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });

            return services;
        }
    }
}
