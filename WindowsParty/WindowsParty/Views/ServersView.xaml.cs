using System.Windows;
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
        }

        public string AccessToken { get; set; }
    }
}
