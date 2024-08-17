namespace eShop.Application.Halpers
{
    public interface IUrlProvider
    {
        string GetAbsoluteUrl(string relativeUrl);
    }
}
