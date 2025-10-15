namespace Entities.JsonModels.Job
{
    public class PerformanceRating
    {
        public int TechnicalSkills { get; set; }
        public int Communication { get; set; }
        public int ExperienceLevel { get; set; }
        public int CultutralFit { get; set; }
        public int OverallAssessment { get; set; }
    }

    public class DetailedFeedback
    {
        public string? GeneralComments { get; set; }
        public string? KeyStrengths { get; set; }
        public string? AreasForImprovement { get; set; }
        public string? AddtionalInterviewerNotes { get; set; }
    }

    public class Recommendation
    {
        public string? HiringRecommendation { get; set; }
        public string? ReommendedNextSteps { get; set; }
    }

    public class InterviewFeedback
    {
        public PerformanceRating? PerformanceRating { get; set; }
        public DetailedFeedback? DetailedFeedback { get; set; }
        public Recommendation? Recommendation { get; set; }
    }
}
