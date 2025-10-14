using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ScheduledInterviewHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("ScheduledInterview")]
        public int InterviewId { get; set; }
        [ForeignKey("Status")]
        public int InterviwStatusId { get; set; }
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual ScheduledInterview ScheduledInterview { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
