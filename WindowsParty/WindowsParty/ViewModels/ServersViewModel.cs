using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsParty.ViewModels
{
    class ServersViewModel : Screen
    {
        private BindableCollection<ServerViewModel> _servers;

        public BindableCollection<ServerViewModel> Servers
        {
            get { return _servers; }
            set { _servers = value; }
        }
    }
}
