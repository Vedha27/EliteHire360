using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class StatusCategories
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string StatusCategoryName { get; set; } = null!;
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
