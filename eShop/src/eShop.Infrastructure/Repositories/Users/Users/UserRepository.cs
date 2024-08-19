using eShop.Domain.Enitities;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Users.Users
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
