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
    public class IncomeViewModel : ViewModelBase
    {
        private readonly IMessenger _messenger;
        private readonly INavigationService _navigationMessage;

        public IncomesModel Income { get; set; } = new();

        public ObservableCollection<string> Type { get; set; } = new() { "Type..", "CARD", "CASH", "SAVINGS" };
        public ObservableCollection<string> Date { get; set; } = new() { "Date..", "WEEK", "MONTH", "YEAR" };


        public IncomeViewModel(IMessenger messenger, INavigationService navigationService)
        {
            _messenger = messenger;
            _navigationMessage = navigationService;

            _messenger.Register<IncomeMessages>(this, message => Income = message.Incomes!);

            typeBox = "0";
            timeBox = "0";
        }

        private string? textInput;
        public string? TextInput
        {
            get { return textInput; }
            set
            {
                textInput = value;
                Set(ref textInput, value);
            }
        }

        private string? typeBox;
        public string? TypeBox
        {
            get { return typeBox; }
            set
            {
                typeBox = value;
                Set(ref typeBox, value);
            }
        }

        private string? timeBox;
        public string? TimeBox
        {
            get { return timeBox; }
            set
            {
                timeBox = value;
                Set(ref timeBox, value);
            }
        }

        public RelayCommand Confirm
        {
            get => new RelayCommand(() =>
            {
                try
                {
                    if (TimeBox == "0" || TypeBox == "0" || string.IsNullOrEmpty(TextInput))
                    {
                        MessageBox.Show("Enter everything completely!", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        _navigationMessage?.NavigateTo<MainViewModel>();

                        Income.Amount = Convert.ToDouble(TextInput);

                        Enum.TryParse(TypeBox, out INCOMES_TYPE Type);
                        Enum.TryParse(TimeBox, out TIME Time);

                        Income.Type = Type;
                        Income.Time = Time;

                        _messenger?.Send(new IncomeMessages() { Incomes = Income });

                        TextInput = null;
                        TimeBox = "0";
                        TypeBox = "0";
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"{e.Message}", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    TextInput = null;
                    TimeBox = "0";
                    TypeBox = "0";

                    _navigationMessage.NavigateTo<IncomeViewModel>();
                }
            });
        }
    }
}
