using eShop.Domain.Enitities.Orders;
using eShop.Infrastructure.Repositories.Base;

namespace eShop.Infrastructure.Repositories.Orders.Orders
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
    }
}
