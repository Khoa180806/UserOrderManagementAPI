namespace UserOrderManagerment.DTOs;

public class RevenueReportDto
{
    public DateTime Date { get; set; }
    public decimal Revenue { get; set; }
    public int OrderCount { get; set; }
}