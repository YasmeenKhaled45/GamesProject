namespace GamesProject.Models
{
    public class GamesDevices
    {
        public int GameId { get; set; }
        public Games Games { get; set; } = default!;

        public int DeviceId { get; set;}
        public Devices Devices { get; set; } = default!;
    }
}
