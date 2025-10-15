namespace Entities.JsonModels.Organization
{
    public class OfficeInfo
    {
        public string? OfficeName { get; set; }
        public string? OfficeType { get; set; }
        public string? Description { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? ZipPostalCode { get; set; }
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? TotalCapacity { get; set; }
        public string? CurrentEmployees { get; set; }
        public string? WorkingHoursStart { get; set; }
        public string? WorkingHoursEnd { get; set; }
        public List<string>? QuickAdd { get; set; }
    }
}