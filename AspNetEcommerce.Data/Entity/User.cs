using AspNetEcommerce.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEcommerce.Data.Entity
{
    public class User : CreateAuditableEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Username { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(150)")]
        public string EmailAddress { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string? Roles { get; set; }

        public bool IsActive { get; set; }
        public string? ActivationKey { get; set; }
    }
}
