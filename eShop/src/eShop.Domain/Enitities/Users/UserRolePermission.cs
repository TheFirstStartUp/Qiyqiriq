namespace eShop.Domain.Enitities.Users
{
    public class UserRolePermission
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public UserPermission Permission { get; set; }
        public UserRole Role { get; set; }
    }
}
