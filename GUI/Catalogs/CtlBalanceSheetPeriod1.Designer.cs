namespace GUI.Tests
{
    partial class CtlBalanceSheetPeriod1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentAssetsTable = new System.Windows.Forms.DataGridView();
            this.nonCurrentAssetsTable = new System.Windows.Forms.DataGridView();
            this.shortTermLiabilitiesTable = new System.Windows.Forms.DataGridView();
            this.longTermLiabilitiesTable = new System.Windows.Forms.DataGridView();
            this.stockholdersEquityTable = new System.Windows.Forms.DataGridView();
            this.cbCurrentAssets = new System.Windows.Forms.ComboBox();
            this.txtCurrentAssetBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifyCurrentAsset = new System.Windows.Forms.Button();
            this.btnModifyNonCurrentAsset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNonCurrentAssetBalance = new System.Windows.Forms.TextBox();
            this.cbNonCurrentAssets = new System.Windows.Forms.ComboBox();
            this.cbShortTermLiabilities = new System.Windows.Forms.ComboBox();
            this.txtShortTermLiabilityBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnModifyShortTermLiability = new System.Windows.Forms.Button();
            this.deferredAssetsTable = new System.Windows.Forms.DataGridView();
            this.btnModifyDeferredAsset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeferredAssetBalance = new System.Windows.Forms.TextBox();
            this.cbDeferredAssets = new System.Windows.Forms.ComboBox();
            this.cbLongTermLiabilities = new System.Windows.Forms.ComboBox();
            this.txtLongTermLiabilityBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnModifyLongTermLiability = new System.Windows.Forms.Button();
            this.cbStockholderEquities = new System.Windows.Forms.ComboBox();
            this.txtStockholderEquityBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModifyStockholderEquity = new System.Windows.Forms.Button();
            this.accountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonCurrentAccountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonCurrentAccountName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nonCurrentAccountBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortTermLiabilitiesCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortTermLiabilitiesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortTermLiabilitiesBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longTermLiabilitiesCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longTermLiabilitiesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longTermLiabilitiesBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockholdersEquityCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockholdersEquityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockholdersEquityBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.currentAssetsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonCurrentAssetsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermLiabilitiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.longTermLiabilitiesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockholdersEquityTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deferredAssetsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // currentAssetsTable
            // 
            this.currentAssetsTable.AllowUserToAddRows = false;
            this.currentAssetsTable.AllowUserToResizeColumns = false;
            this.currentAssetsTable.AllowUserToResizeRows = false;
            this.currentAssetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentAssetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.accountCode,
            this.accountName,
            this.balance});
            this.currentAssetsTable.Location = new System.Drawing.Point(12, 25);
            this.currentAssetsTable.Name = "currentAssetsTable";
            this.currentAssetsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currentAssetsTable.Size = new System.Drawing.Size(542, 177);
            this.currentAssetsTable.TabIndex = 0;
            this.currentAssetsTable.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.currentAssetTable_RowEnter);
            // 
            // nonCurrentAssetsTable
            // 
            this.nonCurrentAssetsTable.AllowUserToAddRows = false;
            this.nonCurrentAssetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nonCurrentAssetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nonCurrentAccountCode,
            this.nonCurrentAccountName,
            this.nonCurrentAccountBalance});
            this.nonCurrentAssetsTable.Location = new System.Drawing.Point(12, 249);
            this.nonCurrentAssetsTable.Name = "nonCurrentAssetsTable";
            this.nonCurrentAssetsTable.Size = new System.Drawing.Size(542, 170);
            this.nonCurrentAssetsTable.TabIndex = 2;
            // 
            // shortTermLiabilitiesTable
            // 
            this.shortTermLiabilitiesTable.AllowUserToAddRows = false;
            this.shortTermLiabilitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shortTermLiabilitiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shortTermLiabilitiesCode,
            this.shortTermLiabilitiesName,
            this.shortTermLiabilitiesBalance});
            this.shortTermLiabilitiesTable.Location = new System.Drawing.Point(625, 25);
            this.shortTermLiabilitiesTable.Name = "shortTermLiabilitiesTable";
            this.shortTermLiabilitiesTable.Size = new System.Drawing.Size(534, 177);
            this.shortTermLiabilitiesTable.TabIndex = 3;
            // 
            // longTermLiabilitiesTable
            // 
            this.longTermLiabilitiesTable.AllowUserToAddRows = false;
            this.longTermLiabilitiesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.longTermLiabilitiesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.longTermLiabilitiesCode,
            this.longTermLiabilitiesName,
            this.longTermLiabilitiesBalance});
            this.longTermLiabilitiesTable.Location = new System.Drawing.Point(625, 251);
            this.longTermLiabilitiesTable.Name = "longTermLiabilitiesTable";
            this.longTermLiabilitiesTable.Size = new System.Drawing.Size(534, 170);
            this.longTermLiabilitiesTable.TabIndex = 4;
            // 
            // stockholdersEquityTable
            // 
            this.stockholdersEquityTable.AllowUserToAddRows = false;
            this.stockholdersEquityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockholdersEquityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockholdersEquityCode,
            this.stockholdersEquityName,
            this.stockholdersEquityBalance});
            this.stockholdersEquityTable.Location = new System.Drawing.Point(625, 466);
            this.stockholdersEquityTable.Name = "stockholdersEquityTable";
            this.stockholdersEquityTable.Size = new System.Drawing.Size(534, 145);
            this.stockholdersEquityTable.TabIndex = 5;
            // 
            // cbCurrentAssets
            // 
            this.cbCurrentAssets.FormattingEnabled = true;
            this.cbCurrentAssets.Items.AddRange(new object[] {
            "Caja",
            "Fondo fijo de caja",
            "Bancos",
            "Acciones y valores",
            "Clientes",
            "Deudores diversos",
            "Intereses por cobrar",
            "Inventarios (de mercancías)",
            "Inventarios (de materias primas)",
            "Almacén",
            "IVA acreditable",
            "IVA por acreditar",
            "Documentos por cobrar",
            "Mercancías en consignación ",
            "Mercancías en tránsito",
            "Rentas pagadas por anticipado",
            "Seguros y fianzas pagados por anticipado ",
            "Promoción y publicidad pagada por anticipado",
            "Anticipo a proveedores"});
            this.cbCurrentAssets.Location = new System.Drawing.Point(28, 222);
            this.cbCurrentAssets.Name = "cbCurrentAssets";
            this.cbCurrentAssets.Size = new System.Drawing.Size(161, 21);
            this.cbCurrentAssets.TabIndex = 6;
            this.cbCurrentAssets.Text = "<Seleccionar cuenta>";
            // 
            // txtCurrentAssetBalance
            // 
            this.txtCurrentAssetBalance.Location = new System.Drawing.Point(217, 222);
            this.txtCurrentAssetBalance.Name = "txtCurrentAssetBalance";
            this.txtCurrentAssetBalance.Size = new System.Drawing.Size(145, 20);
            this.txtCurrentAssetBalance.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Balance";
            // 
            // btnModifyCurrentAsset
            // 
            this.btnModifyCurrentAsset.Location = new System.Drawing.Point(415, 220);
            this.btnModifyCurrentAsset.Name = "btnModifyCurrentAsset";
            this.btnModifyCurrentAsset.Size = new System.Drawing.Size(110, 22);
            this.btnModifyCurrentAsset.TabIndex = 9;
            this.btnModifyCurrentAsset.Text = "Modificar";
            this.btnModifyCurrentAsset.UseVisualStyleBackColor = true;
            this.btnModifyCurrentAsset.Click += new System.EventHandler(this.btnModifyCurrentAsset_Click);
            // 
            // btnModifyNonCurrentAsset
            // 
            this.btnModifyNonCurrentAsset.Location = new System.Drawing.Point(415, 437);
            this.btnModifyNonCurrentAsset.Name = "btnModifyNonCurrentAsset";
            this.btnModifyNonCurrentAsset.Size = new System.Drawing.Size(110, 22);
            this.btnModifyNonCurrentAsset.TabIndex = 13;
            this.btnModifyNonCurrentAsset.Text = "Modificar";
            this.btnModifyNonCurrentAsset.UseVisualStyleBackColor = true;
            this.btnModifyNonCurrentAsset.Click += new System.EventHandler(this.btnModifyNonCurrentAsset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Balance";
            // 
            // txtNonCurrentAssetBalance
            // 
            this.txtNonCurrentAssetBalance.Location = new System.Drawing.Point(217, 437);
            this.txtNonCurrentAssetBalance.Name = "txtNonCurrentAssetBalance";
            this.txtNonCurrentAssetBalance.Size = new System.Drawing.Size(145, 20);
            this.txtNonCurrentAssetBalance.TabIndex = 11;
            // 
            // cbNonCurrentAssets
            // 
            this.cbNonCurrentAssets.FormattingEnabled = true;
            this.cbNonCurrentAssets.Items.AddRange(new object[] {
            "Terrenos",
            "Edificios",
            "Depreciación acumulada de edificios",
            "Maquinaria y equipo",
            "Depreciación acumulada de maquinaria y equipo",
            "Mobiliario y equipo de oficina",
            "Depreciación acumulada de mobiliario y equipo de oficina",
            "Mobiliario y equipo de tienda",
            "Depreciación acumulada de mobiliarion y equipo de tienda",
            "Equipo de cómputo",
            "Depreciación acumulada de equipo de cómputo",
            "Equipo de transporte",
            "Depreciación acumulada de equipo de transporte",
            "Depósito en garantía ",
            "Acciones y valores a largo plazo"});
            this.cbNonCurrentAssets.Location = new System.Drawing.Point(28, 439);
            this.cbNonCurrentAssets.Name = "cbNonCurrentAssets";
            this.cbNonCurrentAssets.Size = new System.Drawing.Size(161, 21);
            this.cbNonCurrentAssets.TabIndex = 10;
            this.cbNonCurrentAssets.Text = "<Seleccionar cuenta>";
            // 
            // cbShortTermLiabilities
            // 
            this.cbShortTermLiabilities.FormattingEnabled = true;
            this.cbShortTermLiabilities.Items.AddRange(new object[] {
            "Proveedores",
            "Proveedores extranjeros",
            "Créditos Bancarios",
            "Documentos por pagar C/P",
            "Indemnizaciones por pagar",
            "Impuestos por pagar",
            "Sueldos por pagar",
            "Adelanto clientes",
            "Acreedores diversos",
            "Intereses por pagar",
            "IVA trasladado",
            "IVA por trasladar",
            "Intereses cobrados por anticipado",
            "Rentas cobradas por anticipado"});
            this.cbShortTermLiabilities.Location = new System.Drawing.Point(649, 220);
            this.cbShortTermLiabilities.Name = "cbShortTermLiabilities";
            this.cbShortTermLiabilities.Size = new System.Drawing.Size(168, 21);
            this.cbShortTermLiabilities.TabIndex = 14;
            this.cbShortTermLiabilities.Text = "<Seleccionar cuenta>";
            // 
            // txtShortTermLiabilityBalance
            // 
            this.txtShortTermLiabilityBalance.Location = new System.Drawing.Point(842, 223);
            this.txtShortTermLiabilityBalance.Name = "txtShortTermLiabilityBalance";
            this.txtShortTermLiabilityBalance.Size = new System.Drawing.Size(145, 20);
            this.txtShortTermLiabilityBalance.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(887, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Balance";
            // 
            // btnModifyShortTermLiability
            // 
            this.btnModifyShortTermLiability.Location = new System.Drawing.Point(1019, 220);
            this.btnModifyShortTermLiability.Name = "btnModifyShortTermLiability";
            this.btnModifyShortTermLiability.Size = new System.Drawing.Size(110, 22);
            this.btnModifyShortTermLiability.TabIndex = 17;
            this.btnModifyShortTermLiability.Text = "Modificar";
            this.btnModifyShortTermLiability.UseVisualStyleBackColor = true;
            this.btnModifyShortTermLiability.Click += new System.EventHandler(this.btnModifyShortTermLiability_Click);
            // 
            // deferredAssetsTable
            // 
            this.deferredAssetsTable.AllowUserToAddRows = false;
            this.deferredAssetsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deferredAssetsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.deferredAssetsTable.Location = new System.Drawing.Point(12, 466);
            this.deferredAssetsTable.Name = "deferredAssetsTable";
            this.deferredAssetsTable.Size = new System.Drawing.Size(542, 160);
            this.deferredAssetsTable.TabIndex = 18;
            // 
            // btnModifyDeferredAsset
            // 
            this.btnModifyDeferredAsset.Location = new System.Drawing.Point(415, 641);
            this.btnModifyDeferredAsset.Name = "btnModifyDeferredAsset";
            this.btnModifyDeferredAsset.Size = new System.Drawing.Size(110, 22);
            this.btnModifyDeferredAsset.TabIndex = 22;
            this.btnModifyDeferredAsset.Text = "Modificar";
            this.btnModifyDeferredAsset.UseVisualStyleBackColor = true;
            this.btnModifyDeferredAsset.Click += new System.EventHandler(this.btnModifyDeferredAsset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 627);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Balance";
            // 
            // txtDeferredAssetBalance
            // 
            this.txtDeferredAssetBalance.Location = new System.Drawing.Point(217, 643);
            this.txtDeferredAssetBalance.Name = "txtDeferredAssetBalance";
            this.txtDeferredAssetBalance.Size = new System.Drawing.Size(145, 20);
            this.txtDeferredAssetBalance.TabIndex = 20;
            // 
            // cbDeferredAssets
            // 
            this.cbDeferredAssets.FormattingEnabled = true;
            this.cbDeferredAssets.Items.AddRange(new object[] {
            "Gastos de organización",
            "Amortización acumulada de gastos de organización",
            "Gastos de instalación",
            "Amortización acumulada de gastos de instalación",
            "Gastos preoperativos",
            "Amortizacion acumulada de gastos preoperativos",
            "Rentas pagadas por anticipado",
            "Primas de seguros pagadas por anticipada",
            "Papelería y útiles de escritorio",
            "Propaganda y publicidad",
            "Impuestos pagados por anticipado",
            "Intereses pagados por anticipado"});
            this.cbDeferredAssets.Location = new System.Drawing.Point(28, 643);
            this.cbDeferredAssets.Name = "cbDeferredAssets";
            this.cbDeferredAssets.Size = new System.Drawing.Size(161, 21);
            this.cbDeferredAssets.TabIndex = 19;
            this.cbDeferredAssets.Text = "<Seleccionar cuenta>";
            // 
            // cbLongTermLiabilities
            // 
            this.cbLongTermLiabilities.FormattingEnabled = true;
            this.cbLongTermLiabilities.Items.AddRange(new object[] {
            "Créditos bancarios(a largo plazo)",
            "Documentos por pagar bancos L/P",
            "Hipoteca por pagar y/o acreedor hipotecario",
            "Intereses cobrados por anticipado a largo plazo",
            "Rentas cobradas por anticipado a largo plazo",
            "Documentos por pagar L/P"});
            this.cbLongTermLiabilities.Location = new System.Drawing.Point(649, 439);
            this.cbLongTermLiabilities.Name = "cbLongTermLiabilities";
            this.cbLongTermLiabilities.Size = new System.Drawing.Size(168, 21);
            this.cbLongTermLiabilities.TabIndex = 23;
            this.cbLongTermLiabilities.Text = "<Seleccionar cuenta>";
            // 
            // txtLongTermLiabilityBalance
            // 
            this.txtLongTermLiabilityBalance.Location = new System.Drawing.Point(842, 440);
            this.txtLongTermLiabilityBalance.Name = "txtLongTermLiabilityBalance";
            this.txtLongTermLiabilityBalance.Size = new System.Drawing.Size(145, 20);
            this.txtLongTermLiabilityBalance.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(887, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Balance";
            // 
            // btnModifyLongTermLiability
            // 
            this.btnModifyLongTermLiability.Location = new System.Drawing.Point(1019, 440);
            this.btnModifyLongTermLiability.Name = "btnModifyLongTermLiability";
            this.btnModifyLongTermLiability.Size = new System.Drawing.Size(110, 22);
            this.btnModifyLongTermLiability.TabIndex = 26;
            this.btnModifyLongTermLiability.Text = "Modificar";
            this.btnModifyLongTermLiability.UseVisualStyleBackColor = true;
            this.btnModifyLongTermLiability.Click += new System.EventHandler(this.btnModifyLongTermLiability_Click);
            // 
            // cbStockholderEquities
            // 
            this.cbStockholderEquities.FormattingEnabled = true;
            this.cbStockholderEquities.Items.AddRange(new object[] {
            "Capital social",
            "Reservas",
            "Resultado del ejercicio",
            "Resultado de ejercicios anteriores",
            "Superávit por revaluación"});
            this.cbStockholderEquities.Location = new System.Drawing.Point(649, 641);
            this.cbStockholderEquities.Name = "cbStockholderEquities";
            this.cbStockholderEquities.Size = new System.Drawing.Size(168, 21);
            this.cbStockholderEquities.TabIndex = 27;
            this.cbStockholderEquities.Text = "<Seleccionar cuenta>";
            // 
            // txtStockholderEquityBalance
            // 
            this.txtStockholderEquityBalance.Location = new System.Drawing.Point(842, 643);
            this.txtStockholderEquityBalance.Name = "txtStockholderEquityBalance";
            this.txtStockholderEquityBalance.Size = new System.Drawing.Size(145, 20);
            this.txtStockholderEquityBalance.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(887, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Balance";
            // 
            // btnModifyStockholderEquity
            // 
            this.btnModifyStockholderEquity.Location = new System.Drawing.Point(1019, 639);
            this.btnModifyStockholderEquity.Name = "btnModifyStockholderEquity";
            this.btnModifyStockholderEquity.Size = new System.Drawing.Size(110, 22);
            this.btnModifyStockholderEquity.TabIndex = 30;
            this.btnModifyStockholderEquity.Text = "Modificar";
            this.btnModifyStockholderEquity.UseVisualStyleBackColor = true;
            this.btnModifyStockholderEquity.Click += new System.EventHandler(this.btnModifyStockholderEquity_Click);
            // 
            // accountCode
            // 
            this.accountCode.HeaderText = "Código";
            this.accountCode.MinimumWidth = 10;
            this.accountCode.Name = "accountCode";
            this.accountCode.ReadOnly = true;
            // 
            // accountName
            // 
            this.accountName.HeaderText = "Nombre";
            this.accountName.Name = "accountName";
            this.accountName.ReadOnly = true;
            this.accountName.Width = 250;
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Width = 140;
            // 
            // nonCurrentAccountCode
            // 
            this.nonCurrentAccountCode.HeaderText = "Codigo";
            this.nonCurrentAccountCode.Name = "nonCurrentAccountCode";
            this.nonCurrentAccountCode.ReadOnly = true;
            // 
            // nonCurrentAccountName
            // 
            this.nonCurrentAccountName.HeaderText = "Nombre";
            this.nonCurrentAccountName.Name = "nonCurrentAccountName";
            this.nonCurrentAccountName.ReadOnly = true;
            this.nonCurrentAccountName.Width = 250;
            // 
            // nonCurrentAccountBalance
            // 
            this.nonCurrentAccountBalance.HeaderText = "Balance";
            this.nonCurrentAccountBalance.Name = "nonCurrentAccountBalance";
            this.nonCurrentAccountBalance.ReadOnly = true;
            this.nonCurrentAccountBalance.Width = 140;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Balance";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 140;
            // 
            // shortTermLiabilitiesCode
            // 
            this.shortTermLiabilitiesCode.HeaderText = "Codigo";
            this.shortTermLiabilitiesCode.Name = "shortTermLiabilitiesCode";
            this.shortTermLiabilitiesCode.ReadOnly = true;
            // 
            // shortTermLiabilitiesName
            // 
            this.shortTermLiabilitiesName.HeaderText = "Nombre";
            this.shortTermLiabilitiesName.Name = "shortTermLiabilitiesName";
            this.shortTermLiabilitiesName.ReadOnly = true;
            this.shortTermLiabilitiesName.Width = 250;
            // 
            // shortTermLiabilitiesBalance
            // 
            this.shortTermLiabilitiesBalance.HeaderText = "Balance";
            this.shortTermLiabilitiesBalance.Name = "shortTermLiabilitiesBalance";
            this.shortTermLiabilitiesBalance.ReadOnly = true;
            this.shortTermLiabilitiesBalance.Width = 140;
            // 
            // longTermLiabilitiesCode
            // 
            this.longTermLiabilitiesCode.HeaderText = "Codigo";
            this.longTermLiabilitiesCode.Name = "longTermLiabilitiesCode";
            this.longTermLiabilitiesCode.ReadOnly = true;
            // 
            // longTermLiabilitiesName
            // 
            this.longTermLiabilitiesName.HeaderText = "Nombre";
            this.longTermLiabilitiesName.Name = "longTermLiabilitiesName";
            this.longTermLiabilitiesName.ReadOnly = true;
            this.longTermLiabilitiesName.Width = 250;
            // 
            // longTermLiabilitiesBalance
            // 
            this.longTermLiabilitiesBalance.HeaderText = "Balance";
            this.longTermLiabilitiesBalance.Name = "longTermLiabilitiesBalance";
            this.longTermLiabilitiesBalance.ReadOnly = true;
            this.longTermLiabilitiesBalance.Width = 140;
            // 
            // stockholdersEquityCode
            // 
            this.stockholdersEquityCode.HeaderText = "Codigo";
            this.stockholdersEquityCode.Name = "stockholdersEquityCode";
            this.stockholdersEquityCode.ReadOnly = true;
            // 
            // stockholdersEquityName
            // 
            this.stockholdersEquityName.HeaderText = "Nombre";
            this.stockholdersEquityName.Name = "stockholdersEquityName";
            this.stockholdersEquityName.ReadOnly = true;
            this.stockholdersEquityName.Width = 250;
            // 
            // stockholdersEquityBalance
            // 
            this.stockholdersEquityBalance.HeaderText = "Balance";
            this.stockholdersEquityBalance.Name = "stockholdersEquityBalance";
            this.stockholdersEquityBalance.ReadOnly = true;
            this.stockholdersEquityBalance.Width = 140;
            // 
            // CtlBalanceSheetPeriod1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 675);
            this.Controls.Add(this.btnModifyStockholderEquity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStockholderEquityBalance);
            this.Controls.Add(this.cbStockholderEquities);
            this.Controls.Add(this.btnModifyLongTermLiability);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLongTermLiabilityBalance);
            this.Controls.Add(this.cbLongTermLiabilities);
            this.Controls.Add(this.btnModifyDeferredAsset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeferredAssetBalance);
            this.Controls.Add(this.cbDeferredAssets);
            this.Controls.Add(this.deferredAssetsTable);
            this.Controls.Add(this.btnModifyShortTermLiability);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtShortTermLiabilityBalance);
            this.Controls.Add(this.cbShortTermLiabilities);
            this.Controls.Add(this.btnModifyNonCurrentAsset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNonCurrentAssetBalance);
            this.Controls.Add(this.cbNonCurrentAssets);
            this.Controls.Add(this.btnModifyCurrentAsset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentAssetBalance);
            this.Controls.Add(this.cbCurrentAssets);
            this.Controls.Add(this.stockholdersEquityTable);
            this.Controls.Add(this.longTermLiabilitiesTable);
            this.Controls.Add(this.shortTermLiabilitiesTable);
            this.Controls.Add(this.nonCurrentAssetsTable);
            this.Controls.Add(this.currentAssetsTable);
            this.Name = "CtlBalanceSheetPeriod1";
            this.Text = "BalanceSheet";
            this.Load += new System.EventHandler(this.BalanceSheet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currentAssetsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nonCurrentAssetsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortTermLiabilitiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.longTermLiabilitiesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockholdersEquityTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deferredAssetsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView currentAssetsTable;
        private System.Windows.Forms.DataGridView nonCurrentAssetsTable;
        private System.Windows.Forms.DataGridView shortTermLiabilitiesTable;
        private System.Windows.Forms.DataGridView longTermLiabilitiesTable;
        private System.Windows.Forms.DataGridView stockholdersEquityTable;
        private System.Windows.Forms.ComboBox cbCurrentAssets;
        private System.Windows.Forms.TextBox txtCurrentAssetBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyCurrentAsset;
        private System.Windows.Forms.Button btnModifyNonCurrentAsset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNonCurrentAssetBalance;
        private System.Windows.Forms.ComboBox cbNonCurrentAssets;
        private System.Windows.Forms.ComboBox cbShortTermLiabilities;
        private System.Windows.Forms.TextBox txtShortTermLiabilityBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModifyShortTermLiability;
        private System.Windows.Forms.DataGridView deferredAssetsTable;
        private System.Windows.Forms.Button btnModifyDeferredAsset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeferredAssetBalance;
        private System.Windows.Forms.ComboBox cbDeferredAssets;
        private System.Windows.Forms.ComboBox cbLongTermLiabilities;
        private System.Windows.Forms.TextBox txtLongTermLiabilityBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnModifyLongTermLiability;
        private System.Windows.Forms.ComboBox cbStockholderEquities;
        private System.Windows.Forms.TextBox txtStockholderEquityBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModifyStockholderEquity;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonCurrentAccountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonCurrentAccountName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nonCurrentAccountBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortTermLiabilitiesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortTermLiabilitiesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortTermLiabilitiesBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn longTermLiabilitiesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn longTermLiabilitiesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn longTermLiabilitiesBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockholdersEquityCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockholdersEquityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockholdersEquityBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}