using System.ComponentModel.DataAnnotations;

namespace Entities.MetaModels
{
    public class SubRole
    {
        [Key]
        public int SubRoleId { get; set; }
        public int PermissionId { get; set; }
        [MaxLength(30)]
        public string SubRoleName { get; set; } = null!;
        [MaxLength(256)]
        public string RoleDesc { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
