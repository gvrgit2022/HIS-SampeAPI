using MediatR;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using FluentValidation;
using SampleAPI.Application.Common.PipelineBehaviors;

namespace SampleAPI.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(typeof(DependencyInjection));
            services.AddAutoMapper(typeof(DependencyInjection));
            services.AddValidatorsFromAssemblyContaining(typeof(DependencyInjection));
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
            return services;
        }
    }
}
