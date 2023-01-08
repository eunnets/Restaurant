using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Application.DTOs
{
    public class DishDto
    {
        public int Id { get; set; }
        public string name { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Label { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public bool Featured { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
