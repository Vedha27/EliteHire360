using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.MetaModels
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        [MaxLength(50)]
        public string StatusName { get; set; } = null!;
        [ForeignKey(nameof(StatusCategory))]
        public int StatusCategoryId { get; set; }
        public int CreatedBy { get; set; }

        public virtual StatusCategory StatusCategory { get; set; } = null!;
    }
}
