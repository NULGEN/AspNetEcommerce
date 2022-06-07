namespace AspNetEcommerce.Data.Entity.Abstract
{
    public abstract class UpdateAuditableEntity : BaseEntity
    {
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
