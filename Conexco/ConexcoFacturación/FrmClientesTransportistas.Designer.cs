namespace ConexcoFacturación
{
    partial class FrmClientesTransportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesTransportistas));
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxTransportista = new System.Windows.Forms.GroupBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtInfoAdicional = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gridTransportistas = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.toolTipTransportistas = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxTransportista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(122, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipTransportistas.SetToolTip(this.btnGuardar, "Guardar Cambios");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::ConexcoFacturación.Properties.Resources.salir3;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalir.Location = new System.Drawing.Point(464, 321);
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
            this.btnEliminar.Location = new System.Drawing.Point(362, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipTransportistas.SetToolTip(this.btnEliminar, "Eliminar Transportista seleccionado");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.modificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Location = new System.Drawing.Point(277, 321);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 30);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipTransportistas.SetToolTip(this.btnModificar, "Modificar Transportista seleccionado");
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackgroundImage = global::ConexcoFacturación.Properties.Resources.agregar;
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.Location = new System.Drawing.Point(202, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(70, 30);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipTransportistas.SetToolTip(this.btnNuevo, "Habilita los campos para un nuevo Transportista");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxTransportista
            // 
            this.gbxTransportista.BackColor = System.Drawing.Color.Transparent;
            this.gbxTransportista.Controls.Add(this.txtCuit);
            this.gbxTransportista.Controls.Add(this.lblCuit);
            this.gbxTransportista.Controls.Add(this.txtInfoAdicional);
            this.gbxTransportista.Controls.Add(this.txtTelefono);
            this.gbxTransportista.Controls.Add(this.txtNombre);
            this.gbxTransportista.Controls.Add(this.label3);
            this.gbxTransportista.Controls.Add(this.label2);
            this.gbxTransportista.Controls.Add(this.lblNombre);
            this.gbxTransportista.Controls.Add(this.btnLocalidad);
            this.gbxTransportista.Controls.Add(this.cmbProvincia);
            this.gbxTransportista.Controls.Add(this.lblDomicilio);
            this.gbxTransportista.Controls.Add(this.txtDomicilio);
            this.gbxTransportista.Controls.Add(this.lblLocalidad);
            this.gbxTransportista.Controls.Add(this.txtLocalidad);
            this.gbxTransportista.Controls.Add(this.lblProvincia);
            this.gbxTransportista.Controls.Add(this.txtCodPostal);
            this.gbxTransportista.Controls.Add(this.lblCodPostal);
            this.gbxTransportista.Enabled = false;
            this.gbxTransportista.Location = new System.Drawing.Point(12, 147);
            this.gbxTransportista.Name = "gbxTransportista";
            this.gbxTransportista.Size = new System.Drawing.Size(666, 158);
            this.gbxTransportista.TabIndex = 2;
            this.gbxTransportista.TabStop = false;
            this.gbxTransportista.Text = "Detalle";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(131, 49);
            this.txtCuit.MaxLength = 13;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 1;
            this.toolTipTransportistas.SetToolTip(this.txtCuit, "CUIT del Transportista");
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(93, 52);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 56;
            this.lblCuit.Text = "CUIT";
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Location = new System.Drawing.Point(13, 97);
            this.txtInfoAdicional.MaxLength = 250;
            this.txtInfoAdicional.Multiline = true;
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfoAdicional.Size = new System.Drawing.Size(332, 47);
            this.txtInfoAdicional.TabIndex = 8;
            this.toolTipTransportistas.SetToolTip(this.txtInfoAdicional, "Información adicional, opcional");
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(463, 124);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 7;
            this.toolTipTransportistas.SetToolTip(this.txtTelefono, "Teléfono del Transportista");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 23);
            this.txtNombre.MaxLength = 250;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 0;
            this.toolTipTransportistas.SetToolTip(this.txtNombre, "Razón Social del Transportista");
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Información Adicional";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(118, 13);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre / Razón Social";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalidad.Location = new System.Drawing.Point(600, 42);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 4;
            this.toolTipTransportistas.SetToolTip(this.btnLocalidad, "Buscador de Localidades");
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(463, 43);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(131, 21);
            this.cmbProvincia.TabIndex = 3;
            this.toolTipTransportistas.SetToolTip(this.cmbProvincia, "Provincia del Transportista");
            this.cmbProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(402, 23);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 26;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(463, 18);
            this.txtDomicilio.MaxLength = 250;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(197, 20);
            this.txtDomicilio.TabIndex = 2;
            this.toolTipTransportistas.SetToolTip(this.txtDomicilio, "Domicilio del Transportista");
            this.txtDomicilio.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(398, 72);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 41;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(463, 68);
            this.txtLocalidad.MaxLength = 100;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(162, 20);
            this.txtLocalidad.TabIndex = 5;
            this.toolTipTransportistas.SetToolTip(this.txtLocalidad, "Ingrese la Localidad del Transportista o utilize el buscador para completarla Aut" +
                    "omáticamente");
            this.txtLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(400, 46);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 43;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(463, 96);
            this.txtCodPostal.MaxLength = 10;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 6;
            this.toolTipTransportistas.SetToolTip(this.txtCodPostal, "Ingrese el Código Postal del Transportista o utilize el buscador para completarlo" +
                    " automáticamente");
            this.txtCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(379, 100);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 45;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Location = new System.Drawing.Point(140, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(120, 13);
            this.lblCliente.TabIndex = 25;
            this.lblCliente.Text = "NOMBRE DE CLIENTE";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(130, 13);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Transportistas del cliente: ";
            // 
            // gridTransportistas
            // 
            this.gridTransportistas.AllowUserToAddRows = false;
            this.gridTransportistas.AllowUserToDeleteRows = false;
            this.gridTransportistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTransportistas.Location = new System.Drawing.Point(12, 45);
            this.gridTransportistas.MultiSelect = false;
            this.gridTransportistas.Name = "gridTransportistas";
            this.gridTransportistas.ReadOnly = true;
            this.gridTransportistas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTransportistas.Size = new System.Drawing.Size(666, 96);
            this.gridTransportistas.TabIndex = 0;
            this.gridTransportistas.SelectionChanged += new System.EventHandler(this.gridTransportistas_SelectionChanged);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.aceptar;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSeleccionar.Location = new System.Drawing.Point(12, 321);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(99, 30);
            this.btnSeleccionar.TabIndex = 1;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipTransportistas.SetToolTip(this.btnSeleccionar, "Utilizar el Transportista seleccionado");
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmClientesTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(690, 364);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxTransportista);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridTransportistas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientesTransportistas";
            this.Text = "Transportistas del cliente";
            this.Load += new System.EventHandler(this.FrmClientesTransportistas_Load);
            this.gbxTransportista.ResumeLayout(false);
            this.gbxTransportista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportistas)).EndInit();
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
        private System.Windows.Forms.GroupBox gbxTransportista;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView gridTransportistas;
        private System.Windows.Forms.TextBox txtInfoAdicional;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.ToolTip toolTipTransportistas;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
    }
}