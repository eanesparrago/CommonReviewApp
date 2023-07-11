namespace CommonReviewApp.Models;

public class Owner
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public Country Country { get; set; }
    public ICollection<ThingOwner> ThingOwners { get; set; }
}
