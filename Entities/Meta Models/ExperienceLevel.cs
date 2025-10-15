using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    public class ExperienceLevel
    {
        [Key]
        public int ExpId { get; set; }
        [MaxLength(50)]
        public string ExpLevel { get; set; } = null!;
        [MaxLength(50)]
        public string ExpDesc { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        // Navigation property: CreatedBy User
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }
    }
}
