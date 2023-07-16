using DataObject.Accounts;
using DataObject.AccountsCatalog;
using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Windows.Forms;

namespace DataAccess.AccountsDataAccess
{
    public class ClsBalanceSheetAccountsDA
    {

        string filePath1 = "D:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\BalanceSheetAccountsPeriod1.xlsx";
        string filePath2 = "D:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\BalanceSheetAccountsPeriod2.xlsx";


        public ClsBalanceSheetAccountsDA() { }

        public Decimal saveAccountNewBalancePeriod1(ClsBalanceSheetAccount account, decimal balance)
        {

            SLDocument myDocument = new SLDocument(filePath1);
            int iRow = 2;
            if (account.AccountType == AccountType.CURRENT_ASSET)
            {

                myDocument.SelectWorksheet("CurrentAssets");

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
            if (account.AccountType == AccountType.NONCURRENT_ASSET)
            {
                myDocument.SelectWorksheet("NonCurrentAssets");

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
            if (account.AccountType == AccountType.DEFERRED_ASSET)
            {
                myDocument.SelectWorksheet("DeferredAssets");

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
            if (account.AccountType == AccountType.SHORT_TERM_LIABILITIE)
            {
                
                myDocument.SelectWorksheet("ShortTermLiabilities");

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
            if (account.AccountType == AccountType.LONG_TERM_LIABILITIE)
            {
           
                myDocument.SelectWorksheet("LongTermLiabilities");

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
            if (account.AccountType == AccountType.STOCKHOLDERS_EQUITY)
            {
          
                myDocument.SelectWorksheet("StockholdersEquity");

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

            return 0;
        }

        public Decimal saveAccountNewBalancePeriod2(ClsBalanceSheetAccount account, decimal balance)
        {
            SLDocument myDocument = new SLDocument(filePath2);
            int iRow = 2;
            if (account.AccountType == AccountType.CURRENT_ASSET)
            {

                myDocument.SelectWorksheet("CurrentAssets");

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
            if (account.AccountType == AccountType.NONCURRENT_ASSET)
            {
                myDocument.SelectWorksheet("NonCurrentAssets");

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
            if (account.AccountType == AccountType.DEFERRED_ASSET)
            {
                myDocument.SelectWorksheet("DeferredAssets");

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
            if (account.AccountType == AccountType.SHORT_TERM_LIABILITIE)
            {
               
                myDocument.SelectWorksheet("ShortTermLiabilities");

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
            if (account.AccountType == AccountType.LONG_TERM_LIABILITIE)
            {
            
                myDocument.SelectWorksheet("LongTermLiabilities");

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
            if (account.AccountType == AccountType.STOCKHOLDERS_EQUITY)
            {
               
                myDocument.SelectWorksheet("StockholdersEquity");

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

            return 0;

        }


        public ClsBalanceSheetAccountsCatalog openAccounts1()
        {


            int iRow = 2;
            ClsBalanceSheetAccountsCatalog catalog = new ClsBalanceSheetAccountsCatalog();


            try
            {
                SLDocument myDocument = new SLDocument(filePath1);


                myDocument.SelectWorksheet("CurrentAssets");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.CURRENT_ASSET;
                    catalog.addCurrentAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("NonCurrentAssets");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.NONCURRENT_ASSET;
                    catalog.addNonCurrentAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("DeferredAssets");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.DEFERRED_ASSET;
                    catalog.addDeferredAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("ShortTermLiabilities");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.SHORT_TERM_LIABILITIE;
                    catalog.addShortTermLiabilitie(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("LongTermLiabilities");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.LONG_TERM_LIABILITIE;
                    catalog.addLongTermLiabilitie(account);
                    iRow++;
                }



                myDocument.SelectWorksheet("StockholdersEquity");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.STOCKHOLDERS_EQUITY;
                    catalog.addStockholdersEquity(account);
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

        public ClsBalanceSheetAccountsCatalog openAccounts2()
        {



            int iRow = 2;
            ClsBalanceSheetAccountsCatalog catalog = new ClsBalanceSheetAccountsCatalog();


            try
            {
                SLDocument myDocument = new SLDocument(filePath2);


                myDocument.SelectWorksheet("CurrentAssets");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.CURRENT_ASSET;
                    catalog.addCurrentAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("NonCurrentAssets");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.NONCURRENT_ASSET;
                    catalog.addNonCurrentAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("DeferredAssets");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.DEFERRED_ASSET;
                    catalog.addDeferredAsset(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("ShortTermLiabilities");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.SHORT_TERM_LIABILITIE;
                    catalog.addShortTermLiabilitie(account);
                    iRow++;
                }

                myDocument.SelectWorksheet("LongTermLiabilities");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.LONG_TERM_LIABILITIE;
                    catalog.addLongTermLiabilitie(account);
                    iRow++;
                }



                myDocument.SelectWorksheet("StockholdersEquity");

                iRow = 2;

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.AccountType = AccountType.STOCKHOLDERS_EQUITY;
                    catalog.addStockholdersEquity(account);
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
