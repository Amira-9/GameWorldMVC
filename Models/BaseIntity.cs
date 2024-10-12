namespace WebApplication2.Models
{
    public class BaseIntity
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string Name { get; set; } = string.Empty;

    }
}
