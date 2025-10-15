using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
        [MaxLength(50)]
        public string SkillName { get; set; } = null!;

        [ForeignKey("SkillCategory")] 
        public int SkillCategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
