using System.Text.Json;

namespace eShop.Admin.API.Middlewares
{
    public class GlobalExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public GlobalExceptionHandlerMiddleware(RequestDelegate next)
            => _next = next;

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await ReturnErrorMessage(httpContext);
            }
        }

        private static async Task ReturnErrorMessage(HttpContext httpContext)
        {
            var response = httpContext.Response;
            response.ContentType = "application/json";
            response.StatusCode = StatusCodes.Status500InternalServerError;
            var result = JsonSerializer.Serialize(new
            {
                code = StatusCodes.Status500InternalServerError,
                message = "Internal server error."
            });

            await response.WriteAsync(result);
        }
    }
}
