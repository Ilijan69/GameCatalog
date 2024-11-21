using System.ComponentModel.DataAnnotations;

namespace GameCatalog.Models
{
    public class Game
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Manufacturer { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Instructions { get; set; } = string.Empty;

        [Range(0, 5)]
        public double Rating { get; set; }

        public string ImageUrl { get; set; } = string.Empty;// Снимка на играта
    }
}
