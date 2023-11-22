using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        [StringLength(50, ErrorMessage ="Name must be 50 characters or less")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Please enter the inventory")]
        public int Inventory { get; set; }
        [Required(ErrorMessage = "Please enter the price")]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
