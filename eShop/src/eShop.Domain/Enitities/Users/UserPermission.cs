using eShop.Domain.Base;

namespace eShop.Domain.Enitities.Users
{
    public class UserPermission : BaseEntity<int>
    {
        public string Name { get; set; }

        public virtual ICollection<UserRole> Roles { get; set; }
    }
}
