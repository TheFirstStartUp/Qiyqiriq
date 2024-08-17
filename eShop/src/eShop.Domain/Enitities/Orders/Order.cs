using eShop.Domain.Base;
using eShop.Domain.Enitities.Organizations;
using eShop.Domain.Enitities.Regions;
using eShop.Domain.Enums;

namespace eShop.Domain.Enitities.Orders
{
    public class Order : AuditableEntity<int>
    {
        public OrderState OrderState { get; set; }
        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public decimal Price { get; set; }
        public decimal Payamount { get; set; }
        public int? RegionId { get; set; }
        public Region Region { get; set; }
        public int? DistrictId { get; set; }
        public Region District { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
    }
}
