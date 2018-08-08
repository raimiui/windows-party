using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsParty.ViewModels
{
    public class ServerViewModel : Screen
    {
        private string _name = "John";

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }


        public string Distance { get; set; }
    }
}
