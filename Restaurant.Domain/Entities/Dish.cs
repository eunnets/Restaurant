namespace Restaurant.Domain.Entities
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Featured { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
