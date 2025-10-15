using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class OrganisationTeam
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [MaxLength(55)]
        public string FirstName { get; set; } = null!;
        [MaxLength(40)]
        public string LastName { get; set; } = null!;
        [MaxLength(55)]
        public string Email { get; set; } = null!;

        [ForeignKey("SubRole")]
        public int SubRoleId { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [MaxLength(55)]
        public string? Message { get; set; }
        public DateTime CreatedOn { get; set; }
        [ForeignKey("User")]
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        [ForeignKey("User")]
        public int? UpdatedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
