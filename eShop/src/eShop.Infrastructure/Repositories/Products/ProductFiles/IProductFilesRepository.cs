using eShop.Domain.Enitities.Products;
using eShop.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.Infrastructure.Repositories.Products.ProductFiles
{
    public interface IProductFilesRepository : IBaseRepository<ProductFile>
    {
    }
}
