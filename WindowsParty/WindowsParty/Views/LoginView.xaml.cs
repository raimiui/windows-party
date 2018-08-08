using System;
using System.Windows;
using System.Windows.Input;

namespace WindowsParty.Views
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            throw new Exception("I'm discontinuing this! Ha ha ha!");
        }

        private void bg_btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var serversView = new ServersView();
            serversView.Width = this.Width;
            serversView.Height = this.Height;
            serversView.Top = this.Top;
            serversView.Left = this.Left;

            this.Hide();
            serversView.Show();
        }
    }
}
