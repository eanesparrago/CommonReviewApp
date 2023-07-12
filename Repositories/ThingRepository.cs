using CommonReviewApp.Data;
using CommonReviewApp.Interface;
using CommonReviewApp.Models;

namespace CommonReviewApp.Repositories;

public class ThingRepository : IThingRepository
{
    public readonly DataContext _dataContext;

    public ThingRepository(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public ICollection<Thing> GetThings()
    {
        return _dataContext.Things.OrderBy(thing => thing.Id).ToList();
    }
}
