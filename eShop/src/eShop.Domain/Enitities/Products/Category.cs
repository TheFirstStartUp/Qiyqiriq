using eShop.Domain.Base;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Products
{
    public class Category : BaseEntity<int>, ILocalizedName
    {
        //names
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public int? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; } = new List<Category>();
    }
}
