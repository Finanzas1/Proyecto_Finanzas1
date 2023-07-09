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
        public static ClsBalanceSheetAccountsCatalog balanceSheetAcccounts1Period = new ClsBalanceSheetAccountsCatalog();
        public static ClsBalanceSheetAccountsCatalog balancecsheetAcccounts2Period = new ClsBalanceSheetAccountsCatalog();
        public static ClsProfitAndLossStatementAccountsCatalog profitAndLossStatementAccounts1Period = new ClsProfitAndLossStatementAccountsCatalog();
        public static ClsProfitAndLossStatementAccountsCatalog profitAndLossStatementAccounts2Period = new ClsProfitAndLossStatementAccountsCatalog();
        
        
        
        #region Balance Sheet accounts period 1 catalog methods


        #region Current Assets methods

        public static void addCurrentAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addCurrentAsset(account);
        }
       
        public static void removeCurrentAsset1Period(int index)
        {
            balanceSheetAcccounts1Period.removeCurrentAsset(index);
        }
       
        public static void setCurrentAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setCurrentAssetAt(index, account);
        }

        public static void clearCurrentAssets1Period()
        {
            balanceSheetAcccounts1Period.clearCurrentAssets();
        }

        public static decimal currentAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.currentAssetsCalculateTotal();
        }

        #endregion

        #region Non-Current Assets methods

        public static void addNonCurrentAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addNonCurrentAsset(account);
        }

        public static void removeNonCurrentAsset1Period(int index)
        {
            balanceSheetAcccounts1Period.removeNonCurrentAsset(index);
        }

        public static void setNonCurrentAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setNonCurrentAssetAt(index, account);
        }

        public static void clearNonCurrentAssets1Period()
        {
            balanceSheetAcccounts1Period.clearNonCurrentAssets();
        }

        public static decimal nonCurrentAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.nonCurrentAssetsCalculateTotal();
        }

        #endregion

        #region Complementary assets methods

        public static void addDeferredAsset1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addDeferredAsset(account);
        }

        public static void removeDeferredAsset1Period(int index)
        {
            balanceSheetAcccounts1Period.removeDeferredAsset(index);
        }

        public static void setDeferredAssetAt1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setDeferredAssetAt(index, account);
        }

        public static void clearComplementaryAssets1Period()
        {
            balanceSheetAcccounts1Period.clearDeferredAssets();
        }

        public static decimal deferredAssetsCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.deferredAssetsCalculateTotal();
        }

        #endregion

        #region Short term liabilities methods


        public static void addShortTermLiabilitie1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addShortTermLiabilitie(account);
        }

        public static void removeShortTermLiabilitie1Period(int index)
        {
            balanceSheetAcccounts1Period.removeShortTermLiabilitie(index);
        }

        public static void setShortTermLiabilitie1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setShortTermLiabilitieAt(index, account);
        }

        public static void clearShortTermLiabilities1Period()
        {
            balanceSheetAcccounts1Period.clearShortTermLiabilities();
        }

        public static decimal shortTermLiabilitiesCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.shortTermLiabilitiesCalculateTotal();
        }

        #endregion

        #region Long term liabilities methods
        public static void addLongTermLiabilitie1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addLongTermLiabilitie(account);
        }

        public static void removeLongTermLiabilitie1Period(int index)
        {
            balanceSheetAcccounts1Period.removeLongTermLiabilitie(index);
        }

        public static void setLongTermLiabilitie1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setLongTermLiabilitieAt(index, account);
        }

        public static void clearLongTermLiabilities1Period()
        {
            balanceSheetAcccounts1Period.clearLongTermLiabilities();
        }

        public static decimal longTermLiabilitiesCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.longTermLiabilitiesCalculateTotal();
        }


        #endregion

        #region Stockholders' equity methods
        public static void addStockholdersEquity1Period(ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.addStockholdersEquity(account);
        }

        public static void removeStockholdersEquity1Period(int index)
        {
            balanceSheetAcccounts1Period.removeStockholdersEquity(index);
        }

        public static void setStockholdersEquity1Period(int index, ClsBalanceSheetAccount account)
        {
            balanceSheetAcccounts1Period.setStockholdersEquityAt(index, account);
        }

        public static void clearStockholdersEquities1Period()
        {
            balanceSheetAcccounts1Period.clearStockholdersEquities();
        }

        public static decimal StockholdersEquityCalculateTotal1Period()
        {
            return balanceSheetAcccounts1Period.stockholdersEquitiesCalculateTotal();
        }


        #endregion


        #endregion


        #region Balance Sheet accounts period 2 catalog methods


        #region Current Assets methods

        public static void addCurrentAsset2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addCurrentAsset(account);
        }

        public static void removeCurrentAsset2Period(int index)
        {
            balancecsheetAcccounts2Period.removeCurrentAsset(index);
        }

        public static void setCurrentAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setCurrentAssetAt(index, account);
        }

        public static void clearCurrentAssets2Period()
        {
            balancecsheetAcccounts2Period.clearCurrentAssets();
        }

        public static decimal currentAssetsCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.currentAssetsCalculateTotal();
        }

        #endregion

        #region Non-Current Assets methods

        public static void addNonCurrentAsset2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addNonCurrentAsset(account);
        }

        public static void removeNonCurrentAsset2Period(int index)
        {
            balancecsheetAcccounts2Period.removeNonCurrentAsset(index);
        }

        public static void setNonCurrentAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setNonCurrentAssetAt(index, account);
        }

        public static void clearNonCurrentAssets2Period()
        {
            balancecsheetAcccounts2Period.clearNonCurrentAssets();
        }

        public static decimal nonCurrentAssetsCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.nonCurrentAssetsCalculateTotal();
        }

        #endregion

        #region Complementary assets methods

        public static void addDeferredAsset2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addDeferredAsset(account);
        }

        public static void removeDeferredAsset2Period(int index)
        {
            balancecsheetAcccounts2Period.removeDeferredAsset(index);
        }

        public static void setDeferredAssetAt2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setDeferredAssetAt(index, account);
        }

        public static void clearComplementaryAssets2Period()
        {
            balancecsheetAcccounts2Period.clearDeferredAssets();
        }

        public static decimal deferredAssetsCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.deferredAssetsCalculateTotal();
        }

        #endregion

        #region Short term liabilities methods


        public static void addShortTermLiabilitie2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addShortTermLiabilitie(account);
        }

        public static void removeShortTermLiabilitie2Period(int index)
        {
            balancecsheetAcccounts2Period.removeShortTermLiabilitie(index);
        }

        public static void setShortTermLiabilitie2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setShortTermLiabilitieAt(index, account);
        }

        public static void clearShortTermLiabilities2Period()
        {
            balancecsheetAcccounts2Period.clearShortTermLiabilities();
        }

        public static decimal shortTermLiabilitiesCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.shortTermLiabilitiesCalculateTotal();
        }

        #endregion

        #region Long term liabilities methods
        public static void addLongTermLiabilitie2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addLongTermLiabilitie(account);
        }

        public static void removeLongTermLiabilitie2Period(int index)
        {
            balancecsheetAcccounts2Period.removeLongTermLiabilitie(index);
        }

        public static void setLongTermLiabilitie2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setLongTermLiabilitieAt(index, account);
        }

        public static void clearLongTermLiabilities2Period()
        {
            balancecsheetAcccounts2Period.clearLongTermLiabilities();
        }

        public static decimal longTermLiabilitiesCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.longTermLiabilitiesCalculateTotal();
        }


        #endregion

        #region Stockholders' equity methods
        public static void addStockholdersEquity2Period(ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.addStockholdersEquity(account);
        }

        public static void removeStockholdersEquity2Period(int index)
        {
            balancecsheetAcccounts2Period.removeStockholdersEquity(index);
        }

        public static void setStockholdersEquity2Period(int index, ClsBalanceSheetAccount account)
        {
            balancecsheetAcccounts2Period.setStockholdersEquityAt(index, account);
        }

        public static void clearStockholdersEquities2Period()
        {
            balancecsheetAcccounts2Period.clearStockholdersEquities();
        }

        public static decimal StockholdersEquityCalculateTotal2Period()
        {
            return balancecsheetAcccounts2Period.stockholdersEquitiesCalculateTotal();
        }


        #endregion


        #endregion

        #region Profit and loss statement accounts catalog methods

        #region First period

        public static void addPLSAccount1Period(ClsProfitAndLossStatementAccount account)
        {
            profitAndLossStatementAccounts1Period.addAccount(account);
        }

        public static void removePLSAccount1Period(int index)
        {
            profitAndLossStatementAccounts1Period.removeAccount(index);
        }

        public static void setPLSAccount1PeriodAt(int index, ClsProfitAndLossStatementAccount account)
        {
            profitAndLossStatementAccounts1Period.setAccountAt(index, account);
        }

        public static void clearPLSAccounts1period()
        {
            profitAndLossStatementAccounts1Period.clearAccounts();
        }


        #endregion

        #region Second period

        public static void addPLSAccount2Period(ClsProfitAndLossStatementAccount account)
        {
            profitAndLossStatementAccounts2Period.addAccount(account);
        }

        public static void removePLSAccount2Period(int index)
        {
            profitAndLossStatementAccounts2Period.removeAccount(index);
        }

        public static void setPLSAccount2PeriodAt(int index, ClsProfitAndLossStatementAccount account)
        {
            profitAndLossStatementAccounts2Period.setAccountAt(index, account);
        }

        public static void clearPLSAccounts2period()
        {
            profitAndLossStatementAccounts2Period.clearAccounts();
        }

        #endregion

        #endregion


    }
}
