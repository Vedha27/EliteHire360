using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels;
using Entities.JsonModels.Organization;

namespace Entities
{
    public class Organisation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [MaxLength(55)]
        public string Name { get; set; } = null!;
        [MaxLength(55)]
        public string? Insudstry { get; set; }
        public CompanyOverview? Overview { get; set; }
        public CompanyCulture? Culture { get; set; }
        [MaxLength(55)]
        public string? Benefit { get; set; }
        [ForeignKey("OfficeLoc")]
        public int OfficeLocId { get; set; }
        public int OrganizationStatus { get; set; }
        public DateTime CreatedOn { get; set; }
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [ForeignKey("User")]
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        public virtual OfficeLoc OfficeLoc { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
