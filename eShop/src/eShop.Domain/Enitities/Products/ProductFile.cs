using eShop.Domain.Base;
using eShop.Domain.Interfaces;

namespace eShop.Domain.Enitities.Products
{
    public class ProductFile : AuditableEntity<int>, ISoftDeletable
    {
        public string FileName { get; set; }
        public string FileType { get; set; }           // Fayl turi (masalan, "image/jpeg", "application/pdf")
        public string FileUrl { get; set; }            // Fayl URL manzili
        public long FileSize { get; set; }             // Fayl hajmi (baytlarda)
        public bool IsPrimary { get; set; }            // Asosiy fayl (masalan, asosiy rasmmi yoki yo'qmi)
        public bool IsVisible { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public bool IsDeleted { get; set; }
    }
}
