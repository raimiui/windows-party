using System;
using WindowsParty.IServices;
using Caliburn.Micro;
using log4net.Core;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username = "tesonet";
        private string _password = "partyanimal";

        private readonly IAuthorizationService _authorizationService;
        private readonly IServerService _serverService;

        public LoginViewModel(IAuthorizationService authorizationService, IServerService serverService)
        {
            _authorizationService = authorizationService;
            _serverService = serverService;
            var accessToken = _authorizationService.GetAccessToken("tesonet", "partyanimal");
            var servers = _serverService.GetServers(accessToken);
        }
        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }
     
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }
    }
}
