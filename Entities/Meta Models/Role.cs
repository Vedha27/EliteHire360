using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
