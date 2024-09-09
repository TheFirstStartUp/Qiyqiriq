using eShop.Domain.Base;
using eShop.Domain.Enums;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Products
{
    public class Price : AuditableEntity<int>, ISoftDeletable
    {
        public decimal Value { get; set; }
        public bool IsActive { get; set; }
        public EPriceType Type { get; set; }
        public EEntityState EEntityState { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public bool IsDeleted { get; set; }
    }
}
