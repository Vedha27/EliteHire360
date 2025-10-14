using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class ProjectCategory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
