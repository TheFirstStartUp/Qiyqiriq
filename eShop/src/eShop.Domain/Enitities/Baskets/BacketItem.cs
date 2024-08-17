using eShop.Domain.Base;
using eShop.Domain.Enitities.Products;

namespace eShop.Domain.Enitities.Baskets
{
    public class BasketItem : BaseEntity<int>
    {
        public int Quantity { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }

        public virtual Basket Basket { get; set; }
        public virtual Product Product { get; set; }
    }
}
