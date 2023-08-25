using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamesProject.Services
{
    public interface IDevicesServices
    {
        IEnumerable<SelectListItem> GetDevices();
    }
}
