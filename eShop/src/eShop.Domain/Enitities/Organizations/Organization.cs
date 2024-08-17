using eShop.Domain.Base;
using eShop.Domain.Enums;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Organizations
{
    public class Organization : AuditableEntity<int>, ILocalizedName
    {
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public long? DistrictId { get; set; }
        public string OwnerFullName { get; set; }
        public string OrganizationTIN { get; set; }
        public string OrganizationOwnerPINFL { get; set; }
        public string LogoUrl { get; set; }
        public string Address { get; set; }
        public string AccountantFullName { get; set; }
        public string AccountantPINFL { get; set; }
        public virtual List<OrganizationFounder> Founders { get; set; }
        public virtual List<OrganizationFile> Files { get; set; }
        public virtual OrganizationContact Contact { get; set; }
        public Region Region { get; set; }
        public List<long> ServiceRegionIds { get; set; }
        public EOrganizationType Type { get; set; }
    }
}
