using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.Model
{
    public class AccountModel : ViewModelBase
    {
        public string? Login { get; set; }

        public string? Password { get; set; }

        public ObservableCollection<string>? Objects { get; set; }
    }
}
