﻿namespace eShop.Domain.Enitities.Organizations
{
    public class OrganizationFile
    {
        public string FileName { get; set; }
        public string FileType { get; set; }           // Fayl turi (masalan, "image/jpeg", "application/pdf")
        public string FileUrl { get; set; }            // Fayl URL manzili
        public long FileSize { get; set; }             // Fayl hajmi (baytlarda)
        public bool IsPrimary { get; set; }            // Asosiy fayl (masalan, asosiy rasmmi yoki yo'qmi)
        public bool IsVisible { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; }
    }
}