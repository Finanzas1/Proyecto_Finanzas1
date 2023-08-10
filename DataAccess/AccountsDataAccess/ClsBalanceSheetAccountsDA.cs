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

        string filePath = "F:\\Programacion DATA\\Finance 1\\Proyecto_Finanzas1\\Resources\\DataAccess\\BalanceSheetAccounts.xlsx";



        public ClsBalanceSheetAccountsDA() { }


        public void saveAccountNewBalance(ClsBalanceSheetAccount account, decimal balance, int period)
        {
            SLDocument myDocument = new SLDocument(filePath);


            int iRow = 2;


            if (account.AccountType == AccountType.CURRENT_ASSET)
            {
                myDocument.SelectWorksheet("CurrentAssets");

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

            if (account.AccountType == AccountType.NONCURRENT_ASSET)
            {
                myDocument.SelectWorksheet("NonCurrentAssets");

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
            if (account.AccountType == AccountType.DEFERRED_ASSET)
            {
                myDocument.SelectWorksheet("DeferredAssets");

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
            if (account.AccountType == AccountType.SHORT_TERM_LIABILITIE)
            {
                myDocument.SelectWorksheet("ShortTermLiabilites");

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
            if (account.AccountType == AccountType.LONG_TERM_LIABILITIE)
            {
                myDocument.SelectWorksheet("LongTermLiabilities");

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
             if (account.AccountType == AccountType.STOCKHOLDERS_EQUITY)
            {
                myDocument.SelectWorksheet("StockholdersEquity");

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



        public ClsBalanceSheetAccountsCatalog openAccounts()
        {


            int iRow = 2;
            ClsBalanceSheetAccountsCatalog catalog = new ClsBalanceSheetAccountsCatalog();


            try
            {
                SLDocument myDocument = new SLDocument(filePath);


                myDocument.SelectWorksheet("CurrentAssets");

                while (!string.IsNullOrEmpty(myDocument.GetCellValueAsString(iRow, 1)))
                {
                    ClsBalanceSheetAccount account = new ClsBalanceSheetAccount();

                    account.InternalCode = Convert.ToInt32(myDocument.GetCellValueAsString(iRow, 1));
                    account.AccountCode = myDocument.GetCellValueAsString(iRow, 2);
                    account.Name = myDocument.GetCellValueAsString(iRow, 3);
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
                    account.Balance[0] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 4));
                    account.Balance[1] = Convert.ToDecimal(myDocument.GetCellValueAsString(iRow, 5));
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
