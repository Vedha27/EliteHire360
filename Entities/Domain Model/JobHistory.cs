using Entities.MetaModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class JobHistory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }
        [ForeignKey("Status")]
        public int JobStatusId { get; set; }
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime CreateAt { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
