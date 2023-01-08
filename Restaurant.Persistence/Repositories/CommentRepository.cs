using Microsoft.EntityFrameworkCore;
using Restaurant.Application.Contracts.Persistence;
using Restaurant.Domain.Entities;

namespace Restaurant.Persistence.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        private readonly RestaurantDbContext _dbContext;

        public CommentRepository(RestaurantDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Comment>> GetAllByDishId(int dishId)
        {
            return await _dbContext.Comments.Where(x => x.DishId == dishId).ToListAsync();
        }
    }
}
