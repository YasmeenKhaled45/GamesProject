using System.ComponentModel.DataAnnotations;

namespace GamesProject.Models
{
    public class Games
    {
        public int id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;

        [MaxLength(600)]
        public string Cover { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Categories Categories { get; set; } = default!;

        public ICollection<GamesDevices> Devices { get; set; } = new List<GamesDevices>();
    }
}
