using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string SkillName { get; set; } = null!;
        public int CategoryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
