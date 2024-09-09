using eShop.Domain.Base;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Products
{
    public class Comment : BaseEntity<int>, ISoftDeletable
    {
        public string Text { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
        public bool IsDeleted { get; set; }
    }
}
