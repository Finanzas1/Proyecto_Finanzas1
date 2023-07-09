using DataObject.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObject.AccountsCatalog
{
    public class ClsProfitAndLossStatementAccountsCatalog
    {
        private List<ClsProfitAndLossStatementAccount> catalog;
       

        public List<ClsProfitAndLossStatementAccount> Period1Accounts { get => catalog; set => catalog = value; }
      
        public ClsProfitAndLossStatementAccountsCatalog() 
        {
            catalog = new List<ClsProfitAndLossStatementAccount>();
            
        }


        public ClsProfitAndLossStatementAccountsCatalog(List<ClsProfitAndLossStatementAccount> newCatalog)
        {
            catalog = newCatalog;
        }



        public void addAccount(ClsProfitAndLossStatementAccount account)
        {
            catalog.Add(account);
        }

        public void removeAccount(int index)
        {
            catalog.RemoveAt(index);
        }

        public void setAccountAt(int index, ClsProfitAndLossStatementAccount account)
        {
            catalog[index] = account;
        }

        public void clearAccounts()
        {
            catalog.Clear();

        }



    }
}
