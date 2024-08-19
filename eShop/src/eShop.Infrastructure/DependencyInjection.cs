﻿using eShop.Infrastructure.Context;
using eShop.Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<eShopDbContext>(options
                => options.UseNpgsql(configuration.GetConnectionString("PosgresDb")));

            services.AddRepositoriesFromAssembly();

            return services;
        }
    }
}