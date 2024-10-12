namespace WebApplication2.Models
{
    public class Device : BaseIntity
    {
        [MaxLength(50)]
        public string Icon { get; set; } = string.Empty;
    }
}
