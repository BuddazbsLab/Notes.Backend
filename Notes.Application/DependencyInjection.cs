﻿

using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using FluentValidation;

namespace Notes.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblies(new[] {Assembly.GetExecutingAssembly()});
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(IPipelineBehavior<,>));
            return services;
        }
    }
}
