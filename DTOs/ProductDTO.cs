namespace store.DTOs;

using store.Models;

public class ProductDTO : BaseDTO<Product>
{
    public required string Title { get; set; }
    public string Description { get; set; } = "This product does not have a description.";
    public double Price { get; set; }
    public ICollection<string> Images { get; set; } = new List<string>();
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
    public override void UpdateModel(Product model)
    {
        model.Title = Title;
        model.Price = Price;
        model.Images = Images;
        model.Description = Description;
        model.CategoryId = CategoryId;
        model.Category = Category ?? model.Category;
    }
}

public class ProductUpdateDTO
{
    public int? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; } = string.Empty;
    public double Price { get; set; }
    public int CategoryId { get; set; }
    public ICollection<string> Images { get; set; } = new List<string>();

}