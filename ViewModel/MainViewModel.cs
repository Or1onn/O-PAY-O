using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Defaults;
using System.Windows.Media.Converters;
using LiveCharts.Wpf;
using System;
using O_PAY_O.View;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using O_PAY_O.Model;
using System.Windows.Media;
using System.Windows;
using O_PAY_O.Services.Classes;
using O_PAY_O.Services.Interfaces;
using O_PAY_O.Messages;
using GalaSoft.MvvmLight.Messaging;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace O_PAY_O.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public ObservableCollection<ExpensesModel> AllExpenses { get; set; } = new();

        private ViewModelBase currentViewModel;
        public INavigationService NavigationService { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        private readonly IMessenger? _messenger;

        public IncomesModel Income { get; set; }

        public SeriesData SeriesData { get; set; }
        public ExpensesModel Expenses { get; set; } = new();

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        async public void DeserializeAsync()
        {

            if (File.Exists("AllExpenses.json"))
            {
                using FileStream fs = new("AllExpenses.json", FileMode.OpenOrCreate);

                ObservableCollection<ExpensesModel>? Expenses = await JsonSerializer.DeserializeAsync<ObservableCollection<ExpensesModel>?>(fs);

                BrushConverter conv = new BrushConverter();
                if (Expenses != null)
                {
                    foreach (var item in Expenses!)
                    {
                        Add.Execute(new SeriesData { Name = item.Category, Count = item.Amount, Color = (Brush?)conv?.ConvertFromString(item.Color!) });
                        ExpensesText = (Convert.ToDouble(ExpensesText) + item.Amount).ToString();
                    }
                }
            }
            else
                File.AppendAllText("AllExpenses.json", "[]");

            if (File.Exists("Incomes.json"))
            {
                using FileStream fs = new("Incomes.json", FileMode.OpenOrCreate);

                IncomesModel? incomes = await JsonSerializer.DeserializeAsync<IncomesModel?>(fs);

                if (incomes != null)
                {
                    IncomeText = incomes.Amount.ToString();

                    if (IncomeText?.Length > 0)
                        _messenger?.Send(IncomeText);
                }

            }
            else
                File.AppendAllText("Incomes.json", "{}");
        }

        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            NavigationService = navigationService;
            _messenger = messenger;

            SeriesCollection = new();


            DeserializeAsync();
            _messenger.Register<SeriesDataMessage>(this, message =>
                {
                    SeriesData = message.SeriesData!;
                    ExpensesText = Convert.ToString(Convert.ToDouble(ExpensesText) + SeriesData.Count);
                    Add.Execute(SeriesData);
                });

            _messenger.Register<IncomeMessages>(this,
                message =>
                {
                    Income = message.Incomes!;
                    if (IncomeText?.Length <= 0)
                    {
                        IncomeText = Income.Amount.ToString();
                    }
                    else
                        IncomeText = Convert.ToString(Convert.ToDouble(IncomeText) + Income.Amount);

                    _messenger.Send(IncomeText);

                });
        }

        private string? incomeText;
        public string? IncomeText
        {
            get { return incomeText; }
            set
            {
                incomeText = value;
                NotifyPropertyChanged("incomeText");
            }
        }



        private string? expensesText;
        public string? ExpensesText
        {
            get { return expensesText; }
            set
            {
                expensesText = value;
                NotifyPropertyChanged("expensesText");
            }
        }

        public RelayCommand<SeriesData> Add
        {
            get => new RelayCommand<SeriesData>(
            param =>
            {
                if (param != null)
                {
                    if (param?.Count != 0)
                    {
                        var vals = new ChartValues<ObservableValue>();

                        foreach (var item in SeriesCollection!)
                        {
                            if (item.Title == param?.Name)
                            {
                                vals?.Add(new ObservableValue(param!.Count));
                                vals?.Add((ObservableValue)item.Values[0]!);
                                item.Values[0] = new ObservableValue(vals![0].Value + vals[1].Value);

                                vals?.Clear();
                                _messenger?.Send(new ExpensesMessage() { Expenses = new ExpensesModel { Amount = param.Count, Category = param?.Name, Color = param?.Color?.ToString() } });

                                return;
                            }
                        }

                        vals?.Add(new ObservableValue(param!.Count));

                        SeriesCollection?.Add(new PieSeries
                        {
                            Values = vals,
                            Fill = param?.Color,
                            Title = param?.Name,
                            Tag = param?.Name,
                        });
                        _messenger?.Send(new ExpensesMessage() { Expenses = new ExpensesModel { Amount = param!.Count, Category = param?.Name, Color = param?.Color?.ToString() } });

                    }
                }
            });
        }

        public RelayCommand<SeriesData>? OpenDialog
        {
            get => new RelayCommand<SeriesData>(
                param =>
                {
                    if (param != null)
                    {
                        NavigationService?.NavigateTo<DialogViewModel>();
                        _messenger?.Send(new SeriesDataMessage() { SeriesData = param });
                    }
                });
        }

        public RelayCommand Incomes
        {
            get => new RelayCommand(() =>
            {
                NavigationService.NavigateTo<IncomeViewModel>();
            });
        }

        public SeriesCollection? SeriesCollection { get; set; }

    }
}
