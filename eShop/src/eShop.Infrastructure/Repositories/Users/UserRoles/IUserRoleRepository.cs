using eShop.Domain.Enitities.Users;
using eShop.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Repositories.Users.UserRoles
{
    public interface IUserRoleRepository : IBaseRepository<UserRole>
    {
    }
}
