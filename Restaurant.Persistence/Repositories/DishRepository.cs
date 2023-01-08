using Restaurant.Application.Contracts.Persistence;
using Restaurant.Domain.Entities;

namespace Restaurant.Persistence.Repositories
{
    public class DishRepository : BaseRepository<Dish>, IDishRepository
    {
        public DishRepository(RestaurantDbContext dbContext) : base(dbContext)
        {
        }
    }
}
