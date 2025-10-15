using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [MaxLength(20)]
        public string DeptName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property: CreatedBy User
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }

        // Navigation property: Jobs in this Department
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
