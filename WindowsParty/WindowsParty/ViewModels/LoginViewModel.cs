using System;
using WindowsParty.IServices;
using Caliburn.Micro;
using log4net.Core;

namespace WindowsParty.ViewModels
{
    public class LoginViewModel : Conductor<object>
    {
        private string _username = "tesonet";
        private string _password = "partyanimal";

        private readonly IAuthorizationService _authorizationService;

        public LoginViewModel(IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
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

        public void LoadServersPage()
        {
            var accessToken = _authorizationService.GetAccessToken(Username, Password);

            var serversViewModel = new ServersViewModel();
            serversViewModel.LoadServers(accessToken);
            (new WindowManager()).ShowWindow(serversViewModel);

        }
    }
}
