using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels.Organization;
using System.Text.Json;

namespace Entities
{
    public class OfficeLoc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [ForeignKey("Organisation")]
        public int OrgId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = null!;

        [NotMapped]
        public OfficeInfo? OfficeInfo { get; set; }

        [Column("officeInfo", TypeName = "json")]
        public string? OfficeInfoJson
        {
            get => OfficeInfo == null ? null : JsonSerializer.Serialize(OfficeInfo);
            set => OfficeInfo = string.IsNullOrWhiteSpace(value)
                ? new OfficeInfo()
                : JsonSerializer.Deserialize<OfficeInfo>(value);
        }

        public DateTime CreatedOn { get; set; }
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [ForeignKey("User")]
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual Organisation Organisation { get; set; } = null!;
        public virtual User User { get; set; } = null!;

        // Navigation property: Jobs in this Office Location
        public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();
    }
}
