namespace Entities.JsonModels.CandidateProfile
{
    public class Experience
    {
        public string? Title { get; set; }
        public string? CompanyName { get; set; }
        public string? EmploymentType { get; set; }
        public string? Location { get; set; }
        public string? Industry { get; set; }
        public EmploymentPeriod? EmploymentPeriod { get; set; }
        public RoleDescription? RoleDescription { get; set; }
        public List<string>? KeyAchievements { get; set; }
        public List<string>? SkillsUsed { get; set; }
    }
}