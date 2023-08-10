namespace GUI.Catalogs
{
    partial class FrmCtlBalanceSheetAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.catalogTable = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceModifierTable = new System.Windows.Forms.DataGridView();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSecondPeriod = new System.Windows.Forms.RadioButton();
            this.rbtnFirstPeriod = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cbCuentas = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel1.Controls.Add(this.catalogTable);
            this.flowLayoutPanel1.Controls.Add(this.BalanceModifierTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1194, 410);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // catalogTable
            // 
            this.catalogTable.AllowUserToAddRows = false;
            this.catalogTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.catalogTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nombre});
            this.catalogTable.Location = new System.Drawing.Point(3, 3);
            this.catalogTable.Name = "catalogTable";
            this.catalogTable.Size = new System.Drawing.Size(503, 401);
            this.catalogTable.TabIndex = 0;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 340;
            // 
            // BalanceModifierTable
            // 
            this.BalanceModifierTable.AllowUserToAddRows = false;
            this.BalanceModifierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceModifierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre2,
            this.Balance1,
            this.Balance2});
            this.BalanceModifierTable.Location = new System.Drawing.Point(512, 3);
            this.BalanceModifierTable.Name = "BalanceModifierTable";
            this.BalanceModifierTable.Size = new System.Drawing.Size(676, 401);
            this.BalanceModifierTable.TabIndex = 1;
            // 
            // Nombre2
            // 
            this.Nombre2.FillWeight = 146.3414F;
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Nombre2.Width = 340;
            // 
            // Balance1
            // 
            this.Balance1.FillWeight = 64.88715F;
            this.Balance1.HeaderText = "Primer Saldo";
            this.Balance1.Name = "Balance1";
            this.Balance1.Width = 140;
            // 
            // Balance2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Balance2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Balance2.FillWeight = 88.77138F;
            this.Balance2.HeaderText = "Segundo Saldo";
            this.Balance2.Name = "Balance2";
            this.Balance2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Balance2.Width = 140;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.cbCuentas);
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 82);
            this.panel1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1.10: Activos corrientes",
            "1.11: Activos no corrientes",
            "1.12: Activos diferidos",
            "2.20: Pasivos C/P",
            "2.21: Pasivos L/P",
            "3.30 : Capital Contable\t"});
            this.listBox1.Location = new System.Drawing.Point(80, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 69);
            this.listBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSecondPeriod);
            this.groupBox1.Controls.Add(this.rbtnFirstPeriod);
            this.groupBox1.Location = new System.Drawing.Point(693, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbtnSecondPeriod
            // 
            this.rbtnSecondPeriod.AutoSize = true;
            this.rbtnSecondPeriod.Location = new System.Drawing.Point(21, 37);
            this.rbtnSecondPeriod.Name = "rbtnSecondPeriod";
            this.rbtnSecondPeriod.Size = new System.Drawing.Size(70, 17);
            this.rbtnSecondPeriod.TabIndex = 1;
            this.rbtnSecondPeriod.TabStop = true;
            this.rbtnSecondPeriod.Text = "Periodo 2";
            this.rbtnSecondPeriod.UseVisualStyleBackColor = true;
            // 
            // rbtnFirstPeriod
            // 
            this.rbtnFirstPeriod.AutoSize = true;
            this.rbtnFirstPeriod.Location = new System.Drawing.Point(21, 14);
            this.rbtnFirstPeriod.Name = "rbtnFirstPeriod";
            this.rbtnFirstPeriod.Size = new System.Drawing.Size(70, 17);
            this.rbtnFirstPeriod.TabIndex = 0;
            this.rbtnFirstPeriod.TabStop = true;
            this.rbtnFirstPeriod.Text = "Periodo 1";
            this.rbtnFirstPeriod.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(961, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 26);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(826, 19);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(113, 16);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Nuevo Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(811, 38);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(144, 20);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.TextChanged += new System.EventHandler(this.txtBalance_TextChanged);
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // cbCuentas
            // 
            this.cbCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentas.FormattingEnabled = true;
            this.cbCuentas.Items.AddRange(new object[] {
            "Caja",
            "Fondo fijo de caja",
            "Bancos",
            "Acciones y valores",
            "Clientes",
            "Deudores diversos",
            "Intereses por cobrar",
            "Inventarios (de mercancías)",
            "Inventarios (de materias primas)",
            "Almacén ",
            "IVA acreditable",
            "IVA por acreditar",
            "Documentos por cobrar",
            "Mercancías en consignación ",
            "Mercancías en tránsito",
            "Rentas pagadas por anticipado",
            "Seguros y fianzas pagados por anticipado ",
            "Promoción y publicidad pagada por anticipado",
            "Anticipo a proveedores",
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
            "Acciones y valores a largo plazo",
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
            "Intereses pagados por anticipado",
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
            "Rentas cobradas por anticipado",
            "Créditos bancarios(a largo plazo)",
            "Documentos por pagar bancos L/P",
            "Hipoteca por pagar y/o acreedor hipotecario",
            "Intereses cobrados por anticipado a largo plazo",
            "Rentas cobradas por anticipado a largo plazo",
            "Documentos por pagar L/P",
            "Capital social",
            "Reservas",
            "Resultado del ejercicio",
            "Resultado de ejercicios anteriores",
            "Superávit por revaluación"});
            this.cbCuentas.Location = new System.Drawing.Point(386, 28);
            this.cbCuentas.Name = "cbCuentas";
            this.cbCuentas.Size = new System.Drawing.Size(287, 23);
            this.cbCuentas.TabIndex = 0;
            this.cbCuentas.Text = "                  <Seleccionar cuenta>";
            // 
            // FrmCtlBalanceSheetAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmCtlBalanceSheetAccounts";
            this.Text = "FrmCtlBalanceSheetAccounts";
            this.Load += new System.EventHandler(this.FrmCtlBalanceSheetAccounts_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView catalogTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridView BalanceModifierTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSecondPeriod;
        private System.Windows.Forms.RadioButton rbtnFirstPeriod;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cbCuentas;
    }
}