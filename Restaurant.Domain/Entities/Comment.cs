namespace Restaurant.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int DishId { get; set; }
        public int Rating { get; set; }
        public string Contents { get; set; } = string.Empty;
    }
}
