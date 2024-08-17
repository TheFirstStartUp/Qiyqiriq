using eShop.Domain.Base;
using eShop.Domain.Enums;

namespace eShop.Domain.Enitities
{
    public class Price : AuditableEntity<int>
    {
        public decimal Value { get; set; }
        public bool IsActive { get; set; }
        public EPriceType Type { get; set; }
        public EEntityState EEntityState { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
