using eShop.Domain.Base;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Users
{
    public class UserRole : AuditableEntity<int>, ILocalizedName
    {
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }
    }
}
