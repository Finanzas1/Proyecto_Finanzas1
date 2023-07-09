using DataObject.Accounts;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.AccountsDataAccess
{
    public class ClsProfitAndLossStatementAccountsDA
    {
        private string filePath;


        public ClsProfitAndLossStatementAccountsDA() { }



        public ClsProfitAndLossStatementAccount saveAccountNewBalancePeriod1(ClsProfitAndLossStatementAccount account, decimal balance)
        {
            SLDocument doc = new SLDocument(filePath);

            account.Balance = balance;

            int iRow = 3;

            while (iRow < 28)
            {
                if (account.AccountCode == doc.GetCellValueAsString(iRow, 2))
                {
                    doc.SetCellValueNumeric(iRow, 4, balance.ToString());
                }
            }

            return account;


        }

        public ClsProfitAndLossStatementAccount saveAccountNewBalancePeriod2(ClsProfitAndLossStatementAccount account, decimal balance)
        {
            SLDocument doc = new SLDocument(filePath);

            account.Balance = balance;

            int iRow = 3;

            while (iRow < 28)
            {
                if (account.AccountCode == doc.GetCellValueAsString(iRow, 7))
                {
                    doc.SetCellValueNumeric(iRow, 9, balance.ToString());
                }
            }

            return account;


        }




        public List<ClsProfitAndLossStatementAccount> openCatalog1Period()
        {
            int iRow = 3;
         
            List<ClsProfitAndLossStatementAccount> accounts = new List<ClsProfitAndLossStatementAccount>();

            try
            {
                SLDocument myDocument = new SLDocument();

                while(iRow < 28)
                {
                    int internalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    string accountCode = myDocument.GetCellValueAsString(iRow, 2);
                    string accountName = myDocument.GetCellValueAsString(iRow, 3);
                    decimal balance = myDocument.GetCellValueAsDecimal(iRow, 4);

                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount(accountCode, accountName, balance, internalCode);

                    accounts.Add(account);


                    iRow++;
                }

            }catch (Exception ex)
            {

            }

            return accounts;

        }


        public List<ClsProfitAndLossStatementAccount> openCatalog2Period()
        {
            int iRow = 3;

            List<ClsProfitAndLossStatementAccount> accounts = new List<ClsProfitAndLossStatementAccount>();

            try
            {
                SLDocument myDocument = new SLDocument();

                while (iRow < 28)
                {
                    int internalCode = myDocument.GetCellValueAsInt32(iRow, 6);
                    string accountCode = myDocument.GetCellValueAsString(iRow, 7);
                    string accountName = myDocument.GetCellValueAsString(iRow, 8);
                    decimal balance = myDocument.GetCellValueAsDecimal(iRow, 9);

                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount(accountCode, accountName, balance, internalCode);

                    accounts.Add(account);


                    iRow++;
                }

            }
            catch (Exception ex)
            {

            }

            return accounts;

        }

    }
}
