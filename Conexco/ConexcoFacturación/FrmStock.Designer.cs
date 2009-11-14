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
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosStock)).BeginInit();
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
            this.grdArticulosStock.Location = new System.Drawing.Point(12, 81);
            this.grdArticulosStock.MultiSelect = false;
            this.grdArticulosStock.Name = "grdArticulosStock";
            this.grdArticulosStock.ReadOnly = true;
            this.grdArticulosStock.Size = new System.Drawing.Size(521, 175);
            this.grdArticulosStock.TabIndex = 0;
            this.grdArticulosStock.SelectionChanged += new System.EventHandler(this.OnArticuloSeleccionado);
            // 
            // btnIngreso
            // 
            this.btnIngreso.Enabled = false;
            this.btnIngreso.Location = new System.Drawing.Point(154, 279);
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
            this.btnEgreso.Location = new System.Drawing.Point(263, 279);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(89, 23);
            this.btnEgreso.TabIndex = 2;
            this.btnEgreso.Text = "Egreso Stock";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.btnEgreso);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.grdArticulosStock);
            this.Name = "FrmStock";
            this.Text = "FrmStock";
            this.Load += new System.EventHandler(this.FrmStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulosStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdArticulosStock;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnEgreso;
    }
}