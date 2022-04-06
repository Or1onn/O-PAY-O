using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using O_PAY_O.Messages;
using O_PAY_O.Services.Interfaces;
using O_PAY_O.Services.Classes;
using System.Linq;
using O_PAY_O.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;
using System.IO;
using System.Text.Json;
using O_PAY_O.Model;
using System.Collections.ObjectModel;

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
        public static ObservableCollection<ExpensesModel> AllExpenses { get; set; } = new();

        private ViewModelBase currentViewModel;

        public INavigationService NavigationService { get; set; }
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }

        public IncomesModel Income { get; set; } = new();

        public MainWindowViewModel(IMessenger messenger, INavigationService navigationService)
        {
            NavigationService = navigationService;

            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container?.GetInstance(message.ViewModelType!) as ViewModelBase;
                CurrentViewModel = viewModel!;
            });

            messenger.Register<NavigationMessage>(this, message =>
            {
                var viewModel = App.Container?.GetInstance(message.ViewModelType!) as ViewModelBase;
                CurrentViewModel = viewModel!;
            });

            messenger.Register<string>(this,
            message =>
            {
                Income.Amount = Convert.ToDouble(message!);
            });

            messenger.Register<IncomeMessages>(this,
            message =>
            {
                Income = message.Incomes!;
            });


            NavigationService?.NavigateTo<MainViewModel>();

            messenger.Register<ExpensesMessage>(this, message =>
            {
                foreach (var item in AllExpenses)
                {
                    if (message?.Expenses?.Category == item.Category)
                    {
                        item.Amount += message!.Expenses!.Amount;
                        return;
                    }
                }
                AllExpenses.Add(message.Expenses!);
            });

            NavigationService?.NavigateTo<MainViewModel>();
        }


        private string? incomeText;
        public string? IncomeText
        {
            get { return incomeText; }
            set
            {
                incomeText = value;
            }
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

        public RelayCommand Save
        {
            get => new RelayCommand(async () =>
            {
                using FileStream fs = new FileStream("AllExpenses.json", FileMode.OpenOrCreate);
                await JsonSerializer.SerializeAsync(fs, AllExpenses, new JsonSerializerOptions { WriteIndented = true, });

                File.Delete("Incomes.json");
                using FileStream fs2 = new FileStream("Incomes.json", FileMode.OpenOrCreate);
                await JsonSerializer.SerializeAsync(fs2, Income, new JsonSerializerOptions { WriteIndented = true, });
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
