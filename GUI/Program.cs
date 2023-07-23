using BusinessLogic.AccountsLogic;
using DataAccess.AccountsDataAccess;
using GUI.Catalogs;
using GUI.Tests;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClsBalanceSheetAccountsDA clsBalanceSheetAccountsDA = new ClsBalanceSheetAccountsDA();
            ClsProfitAndLossStatementAccountsDA clsBalanceProfitAndLossStatementAccountsDA = new ClsProfitAndLossStatementAccountsDA(); 

            ClsApplication.balanceSheetAcccountsPeriod1 = clsBalanceSheetAccountsDA.openAccounts1();
            ClsApplication.balanceSheetAcccountsPeriod2 = clsBalanceSheetAccountsDA.openAccounts2();

            ClsApplication.profitAndLossStatementAccountsPeriod1 = clsBalanceProfitAndLossStatementAccountsDA.openAccountsPeriod1();
            ClsApplication.profitAndLossStatementAccountsPeriod2 = clsBalanceProfitAndLossStatementAccountsDA.openAccountsPeriod2();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmCtlProfitAndLossAccountsPeriod2());
        }
    }
}
