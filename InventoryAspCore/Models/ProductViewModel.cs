using System.ComponentModel.DataAnnotations;

namespace InventoryAspCore.Models
{
    public class ProductViewModel
    {
        
        public int Id { get; set; }

        [StringLength(15)]
        public string? Description { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please enter positive integer Number")]
        public decimal Quantity { get; set; }

    }
}