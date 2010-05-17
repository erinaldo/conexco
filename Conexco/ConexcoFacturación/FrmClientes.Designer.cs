namespace ConexcoFacturación
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDomicilios = new System.Windows.Forms.Button();
            this.btnTelefonos = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.btnTransportistas = new System.Windows.Forms.Button();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.toolTipClientes = new System.Windows.Forms.ToolTip(this.components);
            this.gbxCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblValorBusqueda = new System.Windows.Forms.Label();
            this.rbtnCodPostal = new System.Windows.Forms.RadioButton();
            this.rbtnLocalidad = new System.Windows.Forms.RadioButton();
            this.rbtnCondIva = new System.Windows.Forms.RadioButton();
            this.rbtnCuit = new System.Windows.Forms.RadioButton();
            this.rbtnCodigoCliente = new System.Windows.Forms.RadioButton();
            this.rbtnNombreRazonSocial = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.gbxCriteriosBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.BackgroundImage = global::ConexcoFacturación.Properties.Resources.agregar;
            this.btnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgregarCliente.Location = new System.Drawing.Point(12, 415);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 31);
            this.btnAgregarCliente.TabIndex = 1;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnAgregarCliente, "Agrega un cliente nuevo");
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackgroundImage = global::ConexcoFacturación.Properties.Resources.modificar;
            this.btnModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificarCliente.Enabled = false;
            this.btnModificarCliente.Location = new System.Drawing.Point(117, 415);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(79, 31);
            this.btnModificarCliente.TabIndex = 2;
            this.btnModificarCliente.Text = "Modificar";
            this.btnModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnModificarCliente, "Modifica el cliente seleccionado");
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.BackgroundImage = global::ConexcoFacturación.Properties.Resources.eliminar;
            this.btnEliminarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminarCliente.Enabled = false;
            this.btnEliminarCliente.Location = new System.Drawing.Point(226, 415);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 31);
            this.btnEliminarCliente.TabIndex = 3;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnEliminarCliente, "Elimina un cliente");
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::ConexcoFacturación.Properties.Resources.salir3;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Location = new System.Drawing.Point(603, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 31);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDomicilios
            // 
            this.btnDomicilios.BackgroundImage = global::ConexcoFacturación.Properties.Resources.administrar;
            this.btnDomicilios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDomicilios.Enabled = false;
            this.btnDomicilios.Location = new System.Drawing.Point(575, 120);
            this.btnDomicilios.Name = "btnDomicilios";
            this.btnDomicilios.Size = new System.Drawing.Size(103, 31);
            this.btnDomicilios.TabIndex = 4;
            this.btnDomicilios.Text = "Domicilios";
            this.btnDomicilios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnDomicilios, "Administrar domicilios del cliente");
            this.btnDomicilios.UseVisualStyleBackColor = true;
            this.btnDomicilios.Click += new System.EventHandler(this.btnDomicilios_Click);
            // 
            // btnTelefonos
            // 
            this.btnTelefonos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTelefonos.BackgroundImage")));
            this.btnTelefonos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTelefonos.Enabled = false;
            this.btnTelefonos.Location = new System.Drawing.Point(575, 161);
            this.btnTelefonos.Name = "btnTelefonos";
            this.btnTelefonos.Size = new System.Drawing.Size(103, 31);
            this.btnTelefonos.TabIndex = 5;
            this.btnTelefonos.Text = "Teléfonos";
            this.btnTelefonos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnTelefonos, "Administrar teléfonos del cliente");
            this.btnTelefonos.UseVisualStyleBackColor = true;
            this.btnTelefonos.Click += new System.EventHandler(this.btnTelefonos_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContactos.BackgroundImage")));
            this.btnContactos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnContactos.Enabled = false;
            this.btnContactos.Location = new System.Drawing.Point(575, 202);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(103, 31);
            this.btnContactos.TabIndex = 6;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnContactos, "Administrar contactos del cliente");
            this.btnContactos.UseVisualStyleBackColor = true;
            this.btnContactos.Click += new System.EventHandler(this.btnContactos_Click);
            // 
            // btnTransportistas
            // 
            this.btnTransportistas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTransportistas.BackgroundImage")));
            this.btnTransportistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTransportistas.Enabled = false;
            this.btnTransportistas.Location = new System.Drawing.Point(575, 243);
            this.btnTransportistas.Name = "btnTransportistas";
            this.btnTransportistas.Size = new System.Drawing.Size(103, 31);
            this.btnTransportistas.TabIndex = 7;
            this.btnTransportistas.Text = "Transportistas";
            this.btnTransportistas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipClientes.SetToolTip(this.btnTransportistas, "Administrar transportistas del cliente");
            this.btnTransportistas.UseVisualStyleBackColor = true;
            this.btnTransportistas.Click += new System.EventHandler(this.btnTransportistas_Click);
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(12, 120);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(557, 279);
            this.grdClientes.TabIndex = 0;
            this.toolTipClientes.SetToolTip(this.grdClientes, "Lista de Clientes");
            this.grdClientes.Sorted += new System.EventHandler(this.grdClientes_Sorted);
            this.grdClientes.SelectionChanged += new System.EventHandler(this.grdClientes_SelectionChanged);
            this.grdClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClientes_CellContentClick);
            // 
            // gbxCriteriosBusqueda
            // 
            this.gbxCriteriosBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gbxCriteriosBusqueda.Controls.Add(this.btnLimpiar);
            this.gbxCriteriosBusqueda.Controls.Add(this.txtValorBusqueda);
            this.gbxCriteriosBusqueda.Controls.Add(this.btnBuscar);
            this.gbxCriteriosBusqueda.Controls.Add(this.lblValorBusqueda);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCodPostal);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnLocalidad);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCondIva);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCuit);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnCodigoCliente);
            this.gbxCriteriosBusqueda.Controls.Add(this.rbtnNombreRazonSocial);
            this.gbxCriteriosBusqueda.Location = new System.Drawing.Point(12, 12);
            this.gbxCriteriosBusqueda.Name = "gbxCriteriosBusqueda";
            this.gbxCriteriosBusqueda.Size = new System.Drawing.Size(666, 93);
            this.gbxCriteriosBusqueda.TabIndex = 9;
            this.gbxCriteriosBusqueda.TabStop = false;
            this.gbxCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiar.Location = new System.Drawing.Point(563, 52);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(471, 26);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(167, 20);
            this.txtValorBusqueda.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(471, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 28);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "    Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblValorBusqueda
            // 
            this.lblValorBusqueda.AutoSize = true;
            this.lblValorBusqueda.Location = new System.Drawing.Point(387, 29);
            this.lblValorBusqueda.Name = "lblValorBusqueda";
            this.lblValorBusqueda.Size = new System.Drawing.Size(78, 13);
            this.lblValorBusqueda.TabIndex = 6;
            this.lblValorBusqueda.Text = "Valor a buscar:";
            // 
            // rbtnCodPostal
            // 
            this.rbtnCodPostal.AutoSize = true;
            this.rbtnCodPostal.Location = new System.Drawing.Point(193, 65);
            this.rbtnCodPostal.Name = "rbtnCodPostal";
            this.rbtnCodPostal.Size = new System.Drawing.Size(79, 17);
            this.rbtnCodPostal.TabIndex = 5;
            this.rbtnCodPostal.Text = "Cod. Postal";
            this.rbtnCodPostal.UseVisualStyleBackColor = true;
            // 
            // rbtnLocalidad
            // 
            this.rbtnLocalidad.AutoSize = true;
            this.rbtnLocalidad.Location = new System.Drawing.Point(193, 42);
            this.rbtnLocalidad.Name = "rbtnLocalidad";
            this.rbtnLocalidad.Size = new System.Drawing.Size(71, 17);
            this.rbtnLocalidad.TabIndex = 4;
            this.rbtnLocalidad.Text = "Localidad";
            this.rbtnLocalidad.UseVisualStyleBackColor = true;
            // 
            // rbtnCondIva
            // 
            this.rbtnCondIva.AutoSize = true;
            this.rbtnCondIva.Location = new System.Drawing.Point(193, 19);
            this.rbtnCondIva.Name = "rbtnCondIva";
            this.rbtnCondIva.Size = new System.Drawing.Size(73, 17);
            this.rbtnCondIva.TabIndex = 3;
            this.rbtnCondIva.Text = "Cond. IVA";
            this.rbtnCondIva.UseVisualStyleBackColor = true;
            // 
            // rbtnCuit
            // 
            this.rbtnCuit.AutoSize = true;
            this.rbtnCuit.Location = new System.Drawing.Point(26, 65);
            this.rbtnCuit.Name = "rbtnCuit";
            this.rbtnCuit.Size = new System.Drawing.Size(50, 17);
            this.rbtnCuit.TabIndex = 2;
            this.rbtnCuit.Text = "CUIT";
            this.rbtnCuit.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigoCliente
            // 
            this.rbtnCodigoCliente.AutoSize = true;
            this.rbtnCodigoCliente.Location = new System.Drawing.Point(26, 19);
            this.rbtnCodigoCliente.Name = "rbtnCodigoCliente";
            this.rbtnCodigoCliente.Size = new System.Drawing.Size(108, 17);
            this.rbtnCodigoCliente.TabIndex = 1;
            this.rbtnCodigoCliente.Text = "Código de Cliente";
            this.rbtnCodigoCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnNombreRazonSocial
            // 
            this.rbtnNombreRazonSocial.AutoSize = true;
            this.rbtnNombreRazonSocial.Checked = true;
            this.rbtnNombreRazonSocial.Location = new System.Drawing.Point(26, 42);
            this.rbtnNombreRazonSocial.Name = "rbtnNombreRazonSocial";
            this.rbtnNombreRazonSocial.Size = new System.Drawing.Size(137, 17);
            this.rbtnNombreRazonSocial.TabIndex = 0;
            this.rbtnNombreRazonSocial.TabStop = true;
            this.rbtnNombreRazonSocial.Text = "Nombre o Razón Social";
            this.rbtnNombreRazonSocial.UseVisualStyleBackColor = true;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(690, 454);
            this.Controls.Add(this.gbxCriteriosBusqueda);
            this.Controls.Add(this.btnTransportistas);
            this.Controls.Add(this.btnContactos);
            this.Controls.Add(this.btnTelefonos);
            this.Controls.Add(this.btnDomicilios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.grdClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.Text = "Administrador de Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.gbxCriteriosBusqueda.ResumeLayout(false);
            this.gbxCriteriosBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDomicilios;
        private System.Windows.Forms.Button btnTelefonos;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Button btnTransportistas;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.ToolTip toolTipClientes;
        private System.Windows.Forms.GroupBox gbxCriteriosBusqueda;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblValorBusqueda;
        private System.Windows.Forms.RadioButton rbtnCodPostal;
        private System.Windows.Forms.RadioButton rbtnLocalidad;
        private System.Windows.Forms.RadioButton rbtnCondIva;
        private System.Windows.Forms.RadioButton rbtnCuit;
        private System.Windows.Forms.RadioButton rbtnCodigoCliente;
        private System.Windows.Forms.RadioButton rbtnNombreRazonSocial;
        private System.Windows.Forms.Button btnLimpiar;
    }
}