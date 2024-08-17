using eShop.Domain.Base;
using eShop.Domain.Enums;
using eShop.Domain.Localizations;

namespace eShop.Domain.Enitities
{
    public class Product : AuditableEntity<int>, ILocalizedName, ILocalizedDescription
    {
        //names
        public string NameUz { get; set; }
        public string NameRu { get; set; }
        public string NameEn { get; set; }

        //descriptions
        public string DescriptionUz { get; set; }
        public string DescriptionRu { get; set; }
        public string DescriptionEn { get; set; }

        public EEntityState EEntityState { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Price> Prices { get; set; }
        public virtual ICollection<ProductFile> ProductFiles { get; set; }
    }
}
