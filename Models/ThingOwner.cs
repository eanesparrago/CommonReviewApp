namespace CommonReviewApp.Models;

public class ThingOwner
{
    public int ThingId { get; set; }
    public int OwnerId { get; set; }
    public Thing Thing { get; set; }
    public Owner Owner { get; set; }
}
