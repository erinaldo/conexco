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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulos));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdArticulos = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliiminar = new System.Windows.Forms.Button();
            this.toolTipArticulos = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.rbtnColor = new System.Windows.Forms.RadioButton();
            this.rbtnCodigoArticulo = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).BeginInit();
            this.gbxCriteriosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.agregar;
            this.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregar.Location = new System.Drawing.Point(215, 322);
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
            this.grdArticulos.AllowUserToResizeRows = false;
            this.grdArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdArticulos.Location = new System.Drawing.Point(12, 63);
            this.grdArticulos.MultiSelect = false;
            this.grdArticulos.Name = "grdArticulos";
            this.grdArticulos.ReadOnly = true;
            this.grdArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdArticulos.Size = new System.Drawing.Size(668, 244);
            this.grdArticulos.TabIndex = 7;
            this.grdArticulos.SelectionChanged += new System.EventHandler(this.OnArticuloSeleccionado);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(306, 322);
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
            this.btnEliiminar.Location = new System.Drawing.Point(402, 322);
            this.btnEliiminar.Name = "btnEliiminar";
            this.btnEliiminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliiminar.TabIndex = 9;
            this.btnEliiminar.Text = "Eliminar";
            this.btnEliiminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipArticulos.SetToolTip(this.btnEliiminar, "Eliminar artículo seleccionado.");
            this.btnEliiminar.UseVisualStyleBackColor = true;
            this.btnEliiminar.Click += new System.EventHandler(this.OnArticuloEliminar);
            // 
            // gbxCriteriosBusqueda
            // 
            this.gbxCriteriosBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbxCriteriosBusqueda.Controls.Add(this.txtValorBusqueda);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnColor);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCodigoArticulo);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnDescripcion);
            this.gbxCriteriosBusqueda.Location = new System.Drawing.Point(12, 5);
            this.gbxCriteriosBusqueda.Name = "gbxCriteriosBusqueda";
            this.gbxCriteriosBusqueda.Size = new System.Drawing.Size(670, 51);
            this.gbxCriteriosBusqueda.TabIndex = 10;
            this.gbxCriteriosBusqueda.TabStop = false;
            this.gbxCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(340, 16);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(171, 20);
            this.txtValorBusqueda.TabIndex = 8;
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
            // FrmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(692, 366);
            this.Controls.Add(this.gbxCriteriosBusqueda);
            this.Controls.Add(this.btnEliiminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grdArticulos);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmArticulos";
            this.Text = "Administración de Articulos";
            this.Load += new System.EventHandler(this.FrmArticulosStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdArticulos)).EndInit();
            this.gbxCriteriosBusqueda.ResumeLayout(false);
            this.gbxCriteriosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView grdArticulos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliiminar;
        private System.Windows.Forms.ToolTip toolTipArticulos;
        private System.Windows.Forms.GroupBox gbxCriteriosBusqueda;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.RadioButton rbtnColor;
        private System.Windows.Forms.RadioButton rbtnCodigoArticulo;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
    }
}