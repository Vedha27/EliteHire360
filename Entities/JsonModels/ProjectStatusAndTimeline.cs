namespace Entities.JsonModels
{
    public class ProjectStatusAndTimeline
    {
        public string? Status { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public List<string>? KeyFeatures { get; set; }
    }
}