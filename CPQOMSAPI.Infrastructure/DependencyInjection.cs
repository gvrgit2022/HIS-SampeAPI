using SampleAPI.Infrastructure.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace SampleAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddLogging();
            //services.Replace(ServiceDescriptor.Singleton(typeof(ILogger<>), typeof(WithTraceIdLogger<>)));
            services.AddDbContext(configuration);

            //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
            //services.AddScoped(typeof(IPipelineBehavior<,>), typeof(DeleteLoggingBehavior<,>));
            //services.AddOsMarketplaceDeprecation(configuration);
            return services;
        }
    }
}
