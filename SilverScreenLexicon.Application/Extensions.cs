﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace SilverScreenLexicon.Application;

public static class Extensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}