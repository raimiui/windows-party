using System.Linq;
using WindowsParty.IServices;
using Caliburn.Micro;

namespace WindowsParty.ViewModels
{
    class ServersViewModel : Screen
    {
        private readonly IServerService _serverService;

        public string AccessToken { get; set; }
        public ServersViewModel(IServerService _serverService)
        {
            this._serverService = _serverService;

            Servers = new BindableCollection<ServerViewModel>(_serverService.GetServers(AccessToken).Select(x => new ServerViewModel{DisplayName = x.Name, Distance = x.Distance + "km"}));


            //Servers = new BindableCollection<ServerViewModel>();

            //for (int i = 1; i < 30; i++)
            //{
            //    Servers.Add(new ServerViewModel { Name = "Wall " + i, Distance = 10 * i + " km" });
            //}
        }

        public BindableCollection<ServerViewModel> Servers { get; set; }
    }
}
