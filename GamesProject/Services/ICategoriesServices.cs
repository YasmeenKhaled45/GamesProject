using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamesProject.Services
{
    public interface ICategoriesServices
    {
        IEnumerable<SelectListItem> GetCategories();

    }
}
