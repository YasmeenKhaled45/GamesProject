using System.ComponentModel.DataAnnotations;

namespace GamesProject.Models
{
    public class Categories
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        public ICollection<Games> games { get; set; } = new List<Games>();
    }
}
