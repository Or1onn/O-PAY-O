using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.ViewModel
{
    public class IncomeTypeViewModel : ViewModelBase
    {
        private ObservableCollection<string>? incomes = new() { "VISA", "MASTER CARD" };
        public ObservableCollection<string>? Incomes
        {
            get { return incomes; }
            set => Set(ref incomes, value);
        }

        private string? incomeText = "1";
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

    }
}
