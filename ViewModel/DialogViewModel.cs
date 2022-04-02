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
using O_PAY_O.ViewModel;
using O_PAY_O.Services.Interfaces;
using O_PAY_O.Messages;
using GalaSoft.MvvmLight.Messaging;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace O_PAY_O.ViewModel
{
    public class DialogViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public SeriesData SeriesData { get; set; } = new();
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationMessage;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public DialogViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;
            _navigationMessage = navigationService;

            _messenger.Register<SeriesDataMessage>(this, message => SeriesData = message.SeriesData!);
        }


        private string? textInput;
        public string? TextInput
        {
            get
            {
                return textInput;
            }
            set
            {
                textInput = value;
                Set(ref textInput, value);
            }
        }

        private RelayCommand<string>? input;
        public RelayCommand<string> Input
        {
            get
            {
                input = new RelayCommand<string>(ButtonInput);
                return input;
            }
        }

        public void ButtonInput(string number)
        {
            TextInput += number;
            this.NotifyPropertyChanged("textInput");
        }

        public RelayCommand Backspace
        {
            get => new RelayCommand(() =>
            {
                TextInput = TextInput?.Length > 0 ? TextInput?.Remove(TextInput.Length - 1) : null;
                this.NotifyPropertyChanged("textInput");
            });
        }

        public RelayCommand Clean
        {
            get => new RelayCommand(() =>
            {
                TextInput = null;
                this.NotifyPropertyChanged("textInput");
            });
        }

        public RelayCommand SendToMain
        {
            get => new RelayCommand(() =>
            {
                SeriesData.Count = Convert.ToDouble(TextInput);

                _navigationMessage?.NavigateTo<MainViewModel>();
                _messenger?.Send(new SeriesDataMessage() { SeriesData = SeriesData });
                TextInput = null;
            });
        }
    }
}
