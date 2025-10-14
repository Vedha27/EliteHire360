using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string StatusName { get; set; } = null!;
        public int StatusCategory { get; set; }
        public int CreatedBy { get; set; }
    }
}
