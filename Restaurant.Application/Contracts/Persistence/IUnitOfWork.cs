namespace Restaurant.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IDishRepository DishRepository { get; }
        ICommentRepository CommentRepository { get; }
        Task Save();
    }
}
