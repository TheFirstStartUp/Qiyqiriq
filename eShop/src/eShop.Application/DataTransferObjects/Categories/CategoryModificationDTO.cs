namespace eShop.Application.DataTransferObjects.Categories
{
    public record CategoryModificationDTO
    (
        string NameUz,
        string NameRu,
        string NameEn,

        int? ParentId
    );
}
