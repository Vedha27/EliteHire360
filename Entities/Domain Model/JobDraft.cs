using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Text.Json;

namespace Entities
{
    public class JobDraft
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        public string? JobTitle { get; set; }
        public int? DepartmentId { get; set; }

        [NotMapped]
        public List<InterviewRound>? InterviewProcess { get; set; } = new List<InterviewRound>();
        [Column("interviewProcess", TypeName = "jsonb")]
        public string? InterviewProcessJson
        {
            get => InterviewProcess == null ? null : JsonSerializer.Serialize(InterviewProcess);
            set => InterviewProcess = string.IsNullOrWhiteSpace(value)
                ? new List<InterviewRound>()
                : JsonSerializer.Deserialize<List<InterviewRound>>(value);
        }

        public int? LocationId { get; set; }
        public int? EmpType { get; set; }
        public int? OrganisationId { get; set; }
        public int? WorkMode { get; set; }
        public long? MinSalary { get; set; }
        public long? MaxSalary { get; set; }

        [NotMapped]
        public JobDescription? JobDesc { get; set; }
        [Column("jobDesc", TypeName = "json")]
        public string? JobDescJson
        {
            get => JobDesc == null ? null : JsonSerializer.Serialize(JobDesc);
            set => JobDesc = string.IsNullOrWhiteSpace(value)
                ? new JobDescription()
                : JsonSerializer.Deserialize<JobDescription>(value);
        }

        public int? JobStatusId { get; set; }
        public int? ExperienceLevelId { get; set; }
        public int? PriorityLevel { get; set; }
        public DateTime? JobDeadline { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public string? UpdatedBy { get; set; }

        public virtual Job Job { get; set; } = null!;
    }
}
