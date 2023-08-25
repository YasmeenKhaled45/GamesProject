using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GamesProject.ViewModels
{
    public class CreateGameFormModel
    {
        [MaxLength(60)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(250)]
        public string Description { get; set; } = string.Empty;
        public IFormFile Cover { get; set; } = default!;
        public IEnumerable<SelectListItem> Categories { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name="Category")]
        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> Devices { get; set; } = Enumerable.Empty<SelectListItem>();
        [Display(Name = "Supproted Devices")]
        public List<int> SelectedDevices { get; set; } = new List<int>();
    }
}
