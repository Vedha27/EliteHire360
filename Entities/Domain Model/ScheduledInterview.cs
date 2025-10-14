using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [MaxLength(40)]
        public string? FeedBack { get; set; }
        [MaxLength(55)]
        public string? Location { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Application Application { get; set; } = null!;
    }
}
