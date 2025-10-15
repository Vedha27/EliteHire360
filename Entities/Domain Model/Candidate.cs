using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Collections.Generic;
using Entities.JsonModels.CandidateProfile;
using System.Text.Json;

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

        [NotMapped]
        public CandidateProfile? CandidateProfile { get; set; }

        [Column("Candidate_profile", TypeName = "jsonb")]
        public string? CandidateProfileJson
        {
            get =>JsonSerializer.Serialize(CandidateProfile);
            set => CandidateProfile = string.IsNullOrWhiteSpace(value)
                ? new CandidateProfile()
                : JsonSerializer.Deserialize<CandidateProfile>(value);
        }

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
