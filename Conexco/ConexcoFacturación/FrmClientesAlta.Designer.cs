namespace ConexcoFacturación
{
    partial class FrmClientesAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesAlta));
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblCondIva = new System.Windows.Forms.Label();
            this.lblPagos = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblWeb = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtPagos = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gbxDatosFiscales = new System.Windows.Forms.GroupBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.cmbCondicionIva = new System.Windows.Forms.ComboBox();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxOpcionales = new System.Windows.Forms.GroupBox();
            this.toolTipClientes = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxDatosFiscales.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxOpcionales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(9, 22);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(75, 13);
            this.lblCodCliente.TabIndex = 0;
            this.lblCodCliente.Text = "Código Cliente";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(14, 53);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 1;
            this.lblRazonSocial.Text = "Razon Social";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(289, 19);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(289, 51);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(52, 84);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 4;
            this.lblCuit.Text = "CUIT";
            // 
            // lblCondIva
            // 
            this.lblCondIva.AutoSize = true;
            this.lblCondIva.Location = new System.Drawing.Point(29, 113);
            this.lblCondIva.Name = "lblCondIva";
            this.lblCondIva.Size = new System.Drawing.Size(55, 13);
            this.lblCondIva.TabIndex = 5;
            this.lblCondIva.Text = "Cond. IVA";
            // 
            // lblPagos
            // 
            this.lblPagos.AutoSize = true;
            this.lblPagos.Location = new System.Drawing.Point(13, 75);
            this.lblPagos.Name = "lblPagos";
            this.lblPagos.Size = new System.Drawing.Size(37, 13);
            this.lblPagos.TabIndex = 6;
            this.lblPagos.Text = "Pagos";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(13, 23);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(13, 49);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(30, 13);
            this.lblWeb.TabIndex = 8;
            this.lblWeb.Text = "Web";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(98, 19);
            this.txtCodCliente.MaxLength = 10;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCodCliente.TabIndex = 0;
            this.toolTipClientes.SetToolTip(this.txtCodCliente, "Ingrese un Código que lo ayude a identificar el cliente");
            this.txtCodCliente.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(98, 49);
            this.txtRazonSocial.MaxLength = 250;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(150, 20);
            this.txtRazonSocial.TabIndex = 1;
            this.toolTipClientes.SetToolTip(this.txtRazonSocial, "Razón Social, este nombre aparecerá en los documentos");
            this.txtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(346, 17);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 4;
            this.toolTipClientes.SetToolTip(this.txtNombre, "Nombre del cliente");
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(346, 49);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(150, 20);
            this.txtApellido.TabIndex = 5;
            this.toolTipClientes.SetToolTip(this.txtApellido, "Apellido del cliente");
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtPagos
            // 
            this.txtPagos.Location = new System.Drawing.Point(16, 91);
            this.txtPagos.Multiline = true;
            this.txtPagos.Name = "txtPagos";
            this.txtPagos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPagos.Size = new System.Drawing.Size(219, 89);
            this.txtPagos.TabIndex = 2;
            this.toolTipClientes.SetToolTip(this.txtPagos, "Información relacionada a los pagos (Dias de pago, horarios, teléfonos, etc)");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(56, 20);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 0;
            this.toolTipClientes.SetToolTip(this.txtEmail, "Correo electrónico, opcional");
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(56, 49);
            this.txtWeb.MaxLength = 50;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(100, 20);
            this.txtWeb.TabIndex = 1;
            this.toolTipClientes.SetToolTip(this.txtWeb, "Sitio web, opcional");
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(24, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 31);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "       Guardar";
            this.toolTipClientes.SetToolTip(this.btnGuardar, "Guardar la información del Cliente");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(346, 113);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(86, 20);
            this.txtFax.TabIndex = 7;
            this.toolTipClientes.SetToolTip(this.txtFax, "Fax del cliente, opcional");
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(309, 117);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 50;
            this.lblFax.Text = "Fax";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(346, 81);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(86, 20);
            this.txtTelefono.TabIndex = 6;
            this.toolTipClientes.SetToolTip(this.txtTelefono, "Teléfono del cliente");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(284, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 48;
            this.lblTelefono.Text = "Telefono";
            // 
            // gbxDatosFiscales
            // 
            this.gbxDatosFiscales.BackColor = System.Drawing.Color.Transparent;
            this.gbxDatosFiscales.Controls.Add(this.txtCuit);
            this.gbxDatosFiscales.Controls.Add(this.txtFax);
            this.gbxDatosFiscales.Controls.Add(this.cmbCondicionIva);
            this.gbxDatosFiscales.Controls.Add(this.lblFax);
            this.gbxDatosFiscales.Controls.Add(this.lblCodCliente);
            this.gbxDatosFiscales.Controls.Add(this.txtTelefono);
            this.gbxDatosFiscales.Controls.Add(this.lblRazonSocial);
            this.gbxDatosFiscales.Controls.Add(this.lblTelefono);
            this.gbxDatosFiscales.Controls.Add(this.lblCuit);
            this.gbxDatosFiscales.Controls.Add(this.lblNombre);
            this.gbxDatosFiscales.Controls.Add(this.lblApellido);
            this.gbxDatosFiscales.Controls.Add(this.lblCondIva);
            this.gbxDatosFiscales.Controls.Add(this.txtCodCliente);
            this.gbxDatosFiscales.Controls.Add(this.txtNombre);
            this.gbxDatosFiscales.Controls.Add(this.txtRazonSocial);
            this.gbxDatosFiscales.Controls.Add(this.txtApellido);
            this.gbxDatosFiscales.Location = new System.Drawing.Point(12, 19);
            this.gbxDatosFiscales.Name = "gbxDatosFiscales";
            this.gbxDatosFiscales.Size = new System.Drawing.Size(514, 149);
            this.gbxDatosFiscales.TabIndex = 0;
            this.gbxDatosFiscales.TabStop = false;
            this.gbxDatosFiscales.Text = "Datos del cliente";
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(98, 81);
            this.txtCuit.MaxLength = 20;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 2;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // cmbCondicionIva
            // 
            this.cmbCondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIva.FormattingEnabled = true;
            this.cmbCondicionIva.Location = new System.Drawing.Point(98, 109);
            this.cmbCondicionIva.Name = "cmbCondicionIva";
            this.cmbCondicionIva.Size = new System.Drawing.Size(150, 21);
            this.cmbCondicionIva.TabIndex = 3;
            this.toolTipClientes.SetToolTip(this.cmbCondicionIva, "Condición ante el IVA");
            this.cmbCondicionIva.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.gbxDomicilio.Controls.Add(this.btnLocalidad);
            this.gbxDomicilio.Controls.Add(this.cmbProvincia);
            this.gbxDomicilio.Controls.Add(this.lblDomicilio);
            this.gbxDomicilio.Controls.Add(this.txtDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblLocalidad);
            this.gbxDomicilio.Controls.Add(this.txtLocalidad);
            this.gbxDomicilio.Controls.Add(this.lblProvincia);
            this.gbxDomicilio.Controls.Add(this.txtCodPostal);
            this.gbxDomicilio.Controls.Add(this.lblCodPostal);
            this.gbxDomicilio.Location = new System.Drawing.Point(12, 180);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(248, 132);
            this.gbxDomicilio.TabIndex = 1;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio Principal";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(205, 44);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 2;
            this.btnLocalidad.Text = "...";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(97, 44);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(100, 21);
            this.cmbProvincia.TabIndex = 1;
            this.cmbProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(32, 23);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 26;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(97, 19);
            this.txtDomicilio.MaxLength = 250;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(133, 20);
            this.txtDomicilio.TabIndex = 0;
            this.toolTipClientes.SetToolTip(this.txtDomicilio, "Domicilio principal del cliente");
            this.txtDomicilio.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(28, 75);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 41;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(97, 69);
            this.txtLocalidad.MaxLength = 100;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 3;
            this.txtLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(30, 48);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 43;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(97, 97);
            this.txtCodPostal.MaxLength = 10;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 4;
            this.txtCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(9, 102);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 45;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(154, 341);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "       Cancelar";
            this.toolTipClientes.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gbxOpcionales
            // 
            this.gbxOpcionales.BackColor = System.Drawing.Color.Transparent;
            this.gbxOpcionales.Controls.Add(this.lblPagos);
            this.gbxOpcionales.Controls.Add(this.txtPagos);
            this.gbxOpcionales.Controls.Add(this.lblEmail);
            this.gbxOpcionales.Controls.Add(this.txtEmail);
            this.gbxOpcionales.Controls.Add(this.lblWeb);
            this.gbxOpcionales.Controls.Add(this.txtWeb);
            this.gbxOpcionales.Location = new System.Drawing.Point(273, 180);
            this.gbxOpcionales.Name = "gbxOpcionales";
            this.gbxOpcionales.Size = new System.Drawing.Size(253, 193);
            this.gbxOpcionales.TabIndex = 2;
            this.gbxOpcionales.TabStop = false;
            this.gbxOpcionales.Text = "Información Adicional";
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmClientesAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(537, 388);
            this.Controls.Add(this.gbxOpcionales);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxDomicilio);
            this.Controls.Add(this.gbxDatosFiscales);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientesAlta";
            this.Text = "Alta de Clientes";
            this.Load += new System.EventHandler(this.FrmClienteAlta_Load);
            this.gbxDatosFiscales.ResumeLayout(false);
            this.gbxDatosFiscales.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxOpcionales.ResumeLayout(false);
            this.gbxOpcionales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblCondIva;
        private System.Windows.Forms.Label lblPagos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtPagos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxDatosFiscales;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbCondicionIva;
        private System.Windows.Forms.GroupBox gbxOpcionales;
        private System.Windows.Forms.ToolTip toolTipClientes;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
        private System.Windows.Forms.TextBox txtCuit;
    }
}

