using DataObject.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.AccountsCatalog
{
    public class ClsBalanceSheetAccountsCatalog
    {
        #region Private variables
        private List<ClsBalanceSheetAccount> currentAssets;
        private List<ClsBalanceSheetAccount> nonCurrentAssets;
        private List<ClsBalanceSheetAccount> deferredAssets;
        private List<ClsBalanceSheetAccount> shortTermLiabilities;
        private List<ClsBalanceSheetAccount> longTermLiabilities;
        private List<ClsBalanceSheetAccount> stockholdersEquity;
        
        #endregion

        #region Public Variables
        public List<ClsBalanceSheetAccount> CurrentAssetsAccounts { get => currentAssets; set => currentAssets = value; }
        public List<ClsBalanceSheetAccount> NonCurrentAssetsAccounts { get => nonCurrentAssets; set => nonCurrentAssets = value; }
        public List<ClsBalanceSheetAccount> ShortTermLiabilities { get => shortTermLiabilities; set => shortTermLiabilities = value; }
        public List<ClsBalanceSheetAccount> LongTermLiabilities { get => longTermLiabilities; set => longTermLiabilities = value; }
        public List<ClsBalanceSheetAccount> StockholdersEquity { get => stockholdersEquity; set => stockholdersEquity = value; }
        public List<ClsBalanceSheetAccount> DeferredAssets { get => deferredAssets; set => deferredAssets = value; }

        #endregion

        #region Constructor
        public ClsBalanceSheetAccountsCatalog()
        {
            currentAssets= new List<ClsBalanceSheetAccount>();
            nonCurrentAssets= new List<ClsBalanceSheetAccount>();
            shortTermLiabilities = new List<ClsBalanceSheetAccount>();
            longTermLiabilities = new List<ClsBalanceSheetAccount>();
            stockholdersEquity = new List<ClsBalanceSheetAccount>();
            deferredAssets = new List<ClsBalanceSheetAccount>();
        }
        #endregion

        #region Current Assets methods

        public void addCurrentAsset(ClsBalanceSheetAccount account)
        {
            currentAssets.Add(account);
        }

        public void removeCurrentAsset(int index) 
        {
            currentAssets.RemoveAt(index);
        }

        public void setCurrentAssetAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            currentAssets[index] = clsBalanceSheetAccount;
        }

        public void clearCurrentAssets()
        {
            currentAssets.Clear();

        }

  
        public decimal currentAssetsCalculateTotal()
        {
            decimal total = 0;
            
            foreach (ClsBalanceSheetAccount account in currentAssets)
            {
                total = total + account.Balance;
            }

            return total;
        }

        #endregion

        #region Non-Current Assets methods
        public void addNonCurrentAsset(ClsBalanceSheetAccount account)
        {
            nonCurrentAssets.Add(account);
        }

        public void removeNonCurrentAsset(int index)
        {
            nonCurrentAssets.RemoveAt(index);
        }

        public void setNonCurrentAssetAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            nonCurrentAssets[index] = clsBalanceSheetAccount;
        }

        public void clearNonCurrentAssets()
        {
            nonCurrentAssets.Clear();

        }

        public decimal nonCurrentAssetsCalculateTotal()
        {
            decimal total = 0;

            foreach (ClsBalanceSheetAccount account in nonCurrentAssets)
            {
                total = total + account.Balance;
            }

            return total;
        }

        #endregion

        #region Deferred assets methods

        public void addDeferredAsset(ClsBalanceSheetAccount account)
        {
            deferredAssets.Add(account);
        }

        public void removeDeferredAsset(int index)
        {
            deferredAssets.RemoveAt(index);
        }

        public void setDeferredAssetAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            deferredAssets[index] = clsBalanceSheetAccount;
        }

        public void clearDeferredAssets()
        {
            deferredAssets.Clear();

        }

        public decimal deferredAssetsCalculateTotal()
        {
            decimal total = 0;

            foreach (ClsBalanceSheetAccount account in deferredAssets)
            {
                total = total + account.Balance;
            }

            return total;
        }

        #endregion

        #region Short term liabilities methods

        public void addShortTermLiabilitie(ClsBalanceSheetAccount account)
        {
            shortTermLiabilities.Add(account);
        }

        public void removeShortTermLiabilitie(int index)
        {
            shortTermLiabilities.RemoveAt(index);
        }

        public void setShortTermLiabilitieAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            shortTermLiabilities[index] = clsBalanceSheetAccount;
        }

        public void clearShortTermLiabilities()
        {
            shortTermLiabilities.Clear();

        }

        public decimal shortTermLiabilitiesCalculateTotal()
        {
            decimal total = 0;

            foreach (ClsBalanceSheetAccount account in shortTermLiabilities)
            {
                total = total + account.Balance;
            }

            return total;
        }

        #endregion

        #region Long term liabilities methods
        public void addLongTermLiabilitie(ClsBalanceSheetAccount account)
        {
            longTermLiabilities.Add(account);
        }

        public void removeLongTermLiabilitie(int index)
        {
            longTermLiabilities.RemoveAt(index);
        }

        public void setLongTermLiabilitieAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            longTermLiabilities[index] = clsBalanceSheetAccount;
        }

        public void clearLongTermLiabilities()
        {
            longTermLiabilities.Clear();

        }

        public decimal longTermLiabilitiesCalculateTotal()
        {
            decimal total = 0;

            foreach (ClsBalanceSheetAccount account in longTermLiabilities)
            {
                total = total + account.Balance;
            }

            return total;
        }

        #endregion

        #region Stockholders' equity methods

        public void addStockholdersEquity(ClsBalanceSheetAccount account)
        {
            stockholdersEquity.Add(account);
        }

        public void removeStockholdersEquity(int index)
        {
            stockholdersEquity.RemoveAt(index);
        }

        public void setStockholdersEquityAt(int index, ClsBalanceSheetAccount clsBalanceSheetAccount)
        {
            stockholdersEquity[index] = clsBalanceSheetAccount;
        }

        public void clearStockholdersEquities()
        {
            stockholdersEquity.Clear();

        }

        public decimal stockholdersEquitiesCalculateTotal()
        {
            decimal total = 0;

            foreach (ClsBalanceSheetAccount account in stockholdersEquity)
            {
                total = total + account.Balance;
            }

            return total;
        }



        #endregion



    }
}
