using eShop.Domain.Enitities.Users;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Users.UserPermissions
{
    public class UserPermissionRepository : BaseRepository<UserPermission>, IUserPermissionRepository
    {
        public UserPermissionRepository(DbContext context) : base(context)
        {
        }
    }
}
