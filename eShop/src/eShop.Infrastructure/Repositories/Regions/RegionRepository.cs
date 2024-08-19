using eShop.Domain.Enitities.Regions;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace eShop.Infrastructure.Repositories.Regions
{
    public class RegionRepository : BaseRepository<Region>, IRegionRepository
    {
        public RegionRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
