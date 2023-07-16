using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.BalanceValidator
{
    public class ClsBalanceValidator
    {

        public static decimal TruncateDecimals(decimal balance)
        {
            int decimales = 2;

            decimal aux_value = Convert.ToDecimal(Math.Pow(10, decimales));

            return (Math.Truncate(balance * aux_value) / aux_value);


        }


        public static bool isABalance(decimal balance)
        {
            if (balance < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



    }

}
