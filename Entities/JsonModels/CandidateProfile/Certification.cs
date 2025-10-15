namespace Entities.JsonModels.CandidateProfile
{
    public class Certification
    {
        public string? Name { get; set; }
        public string? IssuingOrganization { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? CredentialId { get; set; }
        public string? VerificationUrl { get; set; }
        public string? Description { get; set; }
        public List<string>? RelatedSkills { get; set; }
    }
}