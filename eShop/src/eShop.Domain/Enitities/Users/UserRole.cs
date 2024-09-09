using eShop.Domain.Base;
using eShop.Domain.Interfaces;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Users
{
    public class UserRole : AuditableEntity<int>, ILocalizedName, ISoftDeletable
    {
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public virtual ICollection<UserPermission> Permissions { get; set; }
        public bool IsDeleted { get; set; }
    }
}
