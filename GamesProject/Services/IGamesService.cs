using GamesProject.ViewModels;

namespace GamesProject.Services
{
    public interface IGamesService
    {
       Task Create(CreateGameFormModel model);
    }
}
