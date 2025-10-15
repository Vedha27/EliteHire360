namespace Entities.JsonModels.CandidateProfile
{
    public class Project
    {
        public string? ProjectName { get; set; }
        public string? ProjectCategory { get; set; }
        public string? ProjectDescription { get; set; }
        public List<string>? TechnologiesUsed { get; set; }
        public string? SourceCodeUrl { get; set; }
        public string? LiveDemoUrl { get; set; }
        public ProjectStatusAndTimeline? ProjectStatusAndTimeline { get; set; }
        public AdditionalDetails? AdditionalDetails { get; set; }
    }
}