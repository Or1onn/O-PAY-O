using System;
using System.Collections.Generic;
using System.Configuration;
using GalaSoft.MvvmLight;
using System.Data;
using SimpleInjector;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using O_PAY_O.View.Login;
using O_PAY_O.ViewModel;
using O_PAY_O.ViewModel.Login;

namespace O_PAY_O
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Container? Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            StartMain<LoginViewModel>();
            

            base.OnStartup(e);
        }

        public void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<LoginViewModel>();
            Container.RegisterSingleton<RegisterViewModel>();

            Container.Verify();
        }

        public void StartMain<T>() where T : ViewModelBase
        {
            Window window = new Login();
            var viewModel = Container?.GetInstance<T>();

            window.DataContext = viewModel;

            window.ShowDialog();
        }
    }
}
