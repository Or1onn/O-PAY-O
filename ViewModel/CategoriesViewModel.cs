using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using O_PAY_O.View;

namespace O_PAY_O.ViewModel
{
    public class CategoriesViewModel : ViewModelBase
    {
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

        public RelayCommand Confirm
        {
            get => new RelayCommand(() =>
            {
                Button newBtn = new Button();

                newBtn.Content = "ABC";
                newBtn.Name = "ABC";

                
            });
        }



        private ObservableCollection<WrapPanel>? wrapPanel;
        public ObservableCollection<WrapPanel>? WrapPanel
        {
            get { return wrapPanel; }
            set
            {
                wrapPanel = value;
                Set(ref wrapPanel, value);
            }
        }


        
        private string? color = "Black";
        public string? Color
        {
            get { return color; }
            set
            {
                color = value;
                Set(ref color, value);
            }
        }
    }
}
