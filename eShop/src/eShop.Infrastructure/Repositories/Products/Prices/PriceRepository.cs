using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;

namespace eShop.Infrastructure.Repositories.Products.Prices
{
    public class PriceRepository : BaseRepository<Price>, IPriceRepository
    {
        public PriceRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
