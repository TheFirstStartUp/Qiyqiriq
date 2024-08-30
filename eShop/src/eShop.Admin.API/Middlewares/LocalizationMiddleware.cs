using System.Globalization;

namespace eShop.Admin.API.Middlewares
{
    public class LocalizationMiddleware
    {
        private static readonly Dictionary<string, string> Langs = new Dictionary<string, string>()
        {
            {"uz", "uz-UZ"},
            {"ru", "ru-RU"},
            {"en", "en-US"}
        };

        public const string LanguageKey = "Language";
        private readonly RequestDelegate _next;

        public LocalizationMiddleware(RequestDelegate next)
            => _next = next;

        public async Task Invoke(HttpContext context)
        {
            BeginInvoke(context);
            await _next.Invoke(context);
        }

        private void BeginInvoke(HttpContext context)
        {
            var headers = context.Request.Headers;
            var language = headers.FirstOrDefault(f => f.Key.ToLower() == LanguageKey.ToLower());

            var languageName = language.Value.FirstOrDefault();
            var current = CultureInfo.GetCultureInfo(Langs.GetValueOrDefault("ru"));

            if (languageName != null)
            {
                languageName = Langs.GetValueOrDefault(languageName) ?? "uz-UZ";
                current = CultureInfo.GetCultureInfo(languageName);
            }

            CultureInfo.CurrentCulture = current;
            CultureInfo.CurrentUICulture = current;
        }
    }
}
