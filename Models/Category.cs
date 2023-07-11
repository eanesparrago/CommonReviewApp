namespace CommonReviewApp.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<ThingCategory> ThingCategories { get; set; }
}
