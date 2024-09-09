using eShop.Domain.Base;
using eShop.Domain.Enums;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Organizations
{
    public class OrganizationFounder : AuditableEntity<int>, ISoftDeletable
    {
        public long OrganizationId { get; set; }
        public string FounderPinflOrTin { get; set; }
        public Guid FileId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
