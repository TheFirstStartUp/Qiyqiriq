using eShop.Domain.Enitities.Organizations;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Organizations.OrganizationFiles
{
    public class OrganizationFileRepository : BaseRepository<OrganizationFile>, IOrganizationFileRepository
    {
        public OrganizationFileRepository(DbContext context) : base(context)
        {
        }
    }
}
