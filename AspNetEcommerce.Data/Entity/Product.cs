using AspNetEcommerce.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEcommerce.Data.Entity
{
    public class Product : CreateAuditableEntity
    {
        [Required]
        [Column(TypeName = "nvarchar(400)")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }

        public string? ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public bool IsFeatured { get; set; } = false;
    }
}
