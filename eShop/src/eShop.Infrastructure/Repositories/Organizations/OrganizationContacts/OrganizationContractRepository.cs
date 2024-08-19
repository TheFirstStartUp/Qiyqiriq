using eShop.Domain.Enitities.Organizations;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Organizations.OrganizationContacts
{
    public class OrganizationContractRepository : BaseRepository<OrganizationContact>, IOrganizationContactRepository
    {
        public OrganizationContractRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
