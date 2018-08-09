using System;
using System.Collections.Generic;
using Caliburn.Micro;
using WindowsParty.ViewModels;
using Unity;

namespace WindowsParty
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();

            //TODO: remove
         //var logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType).Logger;
            
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<LoginViewModel>();
        }

        protected override object GetInstance(Type service, string key)
        {
            return UnityContainerFactory.UnityContainer.Resolve(service, key);
        }

        protected override IEnumerable<object> GetAllInstances(Type service)
        {
            return UnityContainerFactory.UnityContainer.ResolveAll(service);
        }

        protected override void BuildUp(object instance)
        {
            UnityContainerFactory.UnityContainer.BuildUp(instance);
        }
    }
}
