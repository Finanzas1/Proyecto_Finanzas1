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
        private string filePath1 = "F:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\ProfitAndLossStatementAccountsPeriod1.xlsx";
        private string filePath2 = "F:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\ProfitAndLossStatementAccountsPeriod2.xlsx";   


        public ClsProfitAndLossStatementAccountsDA() { }


        public decimal saveAccountNewBalancePeriod1(ClsProfitAndLossStatementAccount account, decimal balance)
        {
            SLDocument myDocument = new SLDocument(filePath1);
            int iRow = 2;
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.SALE)
            {

                myDocument.SelectWorksheet("Sales");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
                    }


                    iRow++;
                }

            }


            return -1;

        }

        public decimal saveAccountNewBalancePeriod2(ClsProfitAndLossStatementAccount account, decimal balance)
        {
            SLDocument myDocument = new SLDocument(filePath2);
            int iRow = 2;
            if (account.ProfitAndLossAccountType == ProfitAndLossAccountType.SALE)
            {

                myDocument.SelectWorksheet("Sales");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    if (account.InternalCode == Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1)))
                    {
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
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
                        myDocument.SetCellValue(iRow, 4, balance);
                        myDocument.Save();

                        return balance;
                    }


                    iRow++;
                }


            }
            return -1;

        }

        public ClsProfitAndLossStatementAccountsCatalog openAccountsPeriod1()
        {
            int iRow = 2;

            ClsProfitAndLossStatementAccountsCatalog catalog = new ClsProfitAndLossStatementAccountsCatalog();

            try
            {
                SLDocument myDocument = new SLDocument(filePath1);


                myDocument.SelectWorksheet("Sales");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.OTHER_EXPENSES;

                    catalog.addOtherExpensesAccount(account);

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

        public ClsProfitAndLossStatementAccountsCatalog openAccountsPeriod2()
        {
            int iRow = 2;

            ClsProfitAndLossStatementAccountsCatalog catalog = new ClsProfitAndLossStatementAccountsCatalog();

            try
            {
                SLDocument myDocument = new SLDocument(filePath2);


                myDocument.SelectWorksheet("Sales");
                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsProfitAndLossStatementAccount account = new ClsProfitAndLossStatementAccount();

                    account.InternalCode = myDocument.GetCellValueAsInt32(iRow, 1);
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
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
                    account.Balance = myDocument.GetCellValueAsDecimal(iRow, 4);
                    account.ProfitAndLossAccountType = ProfitAndLossAccountType.OTHER_EXPENSES;

                    catalog.addOtherExpensesAccount(account);

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
