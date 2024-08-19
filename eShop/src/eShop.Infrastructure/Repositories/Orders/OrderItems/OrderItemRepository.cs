using eShop.Domain.Enitities.Orders;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;

namespace eShop.Infrastructure.Repositories.Orders.OrderItems
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
