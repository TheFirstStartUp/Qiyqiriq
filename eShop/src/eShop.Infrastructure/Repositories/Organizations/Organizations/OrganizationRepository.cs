using eShop.Domain.Enitities.Organizations;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Organizations.Organizations
{
    public class OrganizationRepository : BaseRepository<Organization>, IOrganizationContactRepository
    {
        public OrganizationRepository(DbContext context) : base(context)
        {
        }
    }
}
