using eShop.Domain.Base;

namespace eShop.Domain.Enitities.Baskets
{
    public class Basket : AuditableEntity<int>
    {
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<BasketItem> Items { get; set; }
    }
}
