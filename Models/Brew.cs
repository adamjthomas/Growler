using System.ComponentModel.DataAnnotations;

namespace Growler.Models
{
    public class Brew
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Style Style { get; set; }
    }
}