namespace ConexcoFacturación
{
    partial class FrmClientesTelefonos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesTelefonos));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxTelefono = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdTelefonos = new System.Windows.Forms.DataGridView();
            this.toolTipClientes = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxTelefono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(10, 170);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnGuardar, "Guardar cambios");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::ConexcoFacturación.Properties.Resources.salir3;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Location = new System.Drawing.Point(553, 170);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Location = new System.Drawing.Point(259, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnEliminar, "Eliminar Teléfono seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Location = new System.Drawing.Point(171, 170);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnModificar, "Modificar Teléfono seleccionado");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::ConexcoFacturación.Properties.Resources.agregar;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Location = new System.Drawing.Point(93, 170);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 30);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnNuevo, "Habilita los campos para un nuevo Teléfono");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxTelefono
            // 
            this.gbxTelefono.BackColor = System.Drawing.Color.Transparent;
            this.gbxTelefono.Controls.Add(this.txtDescripcion);
            this.gbxTelefono.Controls.Add(this.lblDescripcion);
            this.gbxTelefono.Controls.Add(this.lblTelefono);
            this.gbxTelefono.Controls.Add(this.txtTelefono);
            this.gbxTelefono.Controls.Add(this.lblFax);
            this.gbxTelefono.Controls.Add(this.txtFax);
            this.gbxTelefono.Enabled = false;
            this.gbxTelefono.Location = new System.Drawing.Point(406, 43);
            this.gbxTelefono.Name = "gbxTelefono";
            this.gbxTelefono.Size = new System.Drawing.Size(222, 106);
            this.gbxTelefono.TabIndex = 2;
            this.gbxTelefono.TabStop = false;
            this.gbxTelefono.Text = "Detalle";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 71);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcion.TabIndex = 2;
            this.toolTipClientes.SetToolTip(this.txtDescripcion, "Descripción del Teléfono (Ej. Principal)");
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(19, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 48;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(33, 24);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 26;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Azure;
            this.txtTelefono.Location = new System.Drawing.Point(97, 19);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 0;
            this.toolTipClientes.SetToolTip(this.txtTelefono, "Teléfono del Cliente");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(58, 50);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 41;
            this.lblFax.Text = "Fax";
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.Color.Azure;
            this.txtFax.Location = new System.Drawing.Point(97, 45);
            this.txtFax.MaxLength = 10;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 1;
            this.toolTipClientes.SetToolTip(this.txtFax, "Fax del Cliente, opcional");
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(129, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(111, 13);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Teléfonos del cliente: ";
            // 
            // grdTelefonos
            // 
            this.grdTelefonos.AllowUserToAddRows = false;
            this.grdTelefonos.AllowUserToDeleteRows = false;
            this.grdTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTelefonos.Location = new System.Drawing.Point(12, 43);
            this.grdTelefonos.MultiSelect = false;
            this.grdTelefonos.Name = "grdTelefonos";
            this.grdTelefonos.ReadOnly = true;
            this.grdTelefonos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTelefonos.Size = new System.Drawing.Size(376, 106);
            this.grdTelefonos.TabIndex = 0;
            this.grdTelefonos.SelectionChanged += new System.EventHandler(this.grdTelefonos_SelectionChanged);
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmClientesTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(641, 213);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxTelefono);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdTelefonos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FrmClientesTelefonos";
            this.Text = "Telefonos de cliente";
            this.Load += new System.EventHandler(this.FrmClientesTelefonos_Load);
            this.gbxTelefono.ResumeLayout(false);
            this.gbxTelefono.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTelefonos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxTelefono;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdTelefonos;
        private System.Windows.Forms.ToolTip toolTipClientes;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;

    }
}