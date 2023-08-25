using System.ComponentModel.DataAnnotations;

namespace GamesProject.Models
{
    public class Devices
    {
        public int Id { get; set; }
        [MaxLength(60)]
        public string Name { get; set; }
        [MaxLength(60)]
        public string Icon { get; set; } = string.Empty;

    }
}
