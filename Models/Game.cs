

using System.Collections;

namespace WebApplication2.Models
{
    public class Game : BaseIntity
    {
        
        [MaxLength(2500)]
        public string Describtion { get; set; } = string.Empty;

        [MaxLength(500)]
        public string? Cover { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public ICollection<GameDevice> Device { get; set; } = new List<GameDevice>();



    }
}
