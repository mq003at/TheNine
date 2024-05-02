namespace store.Models;

public class Product : BaseModel
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public double Price { get; set; }
    public ICollection<string>? Images { get; set; } = null!;
    public int CategoryId { get; set; }
    public required Category Category { get; set; }
    // public ICollection<CartItem>? CartItems { get; set; } = null!;


}