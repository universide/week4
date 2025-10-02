using System.ComponentModel.DataAnnotations;

namespace WebApiPractice.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(200)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 9999999)]
        public decimal Price { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        // 新增：系列外键（一个产品属于一个系列）
        public int SeriesId { get; set; }
        public PaintSeries? Series { get; set; }

        // 可选：产品属性（示例）
        [StringLength(40)]
        public string? ColourCode { get; set; }      // 颜色编码（如 PANTONE）
        public GlossLevel? Gloss { get; set; }       // 光泽度（枚举）
        public SubstrateType? Substrate { get; set; }// 适用底材（枚举）
    }
}
