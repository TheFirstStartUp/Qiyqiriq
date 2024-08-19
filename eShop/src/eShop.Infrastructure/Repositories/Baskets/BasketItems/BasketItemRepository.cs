using eShop.Domain.Enitities.Baskets;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;

namespace eShop.Infrastructure.Repositories.Baskets.BasketItems
{
    public class BasketItemRepository : BaseRepository<BasketItem>, IBasketItemRepository
    {
        public BasketItemRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
