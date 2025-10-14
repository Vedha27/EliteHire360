using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class InterviewReschedulingReason
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Reason { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
    }
}
