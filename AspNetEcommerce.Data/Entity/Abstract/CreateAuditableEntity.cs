namespace AspNetEcommerce.Data.Entity.Abstract
{
    public abstract class CreateAuditableEntity : BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
