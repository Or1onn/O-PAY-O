using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using LiveCharts;
using LiveCharts.Defaults;
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

namespace O_PAY_O.ViewModel
{
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ViewModelBase currentViewModel;
        public INavigationService NavigationService { get; set; }
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        private readonly IMessenger? _messenger;

        public IncomesModel Income { get; set; }

        public SeriesData SeriesData { get; set; }


        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            NavigationService = navigationService;
            _messenger = messenger;

            SeriesCollection = new();

            _messenger.Register<SeriesDataMessage>(this, message =>
            {
                SeriesData = message.SeriesData!;
                ExpensesText = Convert.ToString(Convert.ToDouble(ExpensesText) + SeriesData.Count);
                AddSeries(SeriesData);
            });

            _messenger.Register<IncomeMessages>(this,
                message =>
                {
                    Income = message.Incomes!;
                    IncomeText = Convert.ToString(Convert.ToDouble(IncomeText) + Income.Amount);
                });
        }

        private string? incomeText;
        public string? IncomeText
        {
            get
            {
                return incomeText;
            }
            set
            {
                incomeText = value;
                Set(ref incomeText, value);
            }
        }

        private string? expensesText;
        public string? ExpensesText
        {
            get
            {
                return expensesText;
            }
            set
            {
                expensesText = value;
                Set(ref expensesText, value);
            }
        }


        private RelayCommand<SeriesData> add;
        public RelayCommand<SeriesData> Add
        {
            get
            {
                if (add == null)
                    add = new RelayCommand<SeriesData>(AddSeries);
                return add;
            }
        }

        private void AddSeries(SeriesData obj)
        {
            if (obj?.Count != 0)
            {
                var vals = new ChartValues<ObservableValue>();

                foreach (var item in SeriesCollection!)
                {
                    if (item.Title == obj?.Name)
                    {
                        vals?.Add(new ObservableValue(obj!.Count));
                        vals?.Add((ObservableValue)item.Values[0]!);
                        item.Values[0] = new ObservableValue(vals![0].Value + vals[1].Value);

                        vals?.Clear();

                        return;
                    }
                }

                vals?.Add(new ObservableValue(obj!.Count));

                SeriesCollection?.Add(new PieSeries
                {
                    Values = vals,
                    Fill = obj?.Color,
                    Title = obj?.Name,
                });

            }
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
