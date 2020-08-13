namespace Growler.Dtos
{
    public class BrewReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CategoryReadDto Category { get; set; }
        public StyleReadDto Style { get; set; }
    }
}