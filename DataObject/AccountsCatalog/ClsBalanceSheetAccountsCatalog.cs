using DataObject.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
        public List<ClsBalanceSheetAccount> CurrentAssetsAccount { get => currentAssets; set => currentAssets = value; }
        public List<ClsBalanceSheetAccount> NonCurrentAssetAccounts { get => nonCurrentAssets; set => nonCurrentAssets = value; }
        public List<ClsBalanceSheetAccount> ShortTermLiabilityAccounts { get => shortTermLiabilities; set => shortTermLiabilities = value; }
        public List<ClsBalanceSheetAccount> LongTermLiabilityAccounts { get => longTermLiabilities; set => longTermLiabilities = value; }
        public List<ClsBalanceSheetAccount> StockholdersEquityAccounts { get => stockholdersEquity; set => stockholdersEquity = value; }
        public List<ClsBalanceSheetAccount> DeferredAssetAccounts { get => deferredAssets; set => deferredAssets = value; }

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

        public int searchCurrentAssetWithName(string name)
        {
            for (int i=0; i <= currentAssets.Count; i++)
            {
                if(name == currentAssets[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

     
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

  
        public decimal currentAssetsCalculateTotal(int period)
        {
            decimal total = 0;
            

            if(period == 1)
            {
                foreach (ClsBalanceSheetAccount account in currentAssets)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if(period == 2)
            {
                foreach (ClsBalanceSheetAccount account in currentAssets)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }

           
        }

        #endregion

        #region Non-Current Assets methods

        public int searchNonCurrentAssetWithName(string name)
        {
            for (int i = 0; i <= nonCurrentAssets.Count; i++)
            {
                if (name == nonCurrentAssets[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

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

        public decimal nonCurrentAssetsCalculateTotal(int period)
        {
            decimal total = 0;


            if (period == 1)
            {
                foreach (ClsBalanceSheetAccount account in nonCurrentAssets)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 2)
            {
                foreach (ClsBalanceSheetAccount account in nonCurrentAssets)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }


        }

        #endregion

        #region Deferred assets methods

        public int searchDeferredAssetWithName(string name)
        {
            for (int i = 0; i <= deferredAssets.Count; i++)
            {
                if (name == deferredAssets[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }
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

        public decimal deferredAssetsCalculateTotal(int period)
        {
            decimal total = 0;
            if(period == 1)
            {
                foreach (ClsBalanceSheetAccount account in deferredAssets)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 2)
            {
                foreach (ClsBalanceSheetAccount account in deferredAssets)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }
        }

        #endregion

        #region Short term liabilities methods

        public int searchShortTermLiabilityWithName(string name)
        {
            for (int i = 0; i <= shortTermLiabilities.Count; i++)
            {
                if (name == shortTermLiabilities[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

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

        public decimal shortTermLiabilitiesCalculateTotal(int period)
        {
            decimal total = 0;

           
            if (period == 1)
            {
                foreach (ClsBalanceSheetAccount account in shortTermLiabilities)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 2)
            {
                foreach (ClsBalanceSheetAccount account in shortTermLiabilities)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }
        }

        #endregion

        #region Long term liabilities methods

        public int searchLongTermLiabilityWithName(string name)
        {
            for (int i = 0; i <= longTermLiabilities.Count; i++)
            {
                if (name == longTermLiabilities[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

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

        public decimal longTermLiabilitiesCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {
                foreach (ClsBalanceSheetAccount account in longTermLiabilities)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 2)
            {
                foreach (ClsBalanceSheetAccount account in longTermLiabilities)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }
        }

        #endregion

        #region Stockholders' equity methods
        public int searchStockholderEquityWithName(string name)
        {
            for (int i = 0; i <= stockholdersEquity.Count; i++)
            {
                if (name == stockholdersEquity[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

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

        public decimal stockholdersEquitiesCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {
                foreach (ClsBalanceSheetAccount account in stockholdersEquity)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 2)
            {
                foreach (ClsBalanceSheetAccount account in stockholdersEquity)
                {
                    total = total + account.Balance[1];
                }

                return total;
            }
            else
            {
                return total;
            }
        }



        #endregion

        #region Validate account type methods

        private bool isCurrentAssetAccount(string name)
        {
            foreach (var item in currentAssets)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isNonCurrentAssetAccount(string name)
        {

            foreach (var item in nonCurrentAssets)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isDeferredAssetAccount(string name)
        {

            foreach (var item in deferredAssets)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isShortTermLiabilityAccount(string name)
        {

            foreach (var item in shortTermLiabilities)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isLongTermLiabilityAccount(string name)
        {

            foreach (var item in longTermLiabilities)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isStockholdersEquityAccount(string name)
        {

            foreach (var item in stockholdersEquity)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }


        public int accountType(string name)
        {
            if (isCurrentAssetAccount(name))
            {
                return 1;
            }
            else if (isNonCurrentAssetAccount(name))
            {
                return 2;
            }
            else if (isDeferredAssetAccount(name))
            {
                return 3;
            }
            else if (isShortTermLiabilityAccount(name))
            {
                return 4;
            }
            else if (isLongTermLiabilityAccount(name))
            {
                return 5;
            }
            else if (isStockholdersEquityAccount(name))
            {
                return 6;
            }
            else
            {
                return 0;
            }

        }


        #endregion




    }
}
