using eShop.Domain.Base;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities
{
    public class Category : BaseEntity<int>, ILocalizedName
    {
        //names
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        public int ParentId { get; set; }
        public virtual Category Parent { get; set; }

        public virtual ICollection<Category> Childrens { get; set; }
    }
}
