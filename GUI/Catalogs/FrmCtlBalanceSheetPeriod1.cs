using BusinessLogic.AccountsLogic;
using DataAccess.AccountsDataAccess;
using DataObject.Accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Tests
{
    public partial class FrmCtlBalanceSheetPeriod1 : Form
    {
        private ClsBalanceSheetAccountsDA balancesheetDA = new ClsBalanceSheetAccountsDA();
    


        public FrmCtlBalanceSheetPeriod1()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.CurrentAssetsAccountAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                currentAssetsTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.NonCurrentAssetAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                nonCurrentAssetsTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.ShortTermLiabilityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                shortTermLiabilitiesTable.Rows.Add(row);


            }


            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.LongTermLiabilityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                longTermLiabilitiesTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.StockholdersEquityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                stockholdersEquityTable.Rows.Add(row);


            }





        }


        private void limpiarCeldas()
        {
            
            txtNonCurrentAssetBalance.Text = string.Empty;
            txtDeferredAssetBalance.Text = string.Empty;
            txtShortTermLiabilityBalance.Text = string.Empty;
            txtLongTermLiabilityBalance.Text = string.Empty;
            txtStockholderEquityBalance.Text = string.Empty;



        }

   
        
        private void currentAssetTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {


        }


        private void BalanceSheet_Load(object sender, EventArgs e)
        {
            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.CurrentAssetsAccountAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                currentAssetsTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.NonCurrentAssetAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                nonCurrentAssetsTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.DeferredAssetAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                deferredAssetsTable.Rows.Add(row);
            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.ShortTermLiabilityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                shortTermLiabilitiesTable.Rows.Add(row);


            }


            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.LongTermLiabilityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                longTermLiabilitiesTable.Rows.Add(row);


            }

            foreach (var item in ClsApplication.balanceSheetAcccountsPeriod1.StockholdersEquityAccounts)
            {
                string[] row = new string[3];
                row[0] = item.AccountCode;
                row[1] = item.Name;
                row[2] = Convert.ToString(item.Balance);

                stockholdersEquityTable.Rows.Add(row);


            }


        }




    

  

        private void btnModifyCurrentAsset_Click(object sender, EventArgs e)
        {

            if(cbCurrentAssets.SelectedIndex <0) 
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (String.IsNullOrEmpty(txtCurrentAssetBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbCurrentAssets.Text.Trim();
                decimal balance = Convert.ToDecimal(txtCurrentAssetBalance.Text);
                int cbIndex = cbCurrentAssets.SelectedIndex;

                int index = ClsApplication.searchCurrentAsset1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.CurrentAssetsAccountAccounts[index].Balance = balance;


                currentAssetsTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.CurrentAssetsAccountAccounts[index], balance));

            }

            txtCurrentAssetBalance.Text = string.Empty;
            cbCurrentAssets.SelectedIndex = 0;


        }


        private void btnModifyNonCurrentAsset_Click(object sender, EventArgs e)
        {
            if (cbNonCurrentAssets.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            if(String.IsNullOrEmpty(txtNonCurrentAssetBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbNonCurrentAssets.Text.Trim();
                decimal balance = Convert.ToDecimal(txtNonCurrentAssetBalance.Text);
                int cbIndex = cbNonCurrentAssets.SelectedIndex;

                int index = ClsApplication.searchNonCurrentAsset1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.NonCurrentAssetAccounts[index].Balance = balance;


                nonCurrentAssetsTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.NonCurrentAssetAccounts[index], balance));

            }

            txtNonCurrentAssetBalance.Text = string.Empty;
            cbNonCurrentAssets.SelectedIndex = 0;
        }

        private void btnModifyDeferredAsset_Click(object sender, EventArgs e)
        {
            if (cbDeferredAssets.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (String.IsNullOrEmpty(txtDeferredAssetBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbDeferredAssets.Text.Trim();
                decimal balance = Convert.ToDecimal(txtDeferredAssetBalance.Text);
                int cbIndex = cbDeferredAssets.SelectedIndex;

                int index = ClsApplication.searchDeferredAsset1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.DeferredAssetAccounts[index].Balance = balance;


                deferredAssetsTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.DeferredAssetAccounts[index], balance));

            }

            txtDeferredAssetBalance.Text = string.Empty;
            cbDeferredAssets.SelectedIndex = 0;


        }

        private void btnModifyShortTermLiability_Click(object sender, EventArgs e)
        {
            if(cbShortTermLiabilities.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (String.IsNullOrEmpty(txtShortTermLiabilityBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbShortTermLiabilities.Text.Trim();
                decimal balance = Convert.ToDecimal(txtShortTermLiabilityBalance.Text);
                int cbIndex = cbShortTermLiabilities.SelectedIndex;

                int index = ClsApplication.searchShortTermLiability1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.ShortTermLiabilityAccounts[index].Balance = balance;


                shortTermLiabilitiesTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.ShortTermLiabilityAccounts[index], balance));

            }

            txtShortTermLiabilityBalance.Text = string.Empty;
            cbShortTermLiabilities.SelectedIndex = 0;

        }

        private void btnModifyLongTermLiability_Click(object sender, EventArgs e)
        {
            if (cbLongTermLiabilities.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (String.IsNullOrEmpty(txtLongTermLiabilityBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbLongTermLiabilities.Text.Trim();
                decimal balance = Convert.ToDecimal(txtLongTermLiabilityBalance.Text);
                int cbIndex = cbLongTermLiabilities.SelectedIndex;

                int index = ClsApplication.searchLongTermLiability1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.LongTermLiabilityAccounts[index].Balance = balance;


                longTermLiabilitiesTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.LongTermLiabilityAccounts[index], balance));

            }

            txtLongTermLiabilityBalance.Text = string.Empty;
            cbLongTermLiabilities.SelectedIndex = 0;
        }

        private void btnModifyStockholderEquity_Click(object sender, EventArgs e)
        {
            if (cbStockholderEquities.SelectedIndex < 0)
            {
                MessageBox.Show("Ninguna cuenta ha sido seleccionada.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
           if (String.IsNullOrEmpty(txtStockholderEquityBalance.Text))
            {
                MessageBox.Show("El balance no ha sido ingresado.", "Datos no validados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cuenta = cbStockholderEquities.Text.Trim();
                decimal balance = Convert.ToDecimal(txtStockholderEquityBalance.Text);
                int cbIndex = cbStockholderEquities.SelectedIndex;

                int index = ClsApplication.searchStockholdersEquity1PeriodWithName(cuenta);

                ClsApplication.balanceSheetAcccountsPeriod1.StockholdersEquityAccounts[index].Balance = balance;


                stockholdersEquityTable.Rows[cbIndex].Cells[2].Value = Convert.ToString(balancesheetDA.saveAccountNewBalancePeriod1(ClsApplication.balanceSheetAcccountsPeriod1.StockholdersEquityAccounts[index], balance));

            }

            txtStockholderEquityBalance.Text = string.Empty;
            cbStockholderEquities.SelectedIndex = 0;
        }
    }
}
