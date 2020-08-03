using System.Collections.Generic;

namespace Growler.Models
{
    public class Brew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<string, Category> Category { get; set; }
        public Dictionary<string, Style> Style { get; set; }
        public Dictionary<string, VitalStatistics> VitalStatistics { get; set; }
    }
}