using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Entities.JsonModels;
using Entities.JsonModels.Organization;
using System.Text.Json;

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

        [NotMapped]
        public CompanyOverview? Overview { get; set; }
        [Column("overview", TypeName = "jsonb")]
        public string? OverviewJson
        {
            get => Overview == null ? null : JsonSerializer.Serialize(Overview);
            set => Overview = string.IsNullOrWhiteSpace(value)
                ? new CompanyOverview()
                : JsonSerializer.Deserialize<CompanyOverview>(value);
        }

        [NotMapped]
        public CompanyCulture? Culture { get; set; }
        [Column("culture", TypeName = "jsonb")]
        public string? CultureJson
        {
            get => Culture == null ? null : JsonSerializer.Serialize(Culture);
            set => Culture = string.IsNullOrWhiteSpace(value)
                ? new CompanyCulture()
                : JsonSerializer.Deserialize<CompanyCulture>(value);
        }

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
