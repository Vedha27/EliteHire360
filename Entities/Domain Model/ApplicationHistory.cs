using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class ApplicationHistory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid UniqueKey { get; set; }

        [ForeignKey("Application")]
        public int ApplicationId { get; set; }
        
        public int StatusId { get; set; }
        
        public DateTime CreatedAt { get; set; }
        
        public int CreatedBy { get; set; }

        public virtual Application Application { get; set; } = null!;
    }
}
