using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class InterviewFormat
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
