using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace O_PAY_O.Model
{
    public class AccountModel : ViewModelBase
    {
        public ObservableCollection<string>? Objects { get; set; }


    }
}
