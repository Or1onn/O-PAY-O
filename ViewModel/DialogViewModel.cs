using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using O_PAY_O.View;
using O_PAY_O.ViewModel;
using GalaSoft.MvvmLight;

namespace O_PAY_O.ViewModel
{
    public class DialogViewModel : ViewModelBase
    {
        private ObservableCollection<string> textInput;
        public ObservableCollection<string> TextInput
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
                if (input == null)
                    input = new RelayCommand<string>(ButtonInput);
                return input;
            }
        }

        public void ButtonInput(string number)
        {
            TextInput?.Add(number);
        }
    }
}
