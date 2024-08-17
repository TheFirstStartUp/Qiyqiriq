using eShop.Domain.Base;

namespace eShop.Domain.Enitities.Users
{
    public class UserPermission : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
