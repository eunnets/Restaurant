namespace Restaurant.Application.DTOs
{
    public class CommentDto
    {
        public int DishId { get; set; }
        public int Rating { get; set; }
        public string Contents { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
    }
}
