using System.ComponentModel.DataAnnotations;

namespace WebApiPractice.Models
{
    public class PaintBrand
    {
        public int Id { get; set; }

        [Required, StringLength(120)]
        public string Name { get; set; } = string.Empty; 

        [StringLength(500)]
        public string? Description { get; set; }

        public List<PaintSeries> Series { get; set; } = new();
    }
}
