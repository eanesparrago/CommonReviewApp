namespace CommonReviewApp.Models;

public class ThingCategory
{
    public int ThingId { get; set; }
    public int CategoryId { get; set; }
    public Thing Thing { get; set; }
    public Category Category { get; set; }
    public ICollection<ThingCategory> ThingCategories { get; set; }
}
