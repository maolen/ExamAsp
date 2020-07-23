using Edu.Infrastructure.Implementations;
using Edu.Infrastructure.Services;

using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Text;

namespace Edu.Infrastructure.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IApplicationsRepository, ApplicationsRepository>();
            return services;
        }
    }
}
