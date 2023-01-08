namespace Restaurant.Application.DTOs
{
    public class UpdateDishRequestDto
    {
        public string Image { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Featured { get; set; }
        public string Description { get; set; } = string.Empty;
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
