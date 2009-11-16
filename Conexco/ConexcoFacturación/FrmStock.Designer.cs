namespace ConexcoFacturación
{
    partial class FrmStock
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
            this.grdArticulosStock = new System.Windows.Forms.DataGridView();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.gbxCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnColor = new System.Windows.Forms.RadioButton();
            this.rbtnCodigoArticulo = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosStock)).BeginInit();
            this.gbxCriteriosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdArticulosStock
            // 
            this.grdArticulosStock.AllowUserToAddRows = false;
            this.grdArticulosStock.AllowUserToDeleteRows = false;
            this.grdArticulosStock.AllowUserToOrderColumns = true;
            this.grdArticulosStock.AllowUserToResizeColumns = false;
            this.grdArticulosStock.AllowUserToResizeRows = false;
            this.grdArticulosStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdArticulosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulosStock.Location = new System.Drawing.Point(12, 69);
            this.grdArticulosStock.MultiSelect = false;
            this.grdArticulosStock.Name = "grdArticulosStock";
            this.grdArticulosStock.ReadOnly = true;
            this.grdArticulosStock.Size = new System.Drawing.Size(521, 262);
            this.grdArticulosStock.TabIndex = 0;
            this.grdArticulosStock.SelectionChanged += new System.EventHandler(this.OnArticuloSeleccionado);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Enabled = false;
            this.btnIngreso.Location = new System.Drawing.Point(156, 353);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(89, 23);
            this.btnIngreso.TabIndex = 1;
            this.btnIngreso.Text = "Ingreso Stock";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnEgreso
            // 
            this.btnEgreso.Enabled = false;
            this.btnEgreso.Location = new System.Drawing.Point(265, 353);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(89, 23);
            this.btnEgreso.TabIndex = 2;
            this.btnEgreso.Text = "Egreso Stock";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // gbxCriteriosBusqueda
            // 
            this.gbxCriteriosBusqueda.Controls.Add(this.txtValorBusqueda);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnColor);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCodigoArticulo);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnDescripcion);
            this.gbxCriteriosBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbxCriteriosBusqueda.Name = "gbxCriteriosBusqueda";
            this.gbxCriteriosBusqueda.Size = new System.Drawing.Size(524, 51);
            this.gbxCriteriosBusqueda.TabIndex = 3;
            this.gbxCriteriosBusqueda.TabStop = false;
            this.gbxCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(338, 16);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(171, 20);
            this.txtValorBusqueda.TabIndex = 8;
            this.txtValorBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnKeyPress_Busqueda);
            // 
            // rbtnColor
            // 
            this.rbtnColor.AutoSize = true;
            this.rbtnColor.Location = new System.Drawing.Point(221, 19);
            this.rbtnColor.Name = "rbtnColor";
            this.rbtnColor.Size = new System.Drawing.Size(85, 17);
            this.rbtnColor.TabIndex = 2;
            this.rbtnColor.Text = "Código Color";
            this.rbtnColor.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigoArticulo
            // 
            this.rbtnCodigoArticulo.AutoSize = true;
            this.rbtnCodigoArticulo.Checked = true;
            this.rbtnCodigoArticulo.Location = new System.Drawing.Point(13, 19);
            this.rbtnCodigoArticulo.Name = "rbtnCodigoArticulo";
            this.rbtnCodigoArticulo.Size = new System.Drawing.Size(111, 17);
            this.rbtnCodigoArticulo.TabIndex = 1;
            this.rbtnCodigoArticulo.TabStop = true;
            this.rbtnCodigoArticulo.Text = "Código de Articulo";
            this.rbtnCodigoArticulo.UseVisualStyleBackColor = true;
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Location = new System.Drawing.Point(130, 19);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(81, 17);
            this.rbtnDescripcion.TabIndex = 0;
            this.rbtnDescripcion.Text = "Descripción";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 402);
            this.Controls.Add(this.gbxCriteriosBusqueda);
            this.Controls.Add(this.btnEgreso);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.grdArticulosStock);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosStock)).EndInit();
            this.gbxCriteriosBusqueda.ResumeLayout(false);
            this.gbxCriteriosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArticulosStock;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnEgreso;
        private System.Windows.Forms.GroupBox gbxCriteriosBusqueda;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.RadioButton rbtnColor;
        private System.Windows.Forms.RadioButton rbtnCodigoArticulo;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
    }
}