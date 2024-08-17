using eShop.Domain.Base;
using eShop.Domain.Enums;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Regions
{
    public class Region : AuditableEntity<int>, ILocalizedName
    {
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public int? ParentId { get; set; }
        public Region Parent { get; set; }

        public ERegionType RegionType { get; set; }
    }
}
