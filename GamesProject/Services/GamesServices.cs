using GamesProject.Data;
using GamesProject.Models;
using GamesProject.ViewModels;

namespace GamesProject.Services
{
    public class GamesServices : IGamesService
    {
        private readonly ApplicationDbContextcs contextcs;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly string ImagePath;
        public GamesServices(ApplicationDbContextcs contextcs, IWebHostEnvironment webHostEnvironment)
        {
            this.contextcs = contextcs;
            this.webHostEnvironment = webHostEnvironment;
            ImagePath = $"{webHostEnvironment.WebRootPath}/Images/Games";
        }

        public async Task Create(CreateGameFormModel model)
        {
            var covername = $"{Guid.NewGuid()}{Path.GetExtension(model.Cover.FileName)}";
            var path = Path.Combine(ImagePath , covername);
            using var stream = File.Create(path);
            await model.Cover.CopyToAsync(stream);
            stream.Dispose();
            Games g = new Games
            {
                Name = model.Name,
                Description = model.Description,
                CategoryId = model.CategoryId,
                Cover = covername,
                Devices = model.SelectedDevices.Select(d => new GamesDevices { DeviceId = d }).ToList()

            };
            contextcs.Games.Add(g);
            contextcs.SaveChanges();
        }
    }
}
