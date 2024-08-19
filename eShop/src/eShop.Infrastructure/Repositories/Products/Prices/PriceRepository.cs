using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Repositories.Products.Prices
{
    public class PriceRepository : BaseRepository<Price>, IPriceRepository
    {
        public PriceRepository(DbContext context) : base(context)
        {
        }
    }
}
