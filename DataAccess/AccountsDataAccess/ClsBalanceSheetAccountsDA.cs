using DataObject.Accounts;
using DataObject.AccountsCatalog;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.AccountsDataAccess
{
    public class ClsBalanceSheetAccountsDA
    {
        private string filePath;

        public ClsBalanceSheetAccountsDA() { }

        public ClsBalanceSheetAccount saveAccountNewBalancePeriod1(ClsBalanceSheetAccount account, decimal balance) 
        {
            SLDocument doc = new SLDocument(filePath);
            
            account.Balance = balance;

            int iRow = 3;

            while (iRow < 90)
            {
                if(account.AccountCode == doc.GetCellValueAsString(iRow, 4))
                {
                    doc.SetCellValueNumeric(iRow, 5, balance.ToString());
                }
            }

            return account;


        }

        public ClsBalanceSheetAccount saveAccountNewBalancePeriod2(ClsBalanceSheetAccount account, decimal balance)
        {
            SLDocument doc = new SLDocument(filePath);

            account.Balance = balance;

            int iRow = 3;

            while (iRow < 90)
            {
                if (account.AccountCode == doc.GetCellValueAsString(iRow, 10))
                {
                    doc.SetCellValueNumeric(iRow, 13, balance.ToString());
                }
            }

            return account;


        }


        public ClsBalanceSheetAccountsCatalog openAccounts1()
        {


            int iRow = 3;
            ClsBalanceSheetAccountsCatalog catalog = new ClsBalanceSheetAccountsCatalog();


            try
            {
                SLDocument myDocument = new SLDocument(filePath);


                while (iRow<90)
                {
                    if(iRow>=3 && iRow <= 21)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.CURRENT_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode ,accountName, balance);    
                        
                        catalog.addCurrentAsset(account);
                    
                    }else if(iRow>=24 && iRow <= 38)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.NONCURRENT_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addNonCurrentAsset(account);

                    }else if(iRow>=41 && iRow<=52)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.DEFFERED_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addDeferredAsset(account);


                    }else if (iRow>=58 && iRow <= 71)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.SHORT_TERM_LIABILITIE;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addShortTermLiabilitie(account);

                    }else if (iRow>=74 && iRow <= 79)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.LONG_TERM_LIABILITIE;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addLongTermLiabilitie(account);

                    }else if(iRow>=85 && iRow <= 89)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 3);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 4);
                        string accountName = myDocument.GetCellValueAsString(iRow, 5);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 6);
                        TipoCuenta tipoCuenta = TipoCuenta.STOCKHOLDERS_EQUITY;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addStockholdersEquity(account);

                    }



                    iRow++;
                }

                return catalog;



            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
                return null;
            }
           


        }

        public ClsBalanceSheetAccountsCatalog openAccounts2()
        {


            int iRow = 3;
            ClsBalanceSheetAccountsCatalog catalog = new ClsBalanceSheetAccountsCatalog();


            try
            {
                SLDocument myDocument = new SLDocument(filePath);


                while (iRow < 90)
                {
                    if (iRow >= 3 && iRow <= 21)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.CURRENT_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addCurrentAsset(account);

                    }
                    else if (iRow >= 24 && iRow <= 38)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.NONCURRENT_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addNonCurrentAsset(account);

                    }
                    else if (iRow >= 41 && iRow <= 52)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.DEFFERED_ASSET;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addDeferredAsset(account);


                    }
                    else if (iRow >= 58 && iRow <= 71)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.SHORT_TERM_LIABILITIE;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addShortTermLiabilitie(account);

                    }
                    else if (iRow >= 74 && iRow <= 79)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.LONG_TERM_LIABILITIE;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addLongTermLiabilitie(account);

                    }
                    else if (iRow >= 85 && iRow <= 89)
                    {
                        int internalCode = myDocument.GetCellValueAsInt32(iRow, 10);
                        string accountCode = myDocument.GetCellValueAsString(iRow, 11);
                        string accountName = myDocument.GetCellValueAsString(iRow, 12);
                        decimal balance = myDocument.GetCellValueAsDecimal(iRow, 13);
                        TipoCuenta tipoCuenta = TipoCuenta.STOCKHOLDERS_EQUITY;

                        ClsBalanceSheetAccount account = new ClsBalanceSheetAccount(tipoCuenta, accountCode, internalCode, accountName, balance);

                        catalog.addStockholdersEquity(account);

                    }



                    iRow++;
                }

                return catalog;



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }



        }

    }
}
