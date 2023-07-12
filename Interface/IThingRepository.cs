using CommonReviewApp.Models;

namespace CommonReviewApp.Interface;

public interface IThingRepository
{
    ICollection<Thing> GetThings();
}
