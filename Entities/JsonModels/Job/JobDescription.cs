namespace Entities.JsonModels.Job
{
    public class JobDescription
    {
        public string? Description { get; set; }
        public List<string>? RequiredSkills { get; set; }
        public List<string>? JobRequirements { get; set; }
    }
}