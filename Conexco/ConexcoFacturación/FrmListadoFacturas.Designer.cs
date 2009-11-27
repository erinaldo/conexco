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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).BeginInit();
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
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 191);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Factura";
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
            this.Text = "FrmListadoFacturas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFacturas)).EndInit();
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
    }
}