namespace store.DTOs;

using store.Models;

public class CategoryDTO : BaseDTO<Category>
{
    public required string Name { get; set; }
    public ICollection<string>? Images { get; set; } = new List<string>();
    public override void UpdateModel(Category model)
    {
        model.Name = Name;
        model.Images = Images;
    }
}

public class CategoryUpdateDTO : BaseDTO<Category>
{
    public string? Name { get; set; }
    public ICollection<string>? Images {get; set; }
    public override void UpdateModel(Category model)
    {
        model.Name = Name ?? model.Name;
        model.Images = Images ?? model.Images;
    }
}