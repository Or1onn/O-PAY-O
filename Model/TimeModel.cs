using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.Model
{
    public enum TIME { WEEK, MONTH, YEAR }

    internal class TimeModel
    {
        public TIME Time { get; set; } = TIME.WEEK;
        public IncomesModel? Incomes { get; set; } = new();
        public ExpensesModel? Expenses { get; set; } = new();

    }
}
