namespace eShop.Domain.Enums
{
    public enum OrderState
    {
        Pending,        // Buyurtma tasdiqlanishini kutmoqda
        Processing,     // Buyurtma ko‘rib chiqilmoqda
        Shipped,        // Buyurtma yetkazib berildi
        Delivered,      // Buyurtma yetkazildi
        Canceled,       // Buyurtma bekor qilindi
        Returned        // Buyurtma qaytarildipublic int Id { get; set; }
    }
}
