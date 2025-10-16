using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public Guid UniqueKey { get; set; }
        [MaxLength(55)]
        public string FirstName { get; set; } = null!;
        [MaxLength(40)]
        public string LastName { get; set; } = null!;
        [MaxLength(20)]
        public string Phone { get; set; } = null!;
        [MaxLength(55)]
        public string Email { get; set; } = null!;
        [MaxLength(55)]
        public string Location { get; set; } = null!;
        [MaxLength(55)]
        public string Password { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual UserRoleMapping? UserRoleMapping { get; set; }
        public virtual Candidate? Candidate { get; set; }
      
        public virtual Organisation? Organisation { get; set; }

    }
}
