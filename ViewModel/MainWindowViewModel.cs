using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using O_PAY_O.Messages;
using O_PAY_O.Services.Interfaces;
using O_PAY_O.Services.Classes;
using O_PAY_O.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace O_PAY_O.ViewModel
{
    public class SeriesData
    {
        public Brush? Color { get; set; }
        public double Count { get; set; }
        public string? Name { get; set; }
    }



    public class MainWindowViewModel : ViewModelBase
    {
        private ViewModelBase currentViewModel;

        public INavigationService NavigationService { get; set; }
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }

        public MainWindowViewModel(IMessenger messenger, INavigationService navigationService)
        {
            NavigationService = navigationService;

            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container?.GetInstance(message.ViewModelType!) as ViewModelBase;
                CurrentViewModel = viewModel!;
            });

            NavigationService?.NavigateTo<MainViewModel>();
        }


        public RelayCommand Category
        {
            get => new RelayCommand(() =>
            {
                NavigationService.NavigateTo<CategoriesViewModel>();
            });
        }

        public RelayCommand IncomeTypes
        {
            get => new RelayCommand(() =>
            {
                NavigationService.NavigateTo<IncomeTypeViewModel>();
            });
        }

        public RelayCommand MainWindow
        {
            get => new RelayCommand(() =>
            {
                NavigationService.NavigateTo<MainViewModel>();
            });
        }
    }
}
