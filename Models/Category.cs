using System.ComponentModel.DataAnnotations;

namespace Growler.Models
{
    public class Category
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Introduction { get; set; }
    }
}