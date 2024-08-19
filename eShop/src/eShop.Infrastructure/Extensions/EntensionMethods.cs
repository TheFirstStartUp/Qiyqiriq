using eShop.Infrastructure.Repositories.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace eShop.Infrastructure.Extensions
{
    public static class EntensionMethods
    {
        public static IServiceCollection AddRepositoriesFromAssembly(this IServiceCollection services) 
        {
             var repositoryTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => t.IsClass
                        && !t.IsAbstract
                        && t.GetInterfaces().Any(i => i.IsGenericType 
                                                   && i.GetGenericTypeDefinition() == typeof(IBaseRepository<>)));

            foreach (var implementation in repositoryTypes)
            {
                var interfaceType = implementation.GetInterfaces().First(i => i.IsGenericType 
                                                                           && i.GetGenericTypeDefinition() == typeof(IBaseRepository<>));
                services.AddScoped(interfaceType, implementation);
            }

            return services;
        }
    }
}
