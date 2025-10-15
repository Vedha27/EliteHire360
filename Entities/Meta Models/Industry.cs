using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Entities.MetaModels
{
    public class Industry
    {
        [Key]
        public int IndustryId { get; set; }
        [MaxLength(50)]
        public string IndustryName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation property: CreatedBy User
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }
    }
}
