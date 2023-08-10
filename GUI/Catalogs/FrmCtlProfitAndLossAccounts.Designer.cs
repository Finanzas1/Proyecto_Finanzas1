namespace GUI.Catalogs
{
    partial class FrmCtlProfitAndLossAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCtlProfitAndLossAccounts));
            this.BalanceModifierTable = new System.Windows.Forms.DataGridView();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catalogTable = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbCuentas = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSecondPeriod = new System.Windows.Forms.RadioButton();
            this.rbtnFirstPeriod = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel1.Controls.Add(this.catalogTable);
            this.flowLayoutPanel1.Controls.Add(this.BalanceModifierTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1197, 409);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbCuentas
            // 
            this.cbCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentas.FormattingEnabled = true;
            this.cbCuentas.Items.AddRange(new object[] {
            "Ventas",
            "Devoluciones sobre las ventas",
            "Rebajas sobre las ventas",
            "Intereses ganados sobre inversiones realizadas en moneda nacional",
            "Intereses ganados sobre inversiones realizadas en moneda extranjera",
            "Intereses ganados sobre préstamos otorgados",
            "Utilidad ganada en cambios de moneda extranjera",
            "Descuentos aprovechados por pronto pago",
            "Productos financieros ganados en operaciones diversas",
            "Ventas de productos no considerados como mercancías",
            "Otros ingresos diversos",
            "Venta de desperdicio",
            "Otros productos diversos",
            "Compras",
            "Gastos de compras",
            "Compras totales",
            "Devoluciones sobre compras",
            "Rebajas sobre compras",
            "Compras netas",
            "Invetario inicial",
            "Inventario final",
            "Costo de ventas",
            "Sueldos normales (ordinarios)",
            "Prestaciones normales (ordinarios)",
            "Sueldos extraordinarios (tiempo extra)",
            "Comisiones de agentes y dependientes",
            "Impuestos y aportaciones patronales",
            "Gastos de viaje",
            "Consumo de etiquetas",
            "Envolturas y empaques",
            "Fletes y acarreo de las mercancías vendidas",
            "Impuesto sobre ingresos mercantiles",
            "Alquiler de local de departamento de ventas",
            "Mantenimiento de equipo electrónico de cómputo",
            "Pago de luz",
            "Pago de agua",
            "Pago de internet",
            "Pago de servicios telefonicos (ventas)",
            "Gasto de combustible",
            "Depreciación de inmobiliario",
            "Depreciación de equipo de cómputo",
            "Amortizaciones varias",
            "Propaganda y publicidad",
            "Sueldos normales (ordinarios)",
            "Sueldos extraordinarios (tiempo extra)",
            "Prestaciones normales (ordinarios)",
            "Impuestos y aportaciones patronales",
            "Consumo de papelería y útiles de oficina",
            "Pago de luz",
            "Pagos efectuados por servicio telefónico",
            "Arrendamientos de oficinas y locales",
            "Mantenimiento de equipo electrónico de cómputo",
            "Mantenimiento de edificios",
            "Amortizaciones varias",
            "Comisiones bancarias",
            "Intereses pagados",
            "Intereses pagados a terceros",
            "Pérdida en cambios de moneda extranjera",
            "Pérdida en cambios por operaciones diversas",
            "Donativos",
            "Obsequios",
            "Otros gastos diversos",
            "Impuestos(IR)",
            "Dividendos Preferentes",
            "Dividendos Comunes",
            "Utilidad Bruta",
            "Utilidad de Operación",
            "Utilidad Neta"});
            this.cbCuentas.Location = new System.Drawing.Point(386, 28);
            this.cbCuentas.Name = "cbCuentas";
            this.cbCuentas.Size = new System.Drawing.Size(287, 23);
            this.cbCuentas.TabIndex = 0;
            this.cbCuentas.Text = "                  <Seleccionar cuenta>";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.cbCuentas);
            this.panel1.Location = new System.Drawing.Point(-2, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 82);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "4.01 : Ventas",
            "4.02 : Productos financieros ",
            "4.03 : Otros ingresos",
            "4.04 : Otros productos",
            "5.01 : Cuentas de costos",
            "5.02 : Gastos de ventas",
            "5.03 : Gastos administrativos",
            "5.04 : Gastos financieros",
            "5.05 : Otros gastos",
            "5.06: Miscelaneos",
            "6.01 : Cuentas de resultados"});
            this.listBox1.Location = new System.Drawing.Point(80, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(211, 69);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // FrmCtlProfitAndLossAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCtlProfitAndLossAccounts";
            this.Text = "Catalogo Estado de resutlado Periodo #1";
            this.Load += new System.EventHandler(this.FrmProfitAndLossAccountsPeriod1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView BalanceModifierTable;
        private System.Windows.Forms.DataGridView catalogTable;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cbCuentas;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSecondPeriod;
        private System.Windows.Forms.RadioButton rbtnFirstPeriod;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}