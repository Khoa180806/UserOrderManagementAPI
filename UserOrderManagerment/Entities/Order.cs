namespace UserOrderManagerment.Entities;

public class Order : AuditedEntity
{
    public int UserId { get; set; }
    public User User { get; set; }
    
    public decimal TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public string status { get; set; } = string.Empty;
}