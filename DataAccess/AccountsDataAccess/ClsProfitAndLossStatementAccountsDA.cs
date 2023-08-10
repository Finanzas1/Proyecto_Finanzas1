using DataObject.Accounts;
using DataObject.AccountsCatalog;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccess.AccountsDataAccess
{
    public class ClsProfitAndLossStatementAccountsDA
    {
        private string filePath = "F:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\ProfitAndLossStatementAccounts.xlsx";
       


        public ClsProfitAndLossStatementAccountsDA() { }


        public void  saveAccountNewBalance(ClsProfitAndLossStatementAccount account, decimal balance, int period)
        {
            SLDocument myDocument = new SLDocument(filePath);

            int iRow = 2;
                                    
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.SALE)
            {
                myDocument.SelectWorksheet("Sales");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period-1] = balance;
                            return;

                        }
                        else if(period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                        
                    }


                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.FINANCIAL_PRODUCT)
            {
                myDocument.SelectWorksheet("FinancialProducts");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {


                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }


                    }

                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.OTHER_REVENUE)
            {
                myDocument.SelectWorksheet("OtherRevenues");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {


                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }


                    }


                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.OTHER_PRODUCT)
            {

                myDocument.SelectWorksheet("OtherProducts");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {


                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }


                    }


                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.COST)
            {

                myDocument.SelectWorksheet("Costs");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {


                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }


                    }

                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.SALES_EXPENSES)
            {

                myDocument.SelectWorksheet("SalesExpenses");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {


                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }


                    }


                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.ADMINISTRATIVE_EXPENSES)
            {

                myDocument.SelectWorksheet("AdministrativeExpenses");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                    }

                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.FINANCIAL_EXPENSES)
            {

                myDocument.SelectWorksheet("FinancialExpenses");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                    }

                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.OTHER_EXPENSES)
            {

                myDocument.SelectWorksheet("OtherExpenses");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                    }
                    iRow++;
                }

            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.MISCELLANEOUS)
            {
                myDocument.SelectWorksheet("Miscellaneous");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                    }
                    iRow++;
                }
            }
            else
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.PROFIT_STATEMENT)
            {
                myDocument.SelectWorksheet("OtherExpenses");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {

                        if (period == 1)
                        {
                            myDocument.SetCellValue(iRow, 4, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;

                        }
                        else if (period == 2)
                        {
                            myDocument.SetCellValue(iRow, 5, balance);
                            myDocument.Save();
                            account.Balance[period - 1] = balance;
                            return;
                        }
                        else
                        {
                            Console.WriteLine("No existe tal periodo!");
                            throw new ArgumentOutOfRangeException(
                            nameof(period),
                            "Solo existen 2 periodos!"
                            );
                        }

                    }
                    iRow++;
                }
            }

        }

      
        public ClsProfitAndLossStatementAccountsCatalog openAccounts()
        {
            int iRow = 2;

            ClsProfitAndLossStatementAccountsCatalog catalog = new ClsProfitAndLossStatementAccountsCatalog();

            try
            {
                SLDocument myDocument = new SLDocument(filePath);


                myDocument.SelectWorksheet("Sales");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.SALE;

                    catalog.addSalesAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("FinancialProducts");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.FINANCIAL_PRODUCT;

                    catalog.addFinancialProductsAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("OtherRevenues");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.OTHER_REVENUE;

                    catalog.addOtherRevenuesAccount(account);

                    iRow++;
                }

                iRow = 2;
                myDocument.SelectWorksheet("OtherProducts");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.OTHER_PRODUCT;

                    catalog.addOtherProductsAccount(account);

                    iRow++;
                }

                iRow = 2;
                myDocument.SelectWorksheet("Costs");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.COST;

                    catalog.addCostsAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("SalesExpenses");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.SALES_EXPENSES;

                    catalog.addSalesExpensesAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("AdministrativeExpenses");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.ADMINISTRATIVE_EXPENSES;

                    catalog.addAdministrativeExpensesAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("FinancialExpenses");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.FINANCIAL_EXPENSES;

                    catalog.addFinancialExpensesAccount(account);

                    iRow++;
                }


                iRow = 2;
                myDocument.SelectWorksheet("OtherExpenses");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.OTHER_EXPENSES;

                    catalog.addOtherExpensesAccount(account);

                    iRow++;
                }

                iRow = 2;
                myDocument.SelectWorksheet("Miscellaneous");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.MISCELLANEOUS;

                    catalog.addMiscellaneousAccount(account);

                    iRow++;
                }



                iRow = 2;
                myDocument.SelectWorksheet("ProfitStatements");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.Balance[1] = myDocument.GetCellValueAsDecimal(iRow, 5);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.PROFIT_STATEMENT;

                    catalog.addProfitStatementAccount(account);

                    iRow++;
                }



                return catalog;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return null;
            }

        }

     

    }

    

    
}
