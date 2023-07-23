namespace GUI.Catalogs
{
    partial class FrmCtlProfitAndLossAccountsPeriod1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCtlProfitAndLossAccountsPeriod1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.catalogTable = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BalanceModifierTable = new System.Windows.Forms.DataGridView();
            this.Nombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cbCuentas = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightGreen;
            this.flowLayoutPanel1.Controls.Add(this.catalogTable);
            this.flowLayoutPanel1.Controls.Add(this.BalanceModifierTable);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-2, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(863, 409);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.catalogTable.Size = new System.Drawing.Size(425, 401);
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
            this.Nombre.Width = 260;
            // 
            // BalanceModifierTable
            // 
            this.BalanceModifierTable.AllowUserToAddRows = false;
            this.BalanceModifierTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceModifierTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre2,
            this.Balance});
            this.BalanceModifierTable.Location = new System.Drawing.Point(434, 3);
            this.BalanceModifierTable.Name = "BalanceModifierTable";
            this.BalanceModifierTable.Size = new System.Drawing.Size(420, 401);
            this.BalanceModifierTable.TabIndex = 1;
            // 
            // Nombre2
            // 
            this.Nombre2.HeaderText = "Nombre";
            this.Nombre2.Name = "Nombre2";
            this.Nombre2.Width = 260;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OliveDrab;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblBalance);
            this.panel1.Controls.Add(this.txtBalance);
            this.panel1.Controls.Add(this.cbCuentas);
            this.panel1.Location = new System.Drawing.Point(-2, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 82);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(531, 25);
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
            this.lblBalance.Location = new System.Drawing.Point(398, 11);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(113, 16);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Nuevo Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(381, 30);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(144, 20);
            this.txtBalance.TabIndex = 1;
            this.txtBalance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBalance_KeyPress);
            // 
            // cbCuentas
            // 
            this.cbCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCuentas.FormattingEnabled = true;
            this.cbCuentas.Items.AddRange(new object[] {
            "Ventas en territorio nacional",
            "Ventas en territorio extranjero (exportación)",
            "Devoluciones sobre las ventas nacionales",
            "Devoluciones sobre las ventas extranjeras",
            "Rebajas sobre las ventas nacionales",
            "Rebajas sobre las ventas extranjeras",
            "Intereses ganados sobre inversiones realizadas en moneda nacional",
            "Intereses ganados sobre inversiones realizadas en moneda extranjera",
            "Intereses ganados sobre préstamos otorgados",
            "Intereses ganados por cheques devueltos",
            "Utilidad ganada en cambios de moneda extranjera",
            "Descuentos aprovechados por pronto pago",
            "Productos financieros ganados en operaciones diversas",
            "Ventas de productos no considerados como mercancías",
            "Otros ingresos diversos",
            "Renta de locales",
            "Venta de activos fijos",
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
            "Gastos de mantenimiento del equipo de reparto",
            "Impuesto sobre ingresos mercantiles",
            "Alquiler de local de departamento de ventas",
            "Mantenimiento de equipo electrónico de cómputo",
            "Mantenimiento de equipo de oficina",
            "Mantenimiento de equipo de transporte",
            "Pago de luz",
            "Pago de agua",
            "Pago de internet",
            "Pago de servicios telefonicos (ventas)",
            "Gasto de combustible",
            "Depreciación de inmobiliario",
            "Depreciación de equipo de reparto",
            "Depreciación de equipo de cómputo",
            "Depreciación de equipo de transporte",
            "Amortizaciones varias",
            "Propaganda y publicidad",
            "Sueldos normales (ordinarios)",
            "Sueldos extraordinarios (tiempo extra)",
            "Prestaciones normales (ordinarios)",
            "Impuestos y aportaciones patronales",
            "Gastos de viaje",
            "Consumo de papelería y útiles de oficina",
            "Pago de luz",
            "Pagos efectuados por servicio telefónico",
            "Gastos de correo y telégrafos",
            "Arrendamientos de oficinas y locales",
            "Mantenimiento de equipo electrónico de cómputo",
            "Mantenimiento de equipo de oficina",
            "Mantenimiento de edificios",
            "Mantenimiento de equipo de transporte",
            "Depreciación histórica de equipo de transporte",
            "Amortizaciones varias",
            "Comisiones bancarias",
            "Intereses pagados",
            "Intereses pagados a terceros",
            "Pérdida en cambios de moneda extranjera",
            "Pérdida en cambios por operaciones diversas",
            "Donativos",
            "Obsequios",
            "Otros gastos diversos",
            "Pérdida en venta de activos fijos"});
            this.cbCuentas.Location = new System.Drawing.Point(88, 25);
            this.cbCuentas.Name = "cbCuentas";
            this.cbCuentas.Size = new System.Drawing.Size(287, 23);
            this.cbCuentas.TabIndex = 0;
            this.cbCuentas.Text = "                  <Seleccionar cuenta>";
            // 
            // TestProfitAndLossAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 488);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestProfitAndLossAccounts";
            this.Text = "Catalogo Estado de resutlado Periodo #1";
            this.Load += new System.EventHandler(this.FrmProfitAndLossAccountsPeriod1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.catalogTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceModifierTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView catalogTable;
        private System.Windows.Forms.DataGridView BalanceModifierTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCuentas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtBalance;
    }
}