namespace APIAssignment.Models;

public class OrderRequestModel
{
    public int OrderId { get; set; }
    public string? Address { get; set; }
    public List<string>? ProductIds { get; set; }
}
