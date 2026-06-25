namespace boatapi.Models;

public class Products
{
    public required Guid ProducId { get; set; } = Guid.NewGuid();
    public required string ProductName { get; set; }
    public required string ProductDescription { get; set; }
    public required int Stock { get; set; }
    public required decimal Price { get; set; }
    public required string TrackingUrl { get; set; }
}
