using eShop.Domain.Base;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Organizations
{
    public class OrganizationContact : AuditableEntity<int>, ISoftDeletable
    {
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int? OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public bool IsDeleted { get; set; }
    }
}
