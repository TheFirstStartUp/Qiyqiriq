using eShop.Domain.Base;
using eShop.Domain.Enums;

namespace eShop.Domain.Enitities.Organizations
{
    public class OrganizationFounder : AuditableEntity<int>
    {
        public long OrganizationId { get; set; }
        public string FounderPinflOrTin { get; set; }
        public Guid FileId { get; set; }
        public EEntityState EEntityState { get; set; }
    }
}
