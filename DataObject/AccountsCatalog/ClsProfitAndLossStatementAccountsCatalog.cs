using DataObject.Accounts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataObject.AccountsCatalog
{
    public class ClsProfitAndLossStatementAccountsCatalog
    {
        #region Private variables

        private List<ClsProfitAndLossStatementAccount> salesAccounts;
        private List<ClsProfitAndLossStatementAccount> financialProductsAccounts;
        private List<ClsProfitAndLossStatementAccount> otherRevenuesAccounts;
        private List<ClsProfitAndLossStatementAccount> otherProductsAccounts;
        private List<ClsProfitAndLossStatementAccount> costsAccounts;
        private List<ClsProfitAndLossStatementAccount> salesExpensesAccounts;
        private List<ClsProfitAndLossStatementAccount> administrativeExpensesAccounts;
        private List<ClsProfitAndLossStatementAccount> financialExpensesAccounts;
        private List<ClsProfitAndLossStatementAccount> otherExpensesAccounts;
        private List<ClsProfitAndLossStatementAccount> miscellaneousAccounts;
        private List<ClsProfitAndLossStatementAccount> profitStatementAccounts;

        #endregion

        #region Public variables
        public List<ClsProfitAndLossStatementAccount> SalesAccounts { get => salesAccounts; set => salesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> FinancialProductsAccounts { get => financialProductsAccounts; set => financialProductsAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> OtherRevenuesAccounts { get => otherRevenuesAccounts; set => otherRevenuesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> OtherProductsAccounts { get => otherProductsAccounts; set => otherProductsAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> CostsAccounts { get => costsAccounts; set => costsAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> SalesExpensesAccounts { get => salesExpensesAccounts; set => salesExpensesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> AdministrativeExpensesAccounts { get => administrativeExpensesAccounts; set => administrativeExpensesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> FinancialExpensesAccounts { get => financialExpensesAccounts; set => financialExpensesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> OtherExpensesAccounts { get => otherExpensesAccounts; set => otherExpensesAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> ProfitStatementAccounts { get => profitStatementAccounts; set => profitStatementAccounts = value; }
        public List<ClsProfitAndLossStatementAccount> MiscellaneousAccounts { get => miscellaneousAccounts; set => miscellaneousAccounts = value; }

        #endregion

        #region Constructor

        public ClsProfitAndLossStatementAccountsCatalog()
        {
            salesAccounts = new List<ClsProfitAndLossStatementAccount>();
            financialProductsAccounts = new List<ClsProfitAndLossStatementAccount>();
            otherRevenuesAccounts = new List<ClsProfitAndLossStatementAccount>();
            otherProductsAccounts = new List<ClsProfitAndLossStatementAccount>();
            costsAccounts = new List<ClsProfitAndLossStatementAccount>();
            salesExpensesAccounts = new List<ClsProfitAndLossStatementAccount>();
            administrativeExpensesAccounts = new List<ClsProfitAndLossStatementAccount>();
            financialExpensesAccounts = new List<ClsProfitAndLossStatementAccount>();
            otherExpensesAccounts = new List<ClsProfitAndLossStatementAccount>();
            miscellaneousAccounts = new List<ClsProfitAndLossStatementAccount>();
            profitStatementAccounts = new List<ClsProfitAndLossStatementAccount>();
        }


        #endregion

        #region Sales Accounts Methods

        public int searchSalesAccountWithName(string name)
        {
            for (int i = 0; i <= salesAccounts.Count; i++)
            {
                if (name == salesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal salesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if(period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in salesAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in salesAccounts)
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


        public void addSalesAccount(ClsProfitAndLossStatementAccount account)
        {
            salesAccounts.Add(account);
        }

        public void removeSalesAccount(int index)
        {
            salesAccounts.RemoveAt(index);
        }

        public void setSalesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            salesAccounts[index] = account;
        }

        public void clearSalesAccounts()
        {
            salesAccounts.Clear();

        }

        #endregion

        #region Financial Products Accounts Methods



        public int searchFinancialProductsAccountWithName(string name)
        {
            for (int i = 0; i <= financialProductsAccounts.Count; i++)
            {
                if (name == financialProductsAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal financialProductsAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in financialProductsAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in financialProductsAccounts)
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


        public void addFinancialProductsAccount(ClsProfitAndLossStatementAccount account)
        {
            financialProductsAccounts.Add(account);
        }

        public void removeFinancialProductsAccount(int index)
        {
            financialProductsAccounts.RemoveAt(index);
        }

        public void setFinancialProductAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            financialProductsAccounts[index] = account;
        }

        public void clearFinancialProductsAccounts()
        {
            financialProductsAccounts.Clear();

        }

        #endregion

        #region Other Revenues Accounts Methods


        public int searchOtherRevenuesAccountWithName(string name)
        {
            for (int i = 0; i <= otherRevenuesAccounts.Count; i++)
            {
                if (name == otherRevenuesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal otherRevenuesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherRevenuesAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherRevenuesAccounts)
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

        public void addOtherRevenuesAccount(ClsProfitAndLossStatementAccount account)
        {
            otherRevenuesAccounts.Add(account);
        }

        public void removeOtherRevenuesAccount(int index)
        {
            otherRevenuesAccounts.RemoveAt(index);
        }

        public void setOtherRevenuesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            otherRevenuesAccounts[index] = account;
        }

        public void clearOtherRevenuesAccounts()
        {
            otherRevenuesAccounts.Clear();

        }

        #endregion

        #region Other Products Accounts Methods


        public int searchOtherProductAccountWithName(string name)
        {
            for (int i = 0; i <= otherProductsAccounts.Count; i++)
            {
                if (name == otherProductsAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal otherProductsAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherProductsAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherProductsAccounts)
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

        public void addOtherProductsAccount(ClsProfitAndLossStatementAccount account)
        {
            otherProductsAccounts.Add(account);
        }

        public void removeOtherProductAccount(int index)
        {
            otherProductsAccounts.RemoveAt(index);
        }

        public void setOtherProductAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            otherProductsAccounts[index] = account;
        }

        public void clearOtherProductsAccounts()
        {
            otherProductsAccounts.Clear();

        }

        #endregion

        #region Costs Accounts Methods

        public int searchCostsAccountWithName(string name)
        {
            for (int i = 0; i <= costsAccounts.Count; i++)
            {
                if (name == costsAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal costsAccountsCalculateTotal(int period)
        {
            decimal total = 0;
            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in costsAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in costsAccounts)
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

        public void addCostsAccount(ClsProfitAndLossStatementAccount account)
        {
            costsAccounts.Add(account);
        }

        public void removeCostsAccount(int index)
        {
            costsAccounts.RemoveAt(index);
        }

        public void setCostsAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            costsAccounts[index] = account;
        }

        public void clearCostsAccounts()
        {
            costsAccounts.Clear();

        }

        #endregion

        #region Sales Expenses Accounts Methods


        public int searchSalesExpensesAccountWithName(string name)
        {
            for (int i = 0; i <= salesExpensesAccounts.Count; i++)
            {
                if (name == salesExpensesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal salesExpensesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in salesExpensesAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in salesExpensesAccounts)
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

        public void addSalesExpensesAccount(ClsProfitAndLossStatementAccount account)
        {
            salesExpensesAccounts.Add(account);
        }

        public void removeSalesExpensesAccount(int index)
        {
            salesExpensesAccounts.RemoveAt(index);
        }

        public void setSalesExpensesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            salesExpensesAccounts[index] = account;
        }

        public void clearSalesExpensesAccounts()
        {
            salesExpensesAccounts.Clear();

        }

        #endregion

        #region Administrative Expenses Accounts Methods

        public int searchAdministrativeExpensesAccountWithName(string name)
        {
            for (int i = 0; i <= administrativeExpensesAccounts.Count; i++)
            {
                if (name == administrativeExpensesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal administrativeExpensesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in administrativeExpensesAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in administrativeExpensesAccounts)
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

        public void addAdministrativeExpensesAccount(ClsProfitAndLossStatementAccount account)
        {
            administrativeExpensesAccounts.Add(account);
        }

        public void removeAdministrativeExpensesAccount(int index)
        {
            administrativeExpensesAccounts.RemoveAt(index);
        }

        public void setAdministrativeExpensesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            administrativeExpensesAccounts[index] = account;
        }

        public void clearAdministrativeExpensesAccounts()
        {
            administrativeExpensesAccounts.Clear();

        }


        #endregion

        #region Financial Expenses Accounts Methods

        public int searchFinancialExpensesAccountWithName(string name)
        {
            for (int i = 0; i <= financialExpensesAccounts.Count; i++)
            {
                if (name == financialExpensesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal financialExpensesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in financialExpensesAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in financialExpensesAccounts)
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

        public void addFinancialExpensesAccount(ClsProfitAndLossStatementAccount account)
        {
            financialExpensesAccounts.Add(account);
        }

        public void removeFinancialExpensesAccount(int index)
        {
            financialExpensesAccounts.RemoveAt(index);
        }

        public void setFinancialExpensesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            
            financialExpensesAccounts[index] = account;
        }

        public void clearFinancialExpensesAccounts()
        {
            financialExpensesAccounts.Clear();

        }

        #endregion

        #region Other Expenses Accounts Methods


        public int searchOtherExpensesAccountWithName(string name)
        {
            for (int i = 0; i <= otherExpensesAccounts.Count; i++)
            {
                if (name == otherExpensesAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal otherExpensesAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherProductsAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in otherProductsAccounts)
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


        public void addOtherExpensesAccount(ClsProfitAndLossStatementAccount account)
        {
            otherExpensesAccounts.Add(account);
        }

        public void removeOtherExpensesAccount(int index)
        {
            otherExpensesAccounts.RemoveAt(index);
        }

        public void setOtherExpensesAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {

            otherExpensesAccounts[index] = account;
        }

        public void clearOtherExpensesAccounts()
        {
            otherExpensesAccounts.Clear();

        }

        #endregion


        #region Miscellaneous Accounts Methods

        public int searchMiscellaneousAccountWithName(string name)
        {
            for (int i = 0; i <= miscellaneousAccounts.Count; i++)
            {
                if (name == miscellaneousAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal miscellaneousAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in miscellaneousAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in miscellaneousAccounts)
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


        public void addMiscellaneousAccount(ClsProfitAndLossStatementAccount account)
        {
            miscellaneousAccounts.Add(account);
        }

        public void removeMiscellaneousAccount(int index)
        {
            miscellaneousAccounts.RemoveAt(index);
        }

        public void setMiscellaneousAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {

            miscellaneousAccounts[index] = account;
        }

        public void clearMiscellaneousAccounts()
        {
            miscellaneousAccounts.Clear();

        }


        #endregion

        #region Profit Statement Accounts

        public int searchProfitStatementAccountWithName(string name)
        {
            for (int i = 0; i <= profitStatementAccounts.Count; i++)
            {
                if (name == profitStatementAccounts[i].Name)
                {
                    return i;
                }
            }

            return -1;
        }

        public decimal profitStatementAccountsCalculateTotal(int period)
        {
            decimal total = 0;

            if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in profitStatementAccounts)
                {
                    total = total + account.Balance[0];
                }

                return total;
            }
            else if (period == 1)
            {

                foreach (ClsProfitAndLossStatementAccount account in ProfitStatementAccounts)
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


        public void addProfitStatementAccount(ClsProfitAndLossStatementAccount account)
        {
            profitStatementAccounts.Add(account);
        }

        public void removeProfitStatementAccount(int index)
        {
            profitStatementAccounts.RemoveAt(index);
        }

        public void setProfitStatementAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {

            profitStatementAccounts[index] = account;
        }

        public void clearProfitStatementAccounts()
        {
            profitStatementAccounts.Clear();

        }

        #endregion




        #region Validate Account Type Methods


        private bool isSalesAccount(string name)
        {
            foreach (var item in salesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isFinancialProductsAccount(string name)
        {

            foreach (var item in financialProductsAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isOtherRevenuesAccount(string name)
        {

            foreach (var item in otherRevenuesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isOtherProductsAccount(string name)
        {

            foreach (var item in otherProductsAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isCostsAccount(string name)
        {

            foreach (var item in costsAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isSalesExpensesAccount(string name)
        {

            foreach (var item in SalesExpensesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isAdministrativeExpensesAccount(string name)
        {

            foreach (var item in administrativeExpensesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isFinancialExpensesAccount(string name)
        {

            foreach (var item in financialExpensesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }


        private bool isOtherExpensesAccount(string name)
        {

            foreach (var item in otherExpensesAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }

        private bool isProfitStatementAccount(string name)
        {

            foreach (var item in profitStatementAccounts)
            {
                if (name == item.Name)
                {
                    return true;
                }
            }

            return false;
        }


        private bool isMiscellaneousAccount(string name)
        {
            foreach (var item in miscellaneousAccounts)
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
            if (isSalesAccount(name))
            {
                return 1;
            }
            else if (isFinancialProductsAccount(name))
            {
                return 2;
            }
            else if (isOtherRevenuesAccount(name))
            {
                return 3;
            }
            else if (isOtherProductsAccount(name))
            {
                return 4;
            }
            else if (isCostsAccount(name))
            {
                return 5;
            }
            else if (isSalesExpensesAccount(name))
            {
                return 6;
            }
            else if (isAdministrativeExpensesAccount(name))
            {
                return 7;
            }
            else if (isFinancialExpensesAccount(name))
            {
                return 8;
            }
            else if (isOtherExpensesAccount(name))
            {
                return 9;
            }
            else if (isMiscellaneousAccount(name))
            {
                return 10;
            }
            else if (isProfitStatementAccount(name))
            {
                return 11;
            }
            else
            {
                return 0;
            }
        }



        #endregion









    }
}
