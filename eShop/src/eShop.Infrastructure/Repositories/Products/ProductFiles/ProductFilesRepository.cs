using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Repositories.Products.ProductFiles
{
    public class ProductFilesRepository : BaseRepository<ProductFile>, IProductFilesRepository
    {
        public ProductFilesRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
