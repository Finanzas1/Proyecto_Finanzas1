using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.Accounts
{


    public enum AccountType
    {
        [Description("Activo corriente")]CURRENT_ASSET = 1, [Description("Activo fijo")]NONCURRENT_ASSET = 2 ,
        [Description("Activo diferido")]DEFERRED_ASSET = 3,
        [Description("Pasivo C/P")]SHORT_TERM_LIABILITIE = 4, [Description("Pasivo L/P")]LONG_TERM_LIABILITIE = 5, 
        [Description("Capital contable")]STOCKHOLDERS_EQUITY = 6
    }


    public class ClsBalanceSheetAccount : ClsAccount
    {
        private AccountType accountType;

        public AccountType AccountType { get => accountType; set => accountType = value; }

        public ClsBalanceSheetAccount(AccountType tipocuenta, string accountCode, int internalCode, string name, decimal balance) : base(accountCode, name, internalCode)
        {
            Name = name;
            AccountCode = accountCode;
            InternalCode = internalCode;
            AccountType = tipocuenta;
        }

        public ClsBalanceSheetAccount()
        {
        }
    }
}
