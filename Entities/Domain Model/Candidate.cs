using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Collections.Generic;

namespace Entities
{
    public class Candidate
    {
        [Key]
        public int CandidateId { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [MaxLength(55)]
        public string? ResumePath { get; set; }
        public int? OverallExperience { get; set; }
        public MyProfile? Profile { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<SavedJob> SavedJobs { get; set; } = new List<SavedJob>();
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
