namespace WebApplication2.Models
{
    public class Category :BaseIntity
    {
        public ICollection<Game> Games { get; set; } = new List<Game>();
    }
}
