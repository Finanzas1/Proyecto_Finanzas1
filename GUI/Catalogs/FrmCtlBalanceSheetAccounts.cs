using BusinessLogic.AccountsLogic;
using DataAccess.AccountsDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Catalogs
{
    public partial class FrmCtlBalanceSheetAccounts : Form
    {
        public FrmCtlBalanceSheetAccounts()
        {
            InitializeComponent();
        }

        private void FrmCtlBalanceSheetAccounts_Load(object sender, EventArgs e)
        {
            foreach (var item in ClsApplication.balanceSheetAcccounts.CurrentAssetsAccount)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach(var item in ClsApplication.balanceSheetAcccounts.NonCurrentAssetAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach(var item in ClsApplication.balanceSheetAcccounts.DeferredAssetAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach(var item in ClsApplication.balanceSheetAcccounts.ShortTermLiabilityAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach(var item in ClsApplication.balanceSheetAcccounts.LongTermLiabilityAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach (var item in ClsApplication.balanceSheetAcccounts.StockholdersEquityAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance[0]);
                row2[2] = Convert.ToString(item.Balance[1]);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbCuentas.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada!", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (String.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado!", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (!rbtnFirstPeriod.Checked && !rbtnSecondPeriod.Checked)
            {
                MessageBox.Show("No se ha seleccionado nigún periodo!", "Datos no validos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClsBalanceSheetAccountsDA dataAccess = new ClsBalanceSheetAccountsDA();
 
                string cuenta = cbCuentas.Text.Trim();
                decimal balance = Convert.ToDecimal(txtBalance.Text);
                int cbIndex = cbCuentas.SelectedIndex;
                int period = 0;

                if (rbtnFirstPeriod.Checked)
                {
                    period = 1;
                }
                else if (rbtnSecondPeriod.Checked)
                {
                    period = 2;
                }


                int index;
                int accountype = ClsApplication.balanceSheetAcccounts.accountType(cuenta);

                switch (accountype)
                {
                    case 1:
                        //Current Assets
                        index = ClsApplication.searchCurrentAssetWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.CurrentAssetsAccount[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 2:
                        //Non current assets
                        index = ClsApplication.searchNonCurrentAssetWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.NonCurrentAssetAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 3:
                        //Deferred assets

                        index = ClsApplication.searchDeferredAssetWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.DeferredAssetAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 4:
                        //Short-term Liabilities
                        index = ClsApplication.searchShortTermLiabilityWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.ShortTermLiabilityAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 5:
                        //Long-term Liabilities
                        index = ClsApplication.searchLongTermLiabilityWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.LongTermLiabilityAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 6:
                        //Stockholders Equity
                        index = ClsApplication.searchStockholdersEquityWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.balanceSheetAcccounts.StockholdersEquityAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 0:

                        MessageBox.Show("Cuenta inexistente!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


                        break;
                }


            }

            txtBalance.Text = string.Empty;
            cbCuentas.SelectedIndex = 0;
        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 45) || (e.KeyChar >= 58 && e.KeyChar <= 255) || e.KeyChar == 47)
            {
                MessageBox.Show("Solo ingrese números!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
