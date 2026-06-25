namespace boatapi.Models;

public class Users
{
    public required Guid UserId { get; set; } = Guid.NewGuid();
    public required string Email { get; set; }
    public required string Phone { get; set; }
    public required string Password { get; set; }
    public required string Address { get; set; }
    //navigation with other tables a user can have zero or more orders
    public ICollection<UserOrders>? userOrders { get; set; } = new List<UserOrders>();
}
