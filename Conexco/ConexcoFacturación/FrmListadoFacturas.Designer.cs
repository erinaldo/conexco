namespace ConexcoFacturación
{
    partial class FrmListadoFacturas
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAnuladas = new System.Windows.Forms.RadioButton();
            this.rdPendientes = new System.Windows.Forms.RadioButton();
            this.rdPagadas = new System.Windows.Forms.RadioButton();
            this.rdTodas = new System.Windows.Forms.RadioButton();
            this.gridFacturas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.labelll = new System.Windows.Forms.Label();
            this.txtVto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rdAnuladas);
            this.groupBox1.Controls.Add(this.rdPendientes);
            this.groupBox1.Controls.Add(this.rdPagadas);
            this.groupBox1.Controls.Add(this.rdTodas);
            this.groupBox1.Controls.Add(this.gridFacturas);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado Facturas";
            // 
            // rdAnuladas
            // 
            this.rdAnuladas.AutoSize = true;
            this.rdAnuladas.Location = new System.Drawing.Point(418, 21);
            this.rdAnuladas.Name = "rdAnuladas";
            this.rdAnuladas.Size = new System.Drawing.Size(105, 17);
            this.rdAnuladas.TabIndex = 3;
            this.rdAnuladas.TabStop = true;
            this.rdAnuladas.Text = "Anuladas            ";
            this.toolTip1.SetToolTip(this.rdAnuladas, "Muestra sólo las Facturas Anuladas.");
            this.rdAnuladas.UseVisualStyleBackColor = true;
            this.rdAnuladas.CheckedChanged += new System.EventHandler(this.CheckedCriterioFiltroChange);
            // 
            // rdPendientes
            // 
            this.rdPendientes.AutoSize = true;
            this.rdPendientes.Location = new System.Drawing.Point(303, 21);
            this.rdPendientes.Name = "rdPendientes";
            this.rdPendientes.Size = new System.Drawing.Size(93, 17);
            this.rdPendientes.TabIndex = 2;
            this.rdPendientes.TabStop = true;
            this.rdPendientes.Text = "Pendientes     ";
            this.toolTip1.SetToolTip(this.rdPendientes, "Muestra sólo las Facturas Pendientes.");
            this.rdPendientes.UseVisualStyleBackColor = true;
            this.rdPendientes.CheckedChanged += new System.EventHandler(this.CheckedCriterioFiltroChange);
            // 
            // rdPagadas
            // 
            this.rdPagadas.AutoSize = true;
            this.rdPagadas.Location = new System.Drawing.Point(190, 21);
            this.rdPagadas.Name = "rdPagadas";
            this.rdPagadas.Size = new System.Drawing.Size(91, 17);
            this.rdPagadas.TabIndex = 1;
            this.rdPagadas.TabStop = true;
            this.rdPagadas.Text = "Pagadas        ";
            this.toolTip1.SetToolTip(this.rdPagadas, "Muestra sólo las Facturas Pagadas.");
            this.rdPagadas.UseVisualStyleBackColor = true;
            this.rdPagadas.CheckedChanged += new System.EventHandler(this.CheckedCriterioFiltroChange);
            // 
            // rdTodas
            // 
            this.rdTodas.AutoSize = true;
            this.rdTodas.Location = new System.Drawing.Point(76, 21);
            this.rdTodas.Name = "rdTodas";
            this.rdTodas.Size = new System.Drawing.Size(92, 17);
            this.rdTodas.TabIndex = 0;
            this.rdTodas.TabStop = true;
            this.rdTodas.Text = "Ver Todas      ";
            this.toolTip1.SetToolTip(this.rdTodas, "Muestra todas las Facutras.");
            this.rdTodas.UseVisualStyleBackColor = true;
            this.rdTodas.CheckedChanged += new System.EventHandler(this.CheckedCriterioFiltroChange);
            // 
            // gridFacturas
            // 
            this.gridFacturas.AllowUserToAddRows = false;
            this.gridFacturas.AllowUserToDeleteRows = false;
            this.gridFacturas.AllowUserToResizeColumns = false;
            this.gridFacturas.AllowUserToResizeRows = false;
            this.gridFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFacturas.Location = new System.Drawing.Point(7, 53);
            this.gridFacturas.MultiSelect = false;
            this.gridFacturas.Name = "gridFacturas";
            this.gridFacturas.ReadOnly = true;
            this.gridFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFacturas.Size = new System.Drawing.Size(585, 185);
            this.gridFacturas.TabIndex = 4;
            this.gridFacturas.SelectionChanged += new System.EventHandler(this.gridFacturas_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.btnGuardar);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Factura";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboEstado);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(380, 36);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 63);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // comboEstado
            // 
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(60, 26);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(121, 21);
            this.comboEstado.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDesc);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtNeto);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtIVA);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtCliente);
            this.groupBox4.Controls.Add(this.labelll);
            this.groupBox4.Controls.Add(this.txtVto);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtNumero);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtTipo);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(7, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 157);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(284, 59);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(64, 20);
            this.txtDesc.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(213, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Descuentos:";
            // 
            // txtNeto
            // 
            this.txtNeto.Location = new System.Drawing.Point(284, 110);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.ReadOnly = true;
            this.txtNeto.Size = new System.Drawing.Size(64, 20);
            this.txtNeto.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Neto:";
            // 
            // txtIVA
            // 
            this.txtIVA.Location = new System.Drawing.Point(284, 84);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(64, 20);
            this.txtIVA.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total IVA:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(284, 33);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(64, 20);
            this.txtTotal.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(213, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(77, 125);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 9;
            // 
            // labelll
            // 
            this.labelll.AutoSize = true;
            this.labelll.Location = new System.Drawing.Point(6, 128);
            this.labelll.Name = "labelll";
            this.labelll.Size = new System.Drawing.Size(42, 13);
            this.labelll.TabIndex = 8;
            this.labelll.Text = "Cliente:";
            // 
            // txtVto
            // 
            this.txtVto.Location = new System.Drawing.Point(77, 90);
            this.txtVto.Name = "txtVto";
            this.txtVto.ReadOnly = true;
            this.txtVto.Size = new System.Drawing.Size(100, 20);
            this.txtVto.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vencimiento:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(77, 55);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "N° Factura:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(43, 23);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(24, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(440, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 31);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "       Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmListadoFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(623, 471);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListadoFacturas";
            this.Text = "Listado de Facturas";
            this.Load += new System.EventHandler(this.FrmListadoFacturas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridFacturas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdPendientes;
        private System.Windows.Forms.RadioButton rdPagadas;
        private System.Windows.Forms.RadioButton rdTodas;
        private System.Windows.Forms.RadioButton rdAnuladas;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label labelll;
        private System.Windows.Forms.TextBox txtVto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
    }
}