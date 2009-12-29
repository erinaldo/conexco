namespace ConexcoFacturación
{
    partial class FrmEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmpresa));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblCondIva = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblInicioActividades = new System.Windows.Forms.Label();
            this.txtIngresosBrutos = new System.Windows.Forms.TextBox();
            this.lblIngresosBrutos = new System.Windows.Forms.Label();
            this.gbxDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dtpInicioActividades = new System.Windows.Forms.DateTimePicker();
            this.cmbCondicionIva = new System.Windows.Forms.ComboBox();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblPorciento = new System.Windows.Forms.Label();
            this.txtPorcentajeIVA = new System.Windows.Forms.TextBox();
            this.lblPorcentajeIVA = new System.Windows.Forms.Label();
            this.gbxConfiguracion = new System.Windows.Forms.GroupBox();
            this.lblRepetirContrasenia = new System.Windows.Forms.Label();
            this.txtRepetirContrasenia = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.toolTipEmpresa = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxDatosPersonales.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(382, 432);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(181, 432);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(79, 30);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipEmpresa.SetToolTip(this.btnGuardar, "Guardar cambios");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(461, 148);
            this.txtWeb.MaxLength = 50;
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(134, 20);
            this.txtWeb.TabIndex = 10;
            this.toolTipEmpresa.SetToolTip(this.txtWeb, "Sitio Web de su Empresa, opcional");
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(96, 173);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 5;
            this.toolTipEmpresa.SetToolTip(this.txtEmail, "E-Mail de su Empresa, opcional");
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.Color.Azure;
            this.txtDomicilio.Location = new System.Drawing.Point(97, 19);
            this.txtDomicilio.MaxLength = 250;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(191, 20);
            this.txtDomicilio.TabIndex = 0;
            this.toolTipEmpresa.SetToolTip(this.txtDomicilio, "Domicilio de su Empresa");
            this.txtDomicilio.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.Color.Azure;
            this.txtCuit.Location = new System.Drawing.Point(461, 23);
            this.txtCuit.MaxLength = 13;
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(134, 20);
            this.txtCuit.TabIndex = 6;
            this.toolTipEmpresa.SetToolTip(this.txtCuit, "CUIT de su Empresa");
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Azure;
            this.txtApellido.Location = new System.Drawing.Point(96, 83);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(147, 20);
            this.txtApellido.TabIndex = 2;
            this.toolTipEmpresa.SetToolTip(this.txtApellido, "Apellido del Responsable");
            this.txtApellido.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Azure;
            this.txtNombre.Location = new System.Drawing.Point(96, 53);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(147, 20);
            this.txtNombre.TabIndex = 1;
            this.toolTipEmpresa.SetToolTip(this.txtNombre, "Nombre del Responsable");
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.Azure;
            this.txtRazonSocial.Location = new System.Drawing.Point(96, 23);
            this.txtRazonSocial.MaxLength = 250;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(251, 20);
            this.txtRazonSocial.TabIndex = 0;
            this.toolTipEmpresa.SetToolTip(this.txtRazonSocial, "Razón Social de su Empresa");
            this.txtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblWeb
            // 
            this.lblWeb.AutoSize = true;
            this.lblWeb.Location = new System.Drawing.Point(415, 152);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(30, 13);
            this.lblWeb.TabIndex = 28;
            this.lblWeb.Text = "Web";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(53, 178);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(32, 26);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 26;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblCondIva
            // 
            this.lblCondIva.AutoSize = true;
            this.lblCondIva.Location = new System.Drawing.Point(391, 57);
            this.lblCondIva.Name = "lblCondIva";
            this.lblCondIva.Size = new System.Drawing.Size(55, 13);
            this.lblCondIva.TabIndex = 25;
            this.lblCondIva.Text = "Cond. IVA";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(416, 26);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(32, 13);
            this.lblCuit.TabIndex = 24;
            this.lblCuit.Text = "CUIT";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(41, 87);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 23;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(41, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 22;
            this.lblNombre.Text = "Nombre";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(15, 26);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(70, 13);
            this.lblRazonSocial.TabIndex = 21;
            this.lblRazonSocial.Text = "Razón Social";
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(350, 33);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Complete la información de su empresa. Recuerde que esta información se utilizará" +
                " para los documentos como Facturas, Remitos, etc.";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.Azure;
            this.txtLocalidad.Location = new System.Drawing.Point(97, 70);
            this.txtLocalidad.MaxLength = 100;
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(164, 20);
            this.txtLocalidad.TabIndex = 3;
            this.toolTipEmpresa.SetToolTip(this.txtLocalidad, "Ingrese la Localidad de su Empresa o utilize el buscador para completarla automát" +
                    "icamente");
            this.txtLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(28, 76);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 41;
            this.lblLocalidad.Text = "Localidad";
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
            this.txtCodPostal.BackColor = System.Drawing.Color.Azure;
            this.txtCodPostal.Location = new System.Drawing.Point(97, 97);
            this.txtCodPostal.MaxLength = 10;
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 4;
            this.toolTipEmpresa.SetToolTip(this.txtCodPostal, "Código Postal de su Empresa");
            this.txtCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(9, 104);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 45;
            this.lblCodPostal.Text = "Código Postal";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Azure;
            this.txtTelefono.Location = new System.Drawing.Point(96, 113);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 3;
            this.toolTipEmpresa.SetToolTip(this.txtTelefono, "Teléfono de su Empresa");
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(36, 118);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 47;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(96, 143);
            this.txtFax.MaxLength = 20;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(100, 20);
            this.txtFax.TabIndex = 4;
            this.toolTipEmpresa.SetToolTip(this.txtFax, "Fax de su Empresa, opcional");
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(61, 145);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(24, 13);
            this.lblFax.TabIndex = 49;
            this.lblFax.Text = "Fax";
            // 
            // lblInicioActividades
            // 
            this.lblInicioActividades.AutoSize = true;
            this.lblInicioActividades.Location = new System.Drawing.Point(341, 93);
            this.lblInicioActividades.Name = "lblInicioActividades";
            this.lblInicioActividades.Size = new System.Drawing.Size(105, 13);
            this.lblInicioActividades.TabIndex = 51;
            this.lblInicioActividades.Text = "Inicio de Actividades";
            // 
            // txtIngresosBrutos
            // 
            this.txtIngresosBrutos.BackColor = System.Drawing.Color.Azure;
            this.txtIngresosBrutos.Location = new System.Drawing.Point(461, 117);
            this.txtIngresosBrutos.MaxLength = 50;
            this.txtIngresosBrutos.Name = "txtIngresosBrutos";
            this.txtIngresosBrutos.Size = new System.Drawing.Size(100, 20);
            this.txtIngresosBrutos.TabIndex = 9;
            this.toolTipEmpresa.SetToolTip(this.txtIngresosBrutos, "Ingresos Brutos de su Empresa");
            this.txtIngresosBrutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosYGuion_KeyPress);
            this.txtIngresosBrutos.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblIngresosBrutos
            // 
            this.lblIngresosBrutos.AutoSize = true;
            this.lblIngresosBrutos.Location = new System.Drawing.Point(366, 120);
            this.lblIngresosBrutos.Name = "lblIngresosBrutos";
            this.lblIngresosBrutos.Size = new System.Drawing.Size(80, 13);
            this.lblIngresosBrutos.TabIndex = 53;
            this.lblIngresosBrutos.Text = "Ingresos Brutos";
            // 
            // gbxDatosPersonales
            // 
            this.gbxDatosPersonales.BackColor = System.Drawing.Color.Transparent;
            this.gbxDatosPersonales.Controls.Add(this.dtpInicioActividades);
            this.gbxDatosPersonales.Controls.Add(this.lblRazonSocial);
            this.gbxDatosPersonales.Controls.Add(this.cmbCondicionIva);
            this.gbxDatosPersonales.Controls.Add(this.lblNombre);
            this.gbxDatosPersonales.Controls.Add(this.lblCuit);
            this.gbxDatosPersonales.Controls.Add(this.lblCondIva);
            this.gbxDatosPersonales.Controls.Add(this.lblApellido);
            this.gbxDatosPersonales.Controls.Add(this.txtIngresosBrutos);
            this.gbxDatosPersonales.Controls.Add(this.txtRazonSocial);
            this.gbxDatosPersonales.Controls.Add(this.txtCuit);
            this.gbxDatosPersonales.Controls.Add(this.txtFax);
            this.gbxDatosPersonales.Controls.Add(this.lblIngresosBrutos);
            this.gbxDatosPersonales.Controls.Add(this.lblFax);
            this.gbxDatosPersonales.Controls.Add(this.lblInicioActividades);
            this.gbxDatosPersonales.Controls.Add(this.txtNombre);
            this.gbxDatosPersonales.Controls.Add(this.txtApellido);
            this.gbxDatosPersonales.Controls.Add(this.txtTelefono);
            this.gbxDatosPersonales.Controls.Add(this.lblTelefono);
            this.gbxDatosPersonales.Controls.Add(this.lblEmail);
            this.gbxDatosPersonales.Controls.Add(this.lblWeb);
            this.gbxDatosPersonales.Controls.Add(this.txtEmail);
            this.gbxDatosPersonales.Controls.Add(this.txtWeb);
            this.gbxDatosPersonales.Location = new System.Drawing.Point(15, 51);
            this.gbxDatosPersonales.Name = "gbxDatosPersonales";
            this.gbxDatosPersonales.Size = new System.Drawing.Size(613, 213);
            this.gbxDatosPersonales.TabIndex = 0;
            this.gbxDatosPersonales.TabStop = false;
            this.gbxDatosPersonales.Text = "Información de su Empresa";
            // 
            // dtpInicioActividades
            // 
            this.dtpInicioActividades.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpInicioActividades.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dtpInicioActividades.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioActividades.Location = new System.Drawing.Point(461, 86);
            this.dtpInicioActividades.Name = "dtpInicioActividades";
            this.dtpInicioActividades.Size = new System.Drawing.Size(100, 20);
            this.dtpInicioActividades.TabIndex = 8;
            this.toolTipEmpresa.SetToolTip(this.dtpInicioActividades, "Inicio de Actividades de su Empresa");
            this.dtpInicioActividades.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // cmbCondicionIva
            // 
            this.cmbCondicionIva.BackColor = System.Drawing.Color.Azure;
            this.cmbCondicionIva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIva.FormattingEnabled = true;
            this.cmbCondicionIva.Location = new System.Drawing.Point(461, 54);
            this.cmbCondicionIva.Name = "cmbCondicionIva";
            this.cmbCondicionIva.Size = new System.Drawing.Size(134, 21);
            this.cmbCondicionIva.TabIndex = 7;
            this.toolTipEmpresa.SetToolTip(this.cmbCondicionIva, "Condición ante el IVA de su Empresa");
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
            this.gbxDomicilio.Location = new System.Drawing.Point(322, 280);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(306, 142);
            this.gbxDomicilio.TabIndex = 1;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalidad.Location = new System.Drawing.Point(236, 42);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 2;
            this.toolTipEmpresa.SetToolTip(this.btnLocalidad, "Buscador de Localidades");
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.BackColor = System.Drawing.Color.Azure;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(97, 44);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(133, 21);
            this.cmbProvincia.TabIndex = 1;
            this.toolTipEmpresa.SetToolTip(this.cmbProvincia, "Provincia de su Empresa");
            this.cmbProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblPorciento
            // 
            this.lblPorciento.AutoSize = true;
            this.lblPorciento.Location = new System.Drawing.Point(154, 27);
            this.lblPorciento.Name = "lblPorciento";
            this.lblPorciento.Size = new System.Drawing.Size(15, 13);
            this.lblPorciento.TabIndex = 58;
            this.lblPorciento.Text = "%";
            // 
            // txtPorcentajeIVA
            // 
            this.txtPorcentajeIVA.BackColor = System.Drawing.Color.Azure;
            this.txtPorcentajeIVA.Location = new System.Drawing.Point(113, 23);
            this.txtPorcentajeIVA.MaxLength = 3;
            this.txtPorcentajeIVA.Name = "txtPorcentajeIVA";
            this.txtPorcentajeIVA.Size = new System.Drawing.Size(38, 20);
            this.txtPorcentajeIVA.TabIndex = 0;
            this.toolTipEmpresa.SetToolTip(this.txtPorcentajeIVA, "Porcentaje de IVA que maneja en su Empresa (Ej. 21%)");
            this.txtPorcentajeIVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.txtPorcentajeIVA.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblPorcentajeIVA
            // 
            this.lblPorcentajeIVA.AutoSize = true;
            this.lblPorcentajeIVA.Location = new System.Drawing.Point(28, 26);
            this.lblPorcentajeIVA.Name = "lblPorcentajeIVA";
            this.lblPorcentajeIVA.Size = new System.Drawing.Size(78, 13);
            this.lblPorcentajeIVA.TabIndex = 56;
            this.lblPorcentajeIVA.Text = "Porcentaje IVA";
            // 
            // gbxConfiguracion
            // 
            this.gbxConfiguracion.BackColor = System.Drawing.Color.Transparent;
            this.gbxConfiguracion.Controls.Add(this.lblRepetirContrasenia);
            this.gbxConfiguracion.Controls.Add(this.txtRepetirContrasenia);
            this.gbxConfiguracion.Controls.Add(this.txtContrasenia);
            this.gbxConfiguracion.Controls.Add(this.lblContrasenia);
            this.gbxConfiguracion.Controls.Add(this.lblPorciento);
            this.gbxConfiguracion.Controls.Add(this.lblPorcentajeIVA);
            this.gbxConfiguracion.Controls.Add(this.txtPorcentajeIVA);
            this.gbxConfiguracion.Location = new System.Drawing.Point(15, 281);
            this.gbxConfiguracion.Name = "gbxConfiguracion";
            this.gbxConfiguracion.Size = new System.Drawing.Size(255, 116);
            this.gbxConfiguracion.TabIndex = 2;
            this.gbxConfiguracion.TabStop = false;
            this.gbxConfiguracion.Text = "Configuración del Sistema";
            // 
            // lblRepetirContrasenia
            // 
            this.lblRepetirContrasenia.AutoSize = true;
            this.lblRepetirContrasenia.Location = new System.Drawing.Point(8, 77);
            this.lblRepetirContrasenia.Name = "lblRepetirContrasenia";
            this.lblRepetirContrasenia.Size = new System.Drawing.Size(98, 13);
            this.lblRepetirContrasenia.TabIndex = 62;
            this.lblRepetirContrasenia.Text = "Repetir Contraseña";
            // 
            // txtRepetirContrasenia
            // 
            this.txtRepetirContrasenia.BackColor = System.Drawing.Color.Azure;
            this.txtRepetirContrasenia.Location = new System.Drawing.Point(113, 75);
            this.txtRepetirContrasenia.MaxLength = 20;
            this.txtRepetirContrasenia.Name = "txtRepetirContrasenia";
            this.txtRepetirContrasenia.PasswordChar = '*';
            this.txtRepetirContrasenia.Size = new System.Drawing.Size(130, 20);
            this.txtRepetirContrasenia.TabIndex = 2;
            this.toolTipEmpresa.SetToolTip(this.txtRepetirContrasenia, "Repita la contraseña");
            this.txtRepetirContrasenia.UseSystemPasswordChar = true;
            this.txtRepetirContrasenia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.BackColor = System.Drawing.Color.Azure;
            this.txtContrasenia.Location = new System.Drawing.Point(113, 49);
            this.txtContrasenia.MaxLength = 20;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(130, 20);
            this.txtContrasenia.TabIndex = 1;
            this.toolTipEmpresa.SetToolTip(this.txtContrasenia, "Contraseña para ingresar al Sistema");
            this.txtContrasenia.UseSystemPasswordChar = true;
            this.txtContrasenia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(45, 53);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(61, 13);
            this.lblContrasenia.TabIndex = 59;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(643, 475);
            this.Controls.Add(this.gbxConfiguracion);
            this.Controls.Add(this.gbxDomicilio);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxDatosPersonales);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmEmpresa";
            this.Text = "Datos de la Empresa";
            this.Load += new System.EventHandler(this.FrmEmpresa_Load);
            this.gbxDatosPersonales.ResumeLayout(false);
            this.gbxDatosPersonales.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxConfiguracion.ResumeLayout(false);
            this.gbxConfiguracion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblCondIva;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblInicioActividades;
        private System.Windows.Forms.TextBox txtIngresosBrutos;
        private System.Windows.Forms.Label lblIngresosBrutos;
        private System.Windows.Forms.GroupBox gbxDatosPersonales;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ComboBox cmbCondicionIva;
        private System.Windows.Forms.DateTimePicker dtpInicioActividades;
        private System.Windows.Forms.Label lblPorciento;
        private System.Windows.Forms.TextBox txtPorcentajeIVA;
        private System.Windows.Forms.Label lblPorcentajeIVA;
        private System.Windows.Forms.GroupBox gbxConfiguracion;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.Label lblRepetirContrasenia;
        private System.Windows.Forms.TextBox txtRepetirContrasenia;
        private System.Windows.Forms.ToolTip toolTipEmpresa;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;

    }
}