using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllProjects
{
    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            return amount / 10;
        }
        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            if (amount > 5) { return 2.0; }
            else { return 0.0; }
        }
    }
}
