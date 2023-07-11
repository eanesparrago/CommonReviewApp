namespace CommonReviewApp.Models;

public class Thing
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<ThingCategory> ThingCategories { get; set; }
    public ICollection<ThingOwner> ThingOwners { get; set; }
}

