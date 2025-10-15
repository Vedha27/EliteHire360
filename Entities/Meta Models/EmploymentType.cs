using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    public class EmploymentType
    {
        [Key]
        public int EmploymentTypeId { get; set; }

        [MaxLength(50)]
        public string EmploymentTypeName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }

        // Navigation property: CreatedBy User
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }
    }
}
