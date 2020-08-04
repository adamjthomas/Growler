namespace Growler.Models
{
    public class Brew
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public Style Style { get; set; }
        public VitalStatistics VitalStatistics { get; set; }
    }
}