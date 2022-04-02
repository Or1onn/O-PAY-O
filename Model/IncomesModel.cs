using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_PAY_O.Model
{
    public enum INCOMES_TYPE { CASH, CARD, SAVINGS }

    public class IncomesModel
    {
        public double? Amount { get; set; }
        public INCOMES_TYPE Type { get; set; } = INCOMES_TYPE.CASH;
        public TIME Time { get; set; } = TIME.WEEK;
    }
}
