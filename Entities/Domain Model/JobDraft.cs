using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.JsonModels;

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
        public InterviewProcess? InterviewRounds { get; set; }
        public int? LocationId { get; set; }
        public int? EmpType { get; set; }
        public int? OrganisationId { get; set; }
        public int? WorkMode { get; set; }
        public long? MinSalary { get; set; }
        public long? MaxSalary { get; set; }
        public JobDescription? JobDesc { get; set; }
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
