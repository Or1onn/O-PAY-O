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

namespace O_PAY_O.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ViewModelBase currentViewModel;
        public INavigationService NavigationService { get; set; }
        public ViewModelBase CurrentViewModel { get => currentViewModel; set => Set(ref currentViewModel, value); }
        private readonly IMessenger? _messenger;

        public SeriesData SeriesData { get; set; }
        public MainViewModel(IMessenger messenger, INavigationService navigationService)
        {
            NavigationService = navigationService;
            _messenger = messenger;

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "NULL",
                    Values = new ChartValues<ObservableValue> { new ObservableValue(0) },
                    DataLabels = false
                },
            };

            //_messenger.Register<SeriesDataMessage>(this, message => SeriesData = message.SeriesData!);
            //AddSeries(SeriesData!);
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
            var vals = new ChartValues<ObservableValue>();

            vals?.Add(new ObservableValue(10));
            SeriesCollection?.Add(new PieSeries
            {
                Values = vals,
                Fill = obj.Color,
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

        public SeriesCollection? SeriesCollection { get; set; }

    }

}
