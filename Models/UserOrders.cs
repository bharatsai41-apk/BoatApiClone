namespace boatapi.Models;

public class UserOrders
{
    public required Guid OrderId { get; set; } = Guid.NewGuid();
    public string? Trackingurl { get; set; }
    public ICollection<OrderProducts> orderProducts { get; set; } = new List<OrderProducts>();
}
