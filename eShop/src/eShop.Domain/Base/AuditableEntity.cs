namespace eShop.Domain.Base
{
    public class AuditableEntity<T> : BaseEntity<T>
    {
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
    }
}
