using eShop.Domain.Base;

namespace eShop.Domain.Enitities.Products
{
    public class Comment : BaseEntity<int>
    {
        public string Text { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
