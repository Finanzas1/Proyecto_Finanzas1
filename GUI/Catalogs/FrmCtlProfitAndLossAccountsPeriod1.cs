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
    public partial class FrmCtlProfitAndLossAccountsPeriod1 : Form
    {
        public FrmCtlProfitAndLossAccountsPeriod1()
        {
            InitializeComponent();
        }

        private void FrmProfitAndLossAccountsPeriod1_Load(object sender, EventArgs e)
        {

            foreach(var item in ClsApplication.profitAndLossStatementAccountsPeriod1.SalesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialProductsAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }


            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.OtherRevenuesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }

            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.OtherProductsAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }

            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.CostsAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }

            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.SalesExpensesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }

            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.AdministrativeExpensesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialExpensesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

                catalogTable.Rows.Add(row);
                BalanceModifierTable.Rows.Add(row2);

            }
            foreach (var item in ClsApplication.profitAndLossStatementAccountsPeriod1.OtherExpensesAccounts)
            {
                string[] row = new string[2];
                string[] row2 = new string[2];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row2[0] = item.Name;
                row2[1] = Convert.ToString(item.Balance);

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
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
          if (String.IsNullOrEmpty(txtBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ClsProfitAndLossStatementAccountsDA dataAccess = new ClsProfitAndLossStatementAccountsDA();

                string cuenta = cbCuentas.Text.Trim();
                decimal balance = Convert.ToDecimal(txtBalance.Text);
                int cbIndex = cbCuentas.SelectedIndex;

                int index;


                int accountype = 0;

                accountype = ClsApplication.ProfitAndLossAccountTypePeriod1(cuenta);

                switch (accountype)
                {
                    case 1:
                        index = ClsApplication.searchSalesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.SalesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.SalesAccounts[index], balance));

                        break;
                    case 2:
                        
                        index = ClsApplication.searchFinancialProductsAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialProductsAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialProductsAccounts[index], balance));

                        break;
                    case 3:
                        index = ClsApplication.searchOtherRevenuesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.OtherRevenuesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.OtherRevenuesAccounts[index], balance));


                        break;
                    case 4:
                      
                        index = ClsApplication.searchOtherProductAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.OtherProductsAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.OtherProductsAccounts[index], balance));


                        break;
                    case 5:

                        index = ClsApplication.searchCostsAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.CostsAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.CostsAccounts[index], balance));


                        break;
                    case 6:
                        index = ClsApplication.searchSalesExpensesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.SalesExpensesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.SalesExpensesAccounts[index], balance));



                        break;
                    case 7:
                        index = ClsApplication.searchAdministrativeExpensesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.AdministrativeExpensesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.AdministrativeExpensesAccounts[index], balance));


                        break;
                    case 8:

                        index = ClsApplication.searchFinancialExpensesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialExpensesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.FinancialExpensesAccounts[index], balance));


                        break;
                    case 9:

                        index = ClsApplication.searchOtherExpensesAccountWithNamePeriod1(cuenta);
                        ClsApplication.profitAndLossStatementAccountsPeriod1.OtherExpensesAccounts[index].Balance = balance;
                        BalanceModifierTable.Rows[cbIndex].Cells[1].Value = Convert.ToString(dataAccess.saveAccountNewBalancePeriod1(ClsApplication.profitAndLossStatementAccountsPeriod1.OtherExpensesAccounts[index], balance));


                        break;
                    case 0:

                        MessageBox.Show("Cuenta inexistente!", "Error!" , MessageBoxButtons.OK, MessageBoxIcon.Error);


                        break;
                }


            }

            txtBalance.Text = string.Empty;
            cbCuentas.SelectedIndex = 0;
        }
    }
}
