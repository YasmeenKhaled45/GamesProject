using GamesProject.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GamesProject.Services
{
    
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ApplicationDbContextcs contextcs;

        public CategoriesServices(ApplicationDbContextcs contextcs)
        {
            this.contextcs = contextcs;
        }

        public IEnumerable<SelectListItem> GetCategories()
        {
            return contextcs.Categories
                .Select(c => new SelectListItem { Value = c.Id.ToString(), Text = c.Name })
                .OrderBy(c => c.Text)
                .AsNoTracking()
                .ToList();
        }
    }
}
