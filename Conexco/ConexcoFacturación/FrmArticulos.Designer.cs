namespace ConexcoFacturación
{
    partial class FrmArticulos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliiminar = new System.Windows.Forms.Button();
            this.toolTipArticulos = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Location = new System.Drawing.Point(140, 261);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Tag = "";
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipArticulos.SetToolTip(this.btnAgregar, "Agregar nuevo artículo.");
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.OnArticuloAgregar);
            // 
            // grdArticulos
            // 
            this.grdArticulos.AllowUserToAddRows = false;
            this.grdArticulos.AllowUserToDeleteRows = false;
            this.grdArticulos.AllowUserToResizeColumns = false;
            this.grdArticulos.AllowUserToResizeRows = false;
            this.grdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulos.Location = new System.Drawing.Point(13, 13);
            this.grdArticulos.MultiSelect = false;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArticulos.Size = new System.Drawing.Size(543, 230);
            this.grdArticulos.TabIndex = 7;
            this.grdArticulos.SelectionChanged += new System.EventHandler(this.OnArticuloSeleccionado);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(231, 261);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipArticulos.SetToolTip(this.btnModificar, "Modificar artículo seleccionado.");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.OnArticuloModificar);
            // 
            // btnEliiminar
            // 
            this.btnEliiminar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.eliminar;
            this.btnEliiminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliiminar.Enabled = false;
            this.btnEliiminar.Location = new System.Drawing.Point(327, 261);
            this.btnEliiminar.Name = "btnEliiminar";
            this.btnEliiminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliiminar.TabIndex = 9;
            this.btnEliiminar.Text = "Eliminar";
            this.btnEliiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipArticulos.SetToolTip(this.btnEliiminar, "Eliminar artículo seleccionado.");
            this.btnEliiminar.UseVisualStyleBackColor = true;
            this.btnEliiminar.Click += new System.EventHandler(this.OnArticuloEliminar);
            // 
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(571, 305);
            this.Controls.Add(this.btnEliiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdArticulos);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.Name = "FrmArticulos";
            this.Text = "Stock Articulos";
            this.Load += new System.EventHandler(this.FrmArticulosStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliiminar;
        private System.Windows.Forms.ToolTip toolTipArticulos;
    }
}