using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WindowsParty.ViewModels;

namespace WindowsParty.Views
{
    /// <summary>
    /// Interaction logic for ServersView.xaml
    /// </summary>
    public partial class ServersView : Window
    {
        public ServersView()
        {
            InitializeComponent();
            LoadServersIntoViewer();
        }

        private void LoadServersIntoViewer()
        {
        }

        public ObservableCollection<ServerViewModel> Servers
        {
            get
            {
                return 
                    new ObservableCollection<ServerViewModel>
                    {
                        new ServerViewModel{ Name = "Wall 1", Distance = "2 km"},
                        new ServerViewModel{ Name = "Wall 2", Distance = "33 km"},
                        new ServerViewModel{ Name = "Wall 3", Distance = "444 km"},
                        new ServerViewModel{ Name = "Wall 4", Distance = "5555 km"},
                    };
            }
        }
    }
}
