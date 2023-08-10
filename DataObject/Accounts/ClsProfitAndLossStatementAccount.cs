using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.Accounts
{

    public enum ProfitAndLossAccountType { SALE, FINANCIAL_PRODUCT, OTHER_REVENUE, OTHER_PRODUCT, COST, SALES_EXPENSES, ADMINISTRATIVE_EXPENSES, FINANCIAL_EXPENSES, OTHER_EXPENSES,
    PROFIT_STATEMENT, MISCELLANEOUS}

    public class ClsProfitAndLossStatementAccount : ClsAccount
    {
        
        ProfitAndLossAccountType profitAndLossAccountType;

        public ClsProfitAndLossStatementAccount()
        {
        }

        public ClsProfitAndLossStatementAccount(string accountCode, string name, decimal balance, int internalCode, ProfitAndLossAccountType profitAndLossAccountType) : base(accountCode, name, internalCode)
        {
            Name = name;
            AccountCode = accountCode;
            InternalCode = internalCode;
            ProfitAndLossAccountType = profitAndLossAccountType;
        }

        public ProfitAndLossAccountType ProfitAndLossAccountType { get => profitAndLossAccountType; set => profitAndLossAccountType = value; }




    }
}
