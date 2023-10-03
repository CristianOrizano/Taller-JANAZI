
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
            services.AddDbContext<AplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbConnection"));
            });

            services.AddTransient<IPermissionRepository,PermissionRepository>();

            services.AddTransient<ILabelRepository,LabelRepository>();

            return services;
        }

    }
}
