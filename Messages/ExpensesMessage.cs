using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O_PAY_O.Model;

namespace O_PAY_O.Messages
{
    public class ExpensesMessage
    {
        public ExpensesModel? Expenses { get; set; }
    }
}
