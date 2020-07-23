using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DataAccess.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddDataContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDataContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnectionString")));
            return services;
        }
    }
}
