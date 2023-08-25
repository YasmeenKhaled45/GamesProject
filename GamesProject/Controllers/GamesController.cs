using GamesProject.Data;
using GamesProject.Services;
using GamesProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Contracts;

namespace GamesProject.Controllers
{

    public class GamesController : Controller
    {
        private readonly ApplicationDbContextcs contextcs;
        private readonly ICategoriesServices _categoriesServices;
        private readonly IDevicesServices devicesServices;
        private readonly IGamesService gamesService;
        public GamesController(ApplicationDbContextcs contextcs, ICategoriesServices categoriesServices, IDevicesServices devicesServices, IGamesService gamesService)
        {

            this.contextcs = contextcs;
            this._categoriesServices = categoriesServices;
            this.devicesServices = devicesServices;
            this.gamesService = gamesService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            CreateGameFormModel viewModel = new()
            {
                Categories = _categoriesServices.GetCategories(),
                Devices = devicesServices.GetDevices()
            };

            return View(viewModel);
        }
        [HttpPost]
         [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateGameFormModel formModel)
        {
            if (!ModelState.IsValid)
            {
                formModel.Categories = _categoriesServices.GetCategories();
                formModel.Devices = devicesServices.GetDevices();
                return View(formModel);
            }
            await gamesService.Create(formModel);
            return RedirectToAction(nameof(Index));
        }

    }
}
