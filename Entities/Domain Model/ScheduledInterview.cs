using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels.Job;
using System.Text.Json;

namespace Entities
{
    public class ScheduledInterview
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        public int? ParentInterviewId { get; set; }
        [ForeignKey("InterviewFormat")]
        public int InterviewFormat { get; set; }
        [MaxLength(20)]
        public string InterviewMode { get; set; } = null!;
        public DateTime ScheduledDate { get; set; }
        public DateTime StartTime { get; set; }
        public int Duration { get; set; }
        [MaxLength(40)]
        public string Status { get; set; } = null!;
        [NotMapped]
        public InterviewFeedback? InterviewFeedback { get; set; }
        [Column("interviewFeedback", TypeName = "json")]
        public string? InterviewFeedbackJson
        {
            get => InterviewFeedback == null ? null : JsonSerializer.Serialize(InterviewFeedback);
            set => InterviewFeedback = string.IsNullOrWhiteSpace(value)
                ? new InterviewFeedback()
                : JsonSerializer.Deserialize<InterviewFeedback>(value);
        }
        [MaxLength(55)]
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Application Application { get; set; } = null!;

        // Navigation property for ScheduledInterviewHistory
        public virtual ICollection<ScheduledInterviewHistory> ScheduledInterviewHistories { get; set; } = new List<ScheduledInterviewHistory>();
    }
}
