namespace UserOrderManagerment.Entities;

public abstract class AuditedEntity
{
    public int Id { get; set; }

    public DateTime CreationTime { get; set; }
    public int? CreatorUserId { get; set; }

    public DateTime? LastModificationTime { get; set; }
    public bool IsDeleted { get; set; }
}