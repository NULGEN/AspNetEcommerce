using AspNetEcommerce.Data.Entity.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetEcommerce.Data.Entity
{
    public class Category : BaseEntity
    {
        [Column(TypeName = "nvarchar(400)")]
        public string? Name { get; set; }

        public int? ParentId { get; set; }
    }
}
