using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;
namespace Entities.MetaModels
{
    public class PriorityLevel
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        [MaxLength(20)]
        public string Description { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }

        // Navigation property: CreatedBy User
        [ForeignKey("CreatedBy")]
        public virtual User? CreatedByUser { get; set; }
    }
}
