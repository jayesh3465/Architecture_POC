using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreMicroServices_POC.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]

        public string? Description { get; set; }
        [Required]


        public decimal ProductPrice { get; set; }
        [Required]

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;

    }
}
