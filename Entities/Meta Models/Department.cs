using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        [MaxLength(20)]
        public string DeptName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
