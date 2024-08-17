using eShop.Domain.Base;
using eShop.Domain.Enitities.Organizations;
using eShop.Domain.Enitities.Users;
using eShop.Domain.Enums;

namespace eShop.Domain.Enitities
{
    public class User : AuditableEntity<int>
    {
        public string HashPassword { get; set; }
        public string Salt { get; set; }
        public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Inn { get; set; }
        public string Pinfl { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? PassportIssueDate { get; set; }
        public DateTime? PassportExpireDate { get; set; }
        public string PassportWhomGiven { get; set; }
        public DateTime? BirthDate { get; set; }
        public long? DistrictId { get; set; }
        public long? RegionId { get; set; }
        public string CountryOfBirth { get; set; }
        public string CityOfBirth { get; set; }
        public string CountryOfResidence { get; set; }
        public string CityOfResidence { get; set; }
        public string Address { get; set; }
        public string TemporarilyAddress { get; set; }
        public EGender Gender { get; set; }
        public EUserFamilyStatus UserFamilyStatus { get; set; }

        public EUserType? UserType { get; set; }

        public long? OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }

        public string DefaultPassword { get; set; }

        public long? UserOtpId { get; set; }
        public long RoleId { get; set; } = 1;

        public UserRole Role { get; set; }
    }
}
