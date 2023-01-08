namespace Restaurant.Application.DTOs
{
    public class CreateCommentRequestDto
    {
        public int DishId { get; set; }
        public int Rating { get; set; }
        public string Contents { get; set; } = string.Empty;
        public string CreatedBy { get; set; } = string.Empty;
    }
}
