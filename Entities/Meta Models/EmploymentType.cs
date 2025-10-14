using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class EmploymentType
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
