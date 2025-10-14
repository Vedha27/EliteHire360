using System.ComponentModel.DataAnnotations;

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
    }
}
