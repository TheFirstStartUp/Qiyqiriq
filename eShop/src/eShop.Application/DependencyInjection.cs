using eShop.Application.Services.Categories;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();

            services.AddScoped<ICategoryService, CategoryService>();

            return services;
        }
    }
}
