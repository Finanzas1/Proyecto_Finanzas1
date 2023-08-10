using DataObject.Accounts;
using DataObject.AccountsCatalog;
using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.AccountsLogic
{
    public class ClsApplication
    {
        public static ClsBalanceSheetAccountsCatalog balanceSheetAcccounts = new ClsBalanceSheetAccountsCatalog();
        public static ClsProfitAndLossStatementAccountsCatalog profitAndLossStatementAccounts = new ClsProfitAndLossStatementAccountsCatalog();
  


        #region Balance sheet

        #region Current Assets methods

        public static int searchCurrentAssetWithName(string name)
        {
            return balanceSheetAcccounts.searchCurrentAssetWithName(name);
        }

        public static void addCurrentAsset(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addCurrentAsset(account);
        }

        public static void removeCurrentAsset(int index)
        {
            balanceSheetAcccounts.removeCurrentAsset(index);
        }

        public static void setCurrentAssetAt(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setCurrentAssetAt(index, account);
        }

        public static void clearCurrentAssets()
        {
            balanceSheetAcccounts.clearCurrentAssets();
        }

        public static decimal currentAssetsCalculateTotal(int period)
        {
            return balanceSheetAcccounts.currentAssetsCalculateTotal(period);
        }

        #endregion

        #region Non-Current Assets methods

        public static int searchNonCurrentAssetWithName(string name)
        {
            return balanceSheetAcccounts.searchNonCurrentAssetWithName(name);
        }

        public static void addNonCurrentAsset(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addNonCurrentAsset(account);
        }

        public static void removeNonCurrentAsset(int index)
        {
            balanceSheetAcccounts.removeNonCurrentAsset(index);
        }

        public static void setNonCurrentAssetAt(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setNonCurrentAssetAt(index, account);
        }

        public static void clearNonCurrentAssets()
        {
            balanceSheetAcccounts.clearNonCurrentAssets();
        }

        public static decimal nonCurrentAssetsCalculateTotal(int period)
        {
            return balanceSheetAcccounts.nonCurrentAssetsCalculateTotal(period);
        }

        #endregion

        #region Deferred assets methods

        public static int searchDeferredAssetWithName(string name)
        {
            return balanceSheetAcccounts.searchDeferredAssetWithName(name);
        }

        public static void addDeferredAsset(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addDeferredAsset(account);
        }

        public static void removeDeferredAsset(int index)
        {
            balanceSheetAcccounts.removeDeferredAsset(index);
        }

        public static void setDeferredAssetAt(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setDeferredAssetAt(index, account);
        }

        public static void clearDeferredAssets()
        {
            balanceSheetAcccounts.clearDeferredAssets();
        }

        public static decimal deferredAssetsCalculateTotal(int period)
        {
            return balanceSheetAcccounts.deferredAssetsCalculateTotal(period);
        }

        #endregion

        #region Short term liabilities methods

        public static int searchShortTermLiabilityWithName(string name)
        {
            return balanceSheetAcccounts.searchShortTermLiabilityWithName(name);
        }
        public static void addShortTermLiabilitie(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addShortTermLiabilitie(account);
        }

        public static void removeShortTermLiabilitie(int index)
        {
            balanceSheetAcccounts.removeShortTermLiabilitie(index);
        }

        public static void setShortTermLiabilitie(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setShortTermLiabilitieAt(index, account);
        }

        public static void clearShortTermLiabilities()
        {
            balanceSheetAcccounts.clearShortTermLiabilities();
        }

        public static decimal shortTermLiabilitiesCalculateTotal(int period)
        {
            return balanceSheetAcccounts.shortTermLiabilitiesCalculateTotal(period);
        }

        #endregion

        #region Long term liabilities methods

        public static int searchLongTermLiabilityWithName(string name)
        {
            return balanceSheetAcccounts.searchLongTermLiabilityWithName(name);
        }
        public static void addLongTermLiabilitie(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addLongTermLiabilitie(account);
        }

        public static void removeLongTermLiabilitie(int index)
        {
            balanceSheetAcccounts.removeLongTermLiabilitie(index);
        }

        public static void setLongTermLiabilitie(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setLongTermLiabilitieAt(index, account);
        }

        public static void clearLongTermLiabilities()
        {
            balanceSheetAcccounts.clearLongTermLiabilities();
        }

        public static decimal longTermLiabilitiesCalculateTotal(int period)
        {
            return balanceSheetAcccounts.longTermLiabilitiesCalculateTotal(period);
        }


        #endregion

        #region Stockholders' equity methods

        public static int searchStockholdersEquityWithName(string name)
        {
            return balanceSheetAcccounts.searchStockholderEquityWithName(name);
        }


        public static void addStockholdersEquity(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.addStockholdersEquity(account);
        }

        public static void removeStockholdersEquity(int index)
        {
            balanceSheetAcccounts.removeStockholdersEquity(index);
        }

        public static void setStockholdersEquity(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts.setStockholdersEquityAt(index, account);
        }

        public static void clearStockholdersEquities()
        {
            balanceSheetAcccounts.clearStockholdersEquities();
        }

        public static decimal StockholdersEquityCalculateTotal(int period)
        {
            return balanceSheetAcccounts.stockholdersEquitiesCalculateTotal(period);
        }


        #endregion

        #endregion


        #region Profit and loss statement 

        #region Sales Accounts Methods

        public static int searchSalesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchSalesAccountWithName(name);
        }

        public static decimal salesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.salesAccountsCalculateTotal(period);
        }



        #endregion

        #region Financial Products Accounts Methods

        public static int searchFinancialProductsAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchFinancialProductsAccountWithName(name);
        }

        public static decimal financialProductsAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.financialProductsAccountsCalculateTotal(period);
        }

        #endregion

        #region Other Revenues Accounts Methods


        public static int searchOtherRevenuesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchOtherRevenuesAccountWithName(name);
        }

        public static decimal otherRevenuesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.otherRevenuesAccountsCalculateTotal(period);
        }

        #endregion

        #region Other Products Accounts Methods


        public static int searchOtherProductAccountWithName(string name)
        {
         
            return profitAndLossStatementAccounts.searchOtherProductAccountWithName(name);
        }

        public static decimal otherProductsAccountsCalculateTotal(int period)
        {

            return profitAndLossStatementAccounts.otherProductsAccountsCalculateTotal(period);
        }


        #endregion

        #region Costs Accounts Methods

        public static int searchCostsAccountWithName(string name)
        {
   
            return profitAndLossStatementAccounts.searchCostsAccountWithName(name);
            
        }

        public static decimal costsAccountsCalculateTotal(int period)
        {

            return profitAndLossStatementAccounts .costsAccountsCalculateTotal(period);
        }

        #endregion

        #region Sales Expenses Accounts Methods


        public static int searchSalesExpensesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchSalesExpensesAccountWithName (name);
        }

        public static decimal salesExpensesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.salesExpensesAccountsCalculateTotal(period);
        }



        #endregion

        #region Administrative Expenses Accounts Methods

        public static int searchAdministrativeExpensesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchAdministrativeExpensesAccountWithName(name);
        }

        public static decimal administrativeExpensesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.administrativeExpensesAccountsCalculateTotal(period);
        }

        #endregion

        #region Financial Expenses Accounts Methods

        public static int searchFinancialExpensesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchFinancialExpensesAccountWithName(name) ;
        }

        public static decimal financialExpensesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.financialExpensesAccountsCalculateTotal(period) ;
        }


        #endregion

        #region Other Expenses Accounts Methods


        public static int searchOtherExpensesAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchOtherExpensesAccountWithName(name);
        }

        public static decimal otherExpensesAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.otherExpensesAccountsCalculateTotal(period) ;
        }


        #endregion

        #region Profit Statement Accounts Methods

        public static int searchProfitStatementAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchProfitStatementAccountWithName(name);
        }

        public static decimal profitStatementAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.profitStatementAccountsCalculateTotal(period);
                
        }


        #endregion

        #region Miscellaneous Accounts methods

        public static int searchMiscellaneousAccountWithName(string name)
        {
            return profitAndLossStatementAccounts.searchMiscellaneousAccountWithName(name);
        }

        public static decimal miscellaneousAccountsCalculateTotal(int period)
        {
            return profitAndLossStatementAccounts.miscellaneousAccountsCalculateTotal(period);

        }

        #endregion

        #endregion





        //Sort using Account name Profit and Loss statement 
        public static int ProfitAndLossAccountType(string name)
        {
            return profitAndLossStatementAccounts.accountType(name);
        }

        //Sort using account name Balance Sheet
        public static int balanceSheetAccountType(string name)
        {
            return balanceSheetAcccounts.accountType(name);
        }


    }
}
