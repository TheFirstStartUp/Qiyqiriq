using Microsoft.AspNetCore.Http;

namespace eShop.Application.Halpers
{
    public class UrlProvider : IUrlProvider
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UrlProvider(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public string GetAbsoluteUrl(string relativeUrl)
        {
            var baseUrl = new Uri($"https://{_contextAccessor.HttpContext.Request.Host}");
            return new Uri(baseUrl, relativeUrl).AbsoluteUri;
        }
    }
}
