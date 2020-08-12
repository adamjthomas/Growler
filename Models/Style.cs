using System.ComponentModel.DataAnnotations;

namespace Growler.Models
{
    public class Style
    {
        [Required]
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string OverallImpression { get; set; }

        [Required]
        public string Aroma { get; set; }

        [Required]
        public string Appearance { get; set; }

        [Required]
        public string Flavor { get; set; }

        [Required]
        public string Mouthfeel { get; set; }

        [Required]
        public string Comments { get; set; }

        [Required]
        public string History { get; set; }

        [Required]
        public string CharacteristicIngredients { get; set; }

        [Required]
        public string OG { get; set; }

        [Required]
        public string IBUs { get; set; }

        [Required]
        public string FG { get; set; }

        [Required]
        public string SRM { get; set; }

        [Required]
        public string ABV { get; set; }
    }
}