using DataObject.Accounts;
using DataObject.AccountsCatalog;
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
        public static ClsBalanceSheetAccountsCatalog balanceSheetAcccountsPeriod1 = new ClsBalanceSheetAccountsCatalog();
        public static ClsBalanceSheetAccountsCatalog balanceSheetAcccountsPeriod2 = new ClsBalanceSheetAccountsCatalog();
        public static ClsProfitAndLossStatementAccountsCatalog profitAndLossStatementAccountsPeriod1 = new ClsProfitAndLossStatementAccountsCatalog();
        public static ClsProfitAndLossStatementAccountsCatalog profitAndLossStatementAccountsPeriod2 = new ClsProfitAndLossStatementAccountsCatalog();


        #region Balance sheet


        #region Balance Sheet accounts period 1 catalog methods


        #region Current Assets methods

        public static int searchCurrentAsset1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchCurrentAssetWithName(name);
        }

        public static void addCurrentAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addCurrentAsset(account);
        }

        public static void removeCurrentAsset1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeCurrentAsset(index);
        }

        public static void setCurrentAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setCurrentAssetAt(index, account);
        }

        public static void clearCurrentAssets1Period()
        {
            balanceSheetAcccountsPeriod1.clearCurrentAssets();
        }

        public static decimal currentAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.currentAssetsCalculateTotal();
        }

        #endregion

        #region Non-Current Assets methods

        public static int searchNonCurrentAsset1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchNonCurrentAssetWithName(name);
        }

        public static void addNonCurrentAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addNonCurrentAsset(account);
        }

        public static void removeNonCurrentAsset1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeNonCurrentAsset(index);
        }

        public static void setNonCurrentAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setNonCurrentAssetAt(index, account);
        }

        public static void clearNonCurrentAssets1Period()
        {
            balanceSheetAcccountsPeriod1.clearNonCurrentAssets();
        }

        public static decimal nonCurrentAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.nonCurrentAssetsCalculateTotal();
        }

        #endregion

        #region Deferred assets methods

        public static int searchDeferredAsset1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchDeferredAssetWithName(name);
        }

        public static void addDeferredAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addDeferredAsset(account);
        }

        public static void removeDeferredAsset1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeDeferredAsset(index);
        }

        public static void setDeferredAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setDeferredAssetAt(index, account);
        }

        public static void clearComplementaryAssets1Period()
        {
            balanceSheetAcccountsPeriod1.clearDeferredAssets();
        }

        public static decimal deferredAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.deferredAssetsCalculateTotal();
        }

        #endregion

        #region Short term liabilities methods

        public static int searchShortTermLiability1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchShortTermLiabilityWithName(name);
        }
        public static void addShortTermLiabilitie1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addShortTermLiabilitie(account);
        }

        public static void removeShortTermLiabilitie1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeShortTermLiabilitie(index);
        }

        public static void setShortTermLiabilitie1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setShortTermLiabilitieAt(index, account);
        }

        public static void clearShortTermLiabilities1Period()
        {
            balanceSheetAcccountsPeriod1.clearShortTermLiabilities();
        }

        public static decimal shortTermLiabilitiesCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.shortTermLiabilitiesCalculateTotal();
        }

        #endregion

        #region Long term liabilities methods

        public static int searchLongTermLiability1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchLongTermLiabilityWithName(name);
        }
        public static void addLongTermLiabilitie1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addLongTermLiabilitie(account);
        }

        public static void removeLongTermLiabilitie1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeLongTermLiabilitie(index);
        }

        public static void setLongTermLiabilitie1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setLongTermLiabilitieAt(index, account);
        }

        public static void clearLongTermLiabilities1Period()
        {
            balanceSheetAcccountsPeriod1.clearLongTermLiabilities();
        }

        public static decimal longTermLiabilitiesCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.longTermLiabilitiesCalculateTotal();
        }


        #endregion

        #region Stockholders' equity methods

        public static int searchStockholdersEquity1PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchStockholderEquityWithName(name);
        }


        public static void addStockholdersEquity1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.addStockholdersEquity(account);
        }

        public static void removeStockholdersEquity1Period(int index)
        {
            balanceSheetAcccountsPeriod1.removeStockholdersEquity(index);
        }

        public static void setStockholdersEquity1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod1.setStockholdersEquityAt(index, account);
        }

        public static void clearStockholdersEquities1Period()
        {
            balanceSheetAcccountsPeriod1.clearStockholdersEquities();
        }

        public static decimal StockholdersEquityCalculateTotal1Period()
        {
            return balanceSheetAcccountsPeriod1.stockholdersEquitiesCalculateTotal();
        }


        #endregion


        #endregion

        #region Balance Sheet accounts period 2 catalog methods


        #region Current Assets methods

        public static int searchCurrentAsset2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod2.searchCurrentAssetWithName(name);
        }

        public static void addCurrentAsset2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addCurrentAsset(account);
        }

        public static void removeCurrentAsset2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeCurrentAsset(index);
        }

        public static void setCurrentAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setCurrentAssetAt(index, account);
        }

        public static void clearCurrentAssets2Period()
        {
            balanceSheetAcccountsPeriod2.clearCurrentAssets();
        }

        public static decimal currentAssetsCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.currentAssetsCalculateTotal();
        }

        #endregion

        #region Non-Current Assets methods

        public static int searchNonCurrentAsset2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod2.searchNonCurrentAssetWithName(name);
        }


        public static void addNonCurrentAsset2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addNonCurrentAsset(account);
        }

        public static void removeNonCurrentAsset2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeNonCurrentAsset(index);
        }

        public static void setNonCurrentAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setNonCurrentAssetAt(index, account);
        }

        public static void clearNonCurrentAssets2Period()
        {
            balanceSheetAcccountsPeriod2.clearNonCurrentAssets();
        }

        public static decimal nonCurrentAssetsCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.nonCurrentAssetsCalculateTotal();
        }

        #endregion

        #region Deferred assets methods

        public static int searchDeferredAsset2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod2.searchDeferredAssetWithName(name);
        }

        public static void addDeferredAsset2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addDeferredAsset(account);
        }

        public static void removeDeferredAsset2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeDeferredAsset(index);
        }

        public static void setDeferredAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setDeferredAssetAt(index, account);
        }

        public static void clearComplementaryAssets2Period()
        {
            balanceSheetAcccountsPeriod2.clearDeferredAssets();
        }

        public static decimal deferredAssetsCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.deferredAssetsCalculateTotal();
        }

        #endregion

        #region Short term liabilities methods


        public static int searchShortTermLiability2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod1.searchShortTermLiabilityWithName(name);
        }

        public static void addShortTermLiabilitie2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addShortTermLiabilitie(account);
        }

        public static void removeShortTermLiabilitie2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeShortTermLiabilitie(index);
        }

        public static void setShortTermLiabilitie2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setShortTermLiabilitieAt(index, account);
        }

        public static void clearShortTermLiabilities2Period()
        {
            balanceSheetAcccountsPeriod2.clearShortTermLiabilities();
        }

        public static decimal shortTermLiabilitiesCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.shortTermLiabilitiesCalculateTotal();
        }

        #endregion

        #region Long term liabilities methods


        public static int searchLongTermLiability2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod2.searchLongTermLiabilityWithName(name);
        }

        public static void addLongTermLiabilitie2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addLongTermLiabilitie(account);
        }

        public static void removeLongTermLiabilitie2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeLongTermLiabilitie(index);
        }

        public static void setLongTermLiabilitie2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setLongTermLiabilitieAt(index, account);
        }

        public static void clearLongTermLiabilities2Period()
        {
            balanceSheetAcccountsPeriod2.clearLongTermLiabilities();
        }

        public static decimal longTermLiabilitiesCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.longTermLiabilitiesCalculateTotal();
        }


        #endregion

        #region Stockholders' equity methods

        public static int searchStockholdersEquity2PeriodWithName(string name)
        {
            return balanceSheetAcccountsPeriod2.searchStockholderEquityWithName(name);
        }


        public static void addStockholdersEquity2Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.addStockholdersEquity(account);
        }

        public static void removeStockholdersEquity2Period(int index)
        {
            balanceSheetAcccountsPeriod2.removeStockholdersEquity(index);
        }

        public static void setStockholdersEquity2Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccountsPeriod2.setStockholdersEquityAt(index, account);
        }

        public static void clearStockholdersEquities2Period()
        {
            balanceSheetAcccountsPeriod2.clearStockholdersEquities();
        }

        public static decimal StockholdersEquityCalculateTotal2Period()
        {
            return balanceSheetAcccountsPeriod2.stockholdersEquitiesCalculateTotal();
        }


        #endregion


        #endregion

        #endregion







        #region Profit and loss statement 

        #region Profit and loss statement period 1 catalog methods


        #region Sales Accounts Methods

        public static int searchSalesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchSalesAccountWithName(name);
        }

        public static decimal salesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.salesAccountsCalculateTotal();
        }



        #endregion

        #region Financial Products Accounts Methods

        public static int searchFinancialProductsAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchFinancialProductsAccountWithName(name);
        }

        public static decimal financialProductsAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.financialProductsAccountsCalculateTotal();
        }

        #endregion

        #region Other Revenues Accounts Methods


        public static int searchOtherRevenuesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchOtherRevenuesAccountWithName(name);
        }

        public static decimal otherRevenuesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.otherRevenuesAccountsCalculateTotal();
        }

        #endregion

        #region Other Products Accounts Methods


        public static int searchOtherProductAccountWithNamePeriod1(string name)
        {
         
            return profitAndLossStatementAccountsPeriod1.searchOtherProductAccountWithName(name);
        }

        public static decimal otherProductsAccountsCalculateTotalPeriod1()
        {

            return profitAndLossStatementAccountsPeriod1.otherProductsAccountsCalculateTotal();
        }


        #endregion

        #region Costs Accounts Methods

        public static int searchCostsAccountWithNamePeriod1(string name)
        {
   
            return profitAndLossStatementAccountsPeriod1.searchCostsAccountWithName(name);
            
        }

        public static decimal costsAccountsCalculateTotalPeriod1()
        {

            return profitAndLossStatementAccountsPeriod1 .costsAccountsCalculateTotal();
        }

        #endregion

        #region Sales Expenses Accounts Methods


        public static int searchSalesExpensesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchSalesExpensesAccountWithName (name);
        }

        public static decimal salesExpensesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.salesExpensesAccountsCalculateTotal();
        }



        #endregion

        #region Administrative Expenses Accounts Methods

        public static int searchAdministrativeExpensesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchAdministrativeExpensesAccountWithName(name);
        }

        public static decimal administrativeExpensesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.administrativeExpensesAccountsCalculateTotal ();
        }

        #endregion

        #region Financial Expenses Accounts Methods

        public static int searchFinancialExpensesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchFinancialExpensesAccountWithName(name) ;
        }

        public static decimal financialExpensesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.financialExpensesAccountsCalculateTotal() ;
        }


        #endregion

        #region Other Expenses Accounts Methods


        public static int searchOtherExpensesAccountWithNamePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.searchOtherExpensesAccountWithName(name);
        }

        public static decimal otherExpensesAccountsCalculateTotalPeriod1()
        {
            return profitAndLossStatementAccountsPeriod1.otherExpensesAccountsCalculateTotal () ;
        }


        #endregion

        #region 

        #endregion

        #region Profit and loss statement period 2 catalog methods


        #region Sales Accounts Methods

        public static int searchSalesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchSalesAccountWithName(name);
        }

        public static decimal salesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.salesAccountsCalculateTotal();
        }



        #endregion

        #region Financial Products Accounts Methods

        public static int searchFinancialProductsAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchFinancialProductsAccountWithName(name);
        }

        public static decimal financialProductsAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.financialProductsAccountsCalculateTotal();
        }

        #endregion

        #region Other Revenues Accounts Methods


        public static int searchOtherRevenuesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchOtherRevenuesAccountWithName(name);
        }

        public static decimal otherRevenuesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.otherRevenuesAccountsCalculateTotal();
        }

        #endregion

        #region Other Products Accounts Methods


        public static int searchOtherProductAccountWithNamePeriod2(string name)
        {

            return profitAndLossStatementAccountsPeriod2.searchOtherProductAccountWithName(name);
        }

        public static decimal otherProductsAccountsCalculateTotalPeriod2()
        {

            return profitAndLossStatementAccountsPeriod2.otherProductsAccountsCalculateTotal();
        }


        #endregion

        #region Costs Accounts Methods

        public static int searchCostsAccountWithNamePeriod2(string name)
        {

            return profitAndLossStatementAccountsPeriod2.searchCostsAccountWithName(name);

        }

        public static decimal costsAccountsCalculateTotalPeriod2()
        {

            return profitAndLossStatementAccountsPeriod2.costsAccountsCalculateTotal();
        }

        #endregion

        #region Sales Expenses Accounts Methods


        public static int searchSalesExpensesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchSalesExpensesAccountWithName(name);
        }

        public static decimal salesExpensesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.salesExpensesAccountsCalculateTotal();
        }



        #endregion

        #region Administrative Expenses Accounts Methods

        public static int searchAdministrativeExpensesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchAdministrativeExpensesAccountWithName(name);
        }

        public static decimal administrativeExpensesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.administrativeExpensesAccountsCalculateTotal();
        }

        #endregion

        #region Financial Expenses Accounts Methods

        public static int searchFinancialExpensesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchFinancialExpensesAccountWithName(name);
        }

        public static decimal financialExpensesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.financialExpensesAccountsCalculateTotal();
        }


        #endregion

        #region Other Expenses Accounts Methods


        public static int searchOtherExpensesAccountWithNamePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.searchOtherExpensesAccountWithName(name);
        }

        public static decimal otherExpensesAccountsCalculateTotalPeriod2()
        {
            return profitAndLossStatementAccountsPeriod2.otherExpensesAccountsCalculateTotal();
        }


        #endregion

        #endregion

        #endregion

        #endregion



        public static int ProfitAndLossAccountTypePeriod1(string name)
        {
            return profitAndLossStatementAccountsPeriod1.accountType(name);
        }


        public static int ProfitAndLossAccountTypePeriod2(string name)
        {
            return profitAndLossStatementAccountsPeriod2.accountType(name);
        }


    }
}
