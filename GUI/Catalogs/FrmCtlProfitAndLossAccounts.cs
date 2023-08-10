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
    public partial class FrmCtlProfitAndLossAccounts : Form
    {
        public FrmCtlProfitAndLossAccounts()
        {
            InitializeComponent();
        }

        private void FrmProfitAndLossAccountsPeriod1_Load(object sender, EventArgs e)
        {

            foreach(var item in ClsApplication.profitAndLossStatementAccounts.SalesAccounts)
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
            foreach (var item in ClsApplication.profitAndLossStatementAccounts.FinancialProductsAccounts)
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


            foreach (var item in ClsApplication.profitAndLossStatementAccounts.OtherRevenuesAccounts)
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

            foreach (var item in ClsApplication.profitAndLossStatementAccounts.OtherProductsAccounts)
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

            foreach (var item in ClsApplication.profitAndLossStatementAccounts.CostsAccounts)
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

            foreach (var item in ClsApplication.profitAndLossStatementAccounts.SalesExpensesAccounts)
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

            foreach (var item in ClsApplication.profitAndLossStatementAccounts.AdministrativeExpensesAccounts)
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
            foreach (var item in ClsApplication.profitAndLossStatementAccounts.FinancialExpensesAccounts)
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
            foreach (var item in ClsApplication.profitAndLossStatementAccounts.OtherExpensesAccounts)
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
            foreach (var item in ClsApplication.profitAndLossStatementAccounts.MiscellaneousAccounts)
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
            foreach (var item in ClsApplication.profitAndLossStatementAccounts.ProfitStatementAccounts)
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

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( ( e.KeyChar >= 32 && e.KeyChar <= 45) || (  e.KeyChar >= 58  &&  e.KeyChar <= 255 ) ||  e.KeyChar == 47)
            {
                MessageBox.Show("Solo ingrese números!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCuentas.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada!", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if(String.IsNullOrEmpty(txtBalance.Text))
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
                ClsProfitAndLossStatementAccountsDA dataAccess = new ClsProfitAndLossStatementAccountsDA();

                string cuenta = cbCuentas.Text.Trim();
                decimal balance = Convert.ToDecimal(txtBalance.Text);
                int cbIndex = cbCuentas.SelectedIndex;
                int period = 0;

                if(rbtnFirstPeriod.Checked) 
                { period = 1;
                }
                else if(rbtnSecondPeriod.Checked)
                {  period = 2;
                }


                int index;
                int accountype = ClsApplication.ProfitAndLossAccountType(cuenta);

                switch (accountype)
                {
                    case 1:
                        //Sales accounts 
                        index = ClsApplication.searchSalesAccountWithName(cuenta);

                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.SalesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 2:
                        //Financial Products Accounts
                        index = ClsApplication.searchFinancialProductsAccountWithName(cuenta);
                      
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.FinancialProductsAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 3:
                        //Other revenues accounts

                        index = ClsApplication.searchOtherRevenuesAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.OtherRevenuesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 4:
                      //Other products accounts
                        index = ClsApplication.searchOtherProductAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.OtherProductsAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 5:
                        //Costs accounts
                        index = ClsApplication.searchCostsAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.CostsAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 6:
                        //Sales Expenses
                        index = ClsApplication.searchSalesExpensesAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.SalesExpensesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 7:
                        //Administrative Expenses
                        index = ClsApplication.searchAdministrativeExpensesAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.AdministrativeExpensesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 8:
                        //Financial Expenses
                        index = ClsApplication.searchFinancialExpensesAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.FinancialExpensesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);

                        break;
                    case 9:
                        //Other expenses
                        index = ClsApplication.searchOtherExpensesAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.OtherExpensesAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 10:
                        //Miscellaneous
                        index = ClsApplication.searchMiscellaneousAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.ProfitStatementAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 11:
                        //Profit statements
                        index = ClsApplication.searchProfitStatementAccountWithName(cuenta);
                        dataAccess.saveAccountNewBalance(ClsApplication.profitAndLossStatementAccounts.ProfitStatementAccounts[index], balance, period);

                        BalanceModifierTable.Rows[cbIndex].Cells[period].Value = Convert.ToString(balance);
                        break;
                    case 0:

                        MessageBox.Show("Cuenta inexistente!", "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);


                        break;
                }


            }

            txtBalance.Text = string.Empty;
            cbCuentas.SelectedIndex = 0;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
