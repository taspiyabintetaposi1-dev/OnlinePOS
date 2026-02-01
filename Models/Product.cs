// If this file exists, ensure it looks like this:
using System.ComponentModel.DataAnnotations;

namespace OnlinePOS.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(500)]
        public string Description { get; set; } = string.Empty;

        [DataType(DataType.Currency)]
        [Range(0.01, 1000000)]
        public decimal Price { get; set; }

        [Range(0, 10000)]
        public int StockQuantity { get; set; }

        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
    }
}