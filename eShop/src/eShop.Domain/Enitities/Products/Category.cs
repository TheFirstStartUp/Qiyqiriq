using eShop.Domain.Base;
using eShop.Domain.Interfaces;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities.Products
{
    public class Category : BaseEntity<int>, ILocalizedName, ISoftDeletable
    {
        //names
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public int? ParentId { get; set; }
        public Category Parent { get; set; }

        public ICollection<Category> Children { get; set; } = new List<Category>();
        public bool IsDeleted { get; set; }
    }
}
