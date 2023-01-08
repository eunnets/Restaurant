using Restaurant.Application.DTOs;
using Restaurant.Domain.Entities;

namespace Restaurant.Application.Contracts.Persistence
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        Task<List<Comment>> GetAllByDishId(int dishId);
    }
}
