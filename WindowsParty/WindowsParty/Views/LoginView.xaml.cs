using System;
using System.Windows;
using System.Windows.Input;
using WindowsParty.IServices;
using WindowsParty.ViewModels;
using Caliburn.Micro;

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
            //TODO: remove after testing global error handling
            //throw new Exception("I'm discontinuing this! Ha ha ha!");
        }

        private void bg_btn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            var loginViewModel = (LoginViewModel) DataContext;

            loginViewModel.LoadServersPage();
            return;

            //var serversView = new ServersView
            //{
            //    AccessToken = loginViewModel.GetAccessToken(),
            //    Width = this.Width,
            //    Height = this.Height,
            //    Top = this.Top,
            //    Left = this.Left
            //};

            //(new WindowManager()).ShowWindow(serversView);
            //IEnumerable<KeyValuePair<string, object>>
            

            //this.Hide();
            //serversView.Show();
        }
    }
}
