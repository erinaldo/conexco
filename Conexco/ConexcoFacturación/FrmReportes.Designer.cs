namespace ConexcoFacturación
{
    partial class FrmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportes));
            this.btnStockActual = new System.Windows.Forms.Button();
            this.btnStockActualDesc = new System.Windows.Forms.Button();
            this.btnFacturasEmitidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStockActual
            // 
            this.btnStockActual.BackgroundImage = global::ConexcoFacturación.Properties.Resources.imprimir3;
            this.btnStockActual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockActual.Location = new System.Drawing.Point(12, 37);
            this.btnStockActual.Name = "btnStockActual";
            this.btnStockActual.Size = new System.Drawing.Size(260, 31);
            this.btnStockActual.TabIndex = 19;
            this.btnStockActual.Text = "Listado Stock Actual";
            this.btnStockActual.UseVisualStyleBackColor = true;
            this.btnStockActual.Click += new System.EventHandler(this.btnStockActual_Click);
            // 
            // btnStockActualDesc
            // 
            this.btnStockActualDesc.BackgroundImage = global::ConexcoFacturación.Properties.Resources.imprimir3;
            this.btnStockActualDesc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStockActualDesc.Location = new System.Drawing.Point(12, 116);
            this.btnStockActualDesc.Name = "btnStockActualDesc";
            this.btnStockActualDesc.Size = new System.Drawing.Size(260, 31);
            this.btnStockActualDesc.TabIndex = 20;
            this.btnStockActualDesc.Text = "Listado Stock Actual con Descripción";
            this.btnStockActualDesc.UseVisualStyleBackColor = true;
            this.btnStockActualDesc.Click += new System.EventHandler(this.btnStockActualDesc_Click);
            // 
            // btnFacturasEmitidas
            // 
            this.btnFacturasEmitidas.BackgroundImage = global::ConexcoFacturación.Properties.Resources.imprimir3;
            this.btnFacturasEmitidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFacturasEmitidas.Location = new System.Drawing.Point(12, 195);
            this.btnFacturasEmitidas.Name = "btnFacturasEmitidas";
            this.btnFacturasEmitidas.Size = new System.Drawing.Size(260, 31);
            this.btnFacturasEmitidas.TabIndex = 21;
            this.btnFacturasEmitidas.Text = "Listado Facturas Emitidas";
            this.btnFacturasEmitidas.UseVisualStyleBackColor = true;
            this.btnFacturasEmitidas.Click += new System.EventHandler(this.btnFacturasEmitidas_Click);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnFacturasEmitidas);
            this.Controls.Add(this.btnStockActualDesc);
            this.Controls.Add(this.btnStockActual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.Text = "Reportes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStockActual;
        private System.Windows.Forms.Button btnStockActualDesc;
        private System.Windows.Forms.Button btnFacturasEmitidas;

    }
}