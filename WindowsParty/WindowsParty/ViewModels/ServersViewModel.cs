using System.Linq;
using WindowsParty.IServices;
using WindowsParty.Repositories;
using WindowsParty.Services;
using Caliburn.Micro;

namespace WindowsParty.ViewModels
{
    public class ServersViewModel : Screen
    {
        private readonly IServerService _serverService;

        public ServersViewModel()
        {
            this._serverService = new ServerService(new ServerRepository());



            //Servers = new BindableCollection<ServerViewModel>();

            //for (int i = 1; i < 30; i++)
            //{
            //    Servers.Add(new ServerViewModel { Name = "Wall " + i, Distance = 10 * i + " km" });
            //}
        }

        public BindableCollection<ServerViewModel> Servers { get; set; }

        public void LoadServers(string accessToken)
        {
            Servers = new BindableCollection<ServerViewModel>(_serverService.GetServers(accessToken).Select(x => new ServerViewModel { Name = x.Name, Distance = x.Distance + "km" }));
        }
    }
}
