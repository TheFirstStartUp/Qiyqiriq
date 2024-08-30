using eShop.Admin.API.Middlewares;

namespace eShop.Admin.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IApplicationBuilder UseLocalization(this IApplicationBuilder builder)
            => builder.UseMiddleware<LocalizationMiddleware>();

        public static IApplicationBuilder UseGlobalExceptionHandler(this IApplicationBuilder builder)
            => builder.UseMiddleware<GlobalExceptionHandlerMiddleware>();
    }
}
