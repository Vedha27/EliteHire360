using Entities.JsonModels;
using Entities.JsonModels.CandidateProfile;
using Entities.MetaModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Entities
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }

        public Screening? Screening { get; set; }

        public int? IsOfferSent { get; set; }

        public int? IsOfferAccepted { get; set; }

        public PersonInformation? PersonInfo { get; set; }

        [NotMapped]
        public ExperienceAndBackground? ExperienceAndBackground { get; set; }

        [Column(TypeName = "jsonb")]
        public string? ExperienceAndBackgroundJson
        {
            get => ExperienceAndBackground == null ? null : JsonSerializer.Serialize(ExperienceAndBackground);
            set => ExperienceAndBackground = string.IsNullOrWhiteSpace(value)
                ? new ExperienceAndBackground()
                : JsonSerializer.Deserialize<ExperienceAndBackground>(value);
        }

        [MaxLength(55)]
        public string? ResumePath { get; set; }
        public int? MatchPercentage { get; set; }
        public DateTime AppliedAt { get; set; }
        [ForeignKey("Status")]
        public int ApplicationStatusId { get; set; }

        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Candidate Candidate { get; set; } = null!;
        public virtual Job Job { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual ICollection<ApplicationHistory> ApplicationHistories { get; set; } = new List<ApplicationHistory>();
        public virtual ICollection<ScheduledInterview> ScheduledInterviews { get; set; } = new List<ScheduledInterview>();
    }
}
