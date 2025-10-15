using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;
using System.Collections.Generic;
using Entities.MetaModels;
using System.Text.Json;
using Entities.JsonModels.Job;

namespace Entities
{
    public class Job
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [MaxLength(30)]
        public string JobTitle { get; set; } = null!;

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

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("OfficeLoc")]
        public int LocationId { get; set; }
        [ForeignKey("EmploymentType")]
        public int EmpType { get; set; }
        [ForeignKey("Organisation")]
        public int OrganisationId { get; set; }
        [ForeignKey("WorkMode")]
        public int WorkMode { get; set; }
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

        [ForeignKey("Status")]
        public int JobStatusId { get; set; }
        [ForeignKey("ExperienceLevel")]
        public int ExperienceLevelId { get; set; }
        [ForeignKey("PriorityLevel")]
        public int PriorityLevel { get; set; }
        public DateTime? JobDeadline { get; set; }
        public DateTime CreatedOn { get; set; }
        [MaxLength(100)]
        public string CreatedBy { get; set; } = null!;
        public DateTime? UpdatedOn { get; set; }
        [MaxLength(100)]
        public string? UpdatedBy { get; set; }

        public virtual Organisation Organisation { get; set; } = null!;
        public virtual Department Department { get; set; } = null!;
        public virtual EmploymentType EmploymentType { get; set; } = null!;
        public virtual ExperienceLevel ExperienceLevel { get; set; } = null!;
        public virtual PriorityLevel PriorityLevelNavigation { get; set; } = null!;
        public virtual ICollection<Application> Applications { get; set; } = new List<Application>();
    }
}
