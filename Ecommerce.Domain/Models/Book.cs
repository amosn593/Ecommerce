using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Models
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
