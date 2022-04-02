using System;
using System.Collections.Generic;
using System.Configuration;
using GalaSoft.MvvmLight;
using System.Data;
using SimpleInjector;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using O_PAY_O.View;
//using O_PAY_O.View.Login;
using O_PAY_O.ViewModel;
using GalaSoft.MvvmLight.Messaging;
using O_PAY_O.Services.Interfaces;
using O_PAY_O.Services.Classes;
//using O_PAY_O.ViewModel.Login;

namespace O_PAY_O
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Container? Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            Register();

            StartMain<MainWindowViewModel>();


            base.OnStartup(e);
        }

        public void Register()
        {
            Container = new Container();

            Container.RegisterSingleton<INavigationService, NavigationService>();
            Container.RegisterSingleton<IMessenger, Messenger>();

            Container.RegisterSingleton<MainWindowViewModel>();
            Container.RegisterSingleton<MainViewModel>();
            Container.RegisterSingleton<CategoriesViewModel>();
            Container.RegisterSingleton<IncomeViewModel>();
            Container.RegisterSingleton<IncomeTypeViewModel>();
            Container.RegisterSingleton<DialogViewModel>();

            Container.Verify();
        }

        public void StartMain<T>() where T : ViewModelBase
        {
            Window window = new MainWindow();
            var viewModel = Container?.GetInstance<T>();

            window.DataContext = viewModel;

            window.ShowDialog();
        }
    }
}
