namespace Entities.JsonModels.Job
{
    public class Screening
    {
        public string? ScreeningType { get; set; }
        public string? AssignTo { get; set; }
        public string? PriorityLevel { get; set; }
        public string? SchedulingPreference { get; set; }
        public string? AdditionalNotes { get; set; }
    }
}