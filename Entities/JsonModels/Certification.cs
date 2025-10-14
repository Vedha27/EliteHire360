namespace Entities.JsonModels
{
    public class Certification
    {
        public string? Name { get; set; }
        public string? IssuingOrganization { get; set; }
        public string? IssueDate { get; set; }
        public string? ExpiryDate { get; set; }
        public string? CredentialId { get; set; }
        public string? VerificationUrl { get; set; }
        public string? Description { get; set; }
        public List<string>? RelatedSkills { get; set; }
    }
}