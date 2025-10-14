namespace Entities.JsonModels
{
    public class Education
    {
        public string? SchoolOrCollegeName { get; set; }
        public string? Location { get; set; }
        public string? Degree { get; set; }
        public string? FieldOfStudy { get; set; }
        public string? DegreeType { get; set; }
        public string? DegreeStatus { get; set; }
        public TimelineAndPerformance? TimelineAndPerformance { get; set; }
        public List<string>? RelevantCourseWork { get; set; }
        public string? Description { get; set; }
        public List<string>? ActivitiesAndOrganizations { get; set; }
        public List<string>? AcademicAchievements { get; set; }
    }
}