using SampleAPI.Infrastructure.Models.Common;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleAPI.Infrastructure.Models.Test;

namespace SampleAPI.Infrastructure.Models
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddDbContext(this IServiceCollection services,Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
           
            services.AddDbContext<testContext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString(Constants.Configuration.HMSDBConnectionString));
                options.EnableSensitiveDataLogging();
            });

            return services;

        }
    }
}
