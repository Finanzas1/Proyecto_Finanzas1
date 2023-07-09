using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.Accounts
{


    public class ClsProfitAndLossStatementAccount : ClsAccount
    {
        

   

        public ClsProfitAndLossStatementAccount(string accountCode, string name, decimal balance, int internalCode) : base(accountCode, name, balance, internalCode)
        {
            Name = name;
            AccountCode = accountCode;
            Balance = balance;
            InternalCode = internalCode;
        
        }
    }
}
