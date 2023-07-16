using BusinessLogic.AccountsLogic;
using DataAccess.AccountsDataAccess;
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

            ClsApplication.balanceSheetAcccounts1Period = clsBalanceSheetAccountsDA.openAccounts1();
            ClsApplication.balanceSheetAcccounts2Period = clsBalanceSheetAccountsDA.openAccounts2();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CtlBalanceSheetPeriod2());
        }
    }
}
