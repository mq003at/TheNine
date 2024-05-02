namespace store.Models;

public class Category : BaseModel 
{
    public required string Name { get; set; }
    public ICollection<string>? Images { get; set; } = new List<string>();
    public ICollection<Product>? Products { get; set; }
}