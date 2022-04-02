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
        private ObservableCollection<string>? incomes = new() { "VISA" };
        public ObservableCollection<string>? Incomes
        {
            get { return incomes; }
            set => Set(ref incomes, value);
        }
    }
}
