using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Book> Books { get; set; } 
    }
}
