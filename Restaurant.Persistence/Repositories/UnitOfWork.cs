using Restaurant.Application.Contracts.Persistence;

namespace Restaurant.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly RestaurantDbContext _context;
        private IDishRepository _dishRepository;
        private ICommentRepository _commentRepository;

        public UnitOfWork(RestaurantDbContext context)
        {
            _context = context;
        }

        public IDishRepository DishRepository =>
            _dishRepository ??= new DishRepository(_context);
        public ICommentRepository CommentRepository =>
            _commentRepository ??= new CommentRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
