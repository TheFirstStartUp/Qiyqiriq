using eShop.API.Middlewares;

namespace eShop.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IApplicationBuilder UseLocalization(this IApplicationBuilder builder)
            => builder.UseMiddleware<LocalizationMiddleware>();

        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder builder)
            => builder.UseMiddleware<GlobalExceptionHandlerMiddleware>();
    }
}
