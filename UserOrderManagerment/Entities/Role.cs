namespace UserOrderManagerment.Entities;

public class Role : AuditedEntity
{
    public string Name { get; set; } = string.Empty;
    
    public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();
}