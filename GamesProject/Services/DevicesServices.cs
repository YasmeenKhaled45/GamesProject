using GamesProject.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GamesProject.Services
{
    public class DevicesServices : IDevicesServices
    {
        private readonly ApplicationDbContextcs contextcs;

        public DevicesServices(ApplicationDbContextcs contextcs)
        {
            this.contextcs = contextcs;
        }

        public IEnumerable<SelectListItem> GetDevices()
        {
            return contextcs.Devices.Select(d => new SelectListItem { Value = d.Id.ToString(), Text = d.Name })
                .OrderBy(d => d.Text)
                .AsNoTracking()
                .ToList();
        }
    }
}
