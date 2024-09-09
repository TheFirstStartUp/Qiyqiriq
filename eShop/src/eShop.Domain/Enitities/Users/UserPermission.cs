using eShop.Domain.Base;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Users
{
    public class UserPermission : BaseEntity<int>, ISoftDeletable
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<UserRole> Roles { get; set; }
    }
}
