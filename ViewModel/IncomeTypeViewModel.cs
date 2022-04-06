using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.ViewModel
{
    public class IncomeTypeViewModel : ViewModelBase
    {
        private ObservableCollection<string>? type = new() { "CASH", "VISA" };
        public ObservableCollection<string>? Type
        {
            get { return type; }
            set => Set(ref type, value);
        }
        private string? abc = "VISA";
        public string? Abc
        {
            get { return abc; }
            set => Set(ref abc, value);
        }


        private string? incomeText;
        public string? IncomeText
        {
            get { return incomeText; }
            set
            {
                incomeText = value;
                Set(ref incomeText, value);
            }
        }

        private string? expensesText;
        public string? ExpensesText
        {
            get { return expensesText; }
            set
            {
                expensesText = value;
                Set(ref expensesText, value);
            }
        }
    }
}
