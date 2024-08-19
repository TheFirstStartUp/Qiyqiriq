using eShop.Domain.Enitities.Organizations;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Organizations.OrganizationContacts
{
    public class OrganizationContractRepository : BaseRepository<OrganizationContact>, IOrganizationContactRepository
    {
        public OrganizationContractRepository(DbContext context) : base(context)
        {
        }
    }
}
