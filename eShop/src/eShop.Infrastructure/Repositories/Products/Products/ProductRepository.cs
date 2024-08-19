using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Context;
using eShop.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Repositories.Products.Products
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(eShopDbContext context) : base(context)
        {
        }
    }
}
