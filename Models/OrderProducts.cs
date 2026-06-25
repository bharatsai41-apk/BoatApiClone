namespace boatapi.Models;

public class OrderProducts
{
    public required Guid OrderId { get; set; }
    public required Guid ProductId { get; set; }
    public required decimal Price { get; set; }
    public required int Quantity { get; set; }
    //navigation
    public required ICollection<Products> products { get; set; } = new List<Products>();
}
