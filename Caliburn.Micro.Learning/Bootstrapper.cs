using Caliburn.Micro.Learning.ViewModels;
using System.Windows;

namespace Caliburn.Micro.Learning
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e);
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
