namespace eShop.Application.DataTransferObjects.Categories
{
    public record CategoryCreationDTO
    (
        string NameUz,
        string NameRu,
        string NameEn,

        int? ParentId
    );
}
