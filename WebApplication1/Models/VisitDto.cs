using System.Text.Json.Serialization;

namespace WebApplication1.Models
{
    public class VisitDto
    {
        public int animalId { get; set; }
        public DateTime date { get; set; }
        public string treatment { get; set; }
        public float cost { get; set; }
    }
}
