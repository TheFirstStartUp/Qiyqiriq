using eShop.Domain.Base;

namespace eShop.Domain.Enitities.Orders
{
    public class OrderItem : AuditableEntity<int>
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
