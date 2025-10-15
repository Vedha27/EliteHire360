using Entities.MetaModels;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class UserRoleMapping
    {
        [Key]
        public int UserRoleMappingId { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        [ForeignKey("SubRole")]
        public int SubroleId { get; set; }
        public int CreatedBy { get; set; }
        public int? DeletedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual Role Role { get; set; } = null!;
        public virtual SubRole SubRole { get; set; } = null!;
    }
}
