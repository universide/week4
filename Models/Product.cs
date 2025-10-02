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

        // ������ϵ�������һ����Ʒ����һ��ϵ�У�
        public int SeriesId { get; set; }
        public PaintSeries? Series { get; set; }

        // ��ѡ����Ʒ���ԣ�ʾ����
        [StringLength(40)]
        public string? ColourCode { get; set; }      // ��ɫ���루�� PANTONE��
        public GlossLevel? Gloss { get; set; }       // ����ȣ�ö�٣�
        public SubstrateType? Substrate { get; set; }// ���õײģ�ö�٣�
    }
}
