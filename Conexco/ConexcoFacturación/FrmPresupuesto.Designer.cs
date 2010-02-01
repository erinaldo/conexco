namespace ConexcoFacturación
{
    partial class FrmPresupuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuesto));
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.gbxEmpresa = new System.Windows.Forms.GroupBox();
            this.lblTEmpProvincia = new System.Windows.Forms.Label();
            this.lblTEmpPosicionIva = new System.Windows.Forms.Label();
            this.lblTEmpFax = new System.Windows.Forms.Label();
            this.lblTEmpTelefono = new System.Windows.Forms.Label();
            this.lblEmpPosicionIVA = new System.Windows.Forms.Label();
            this.lblEmpFax = new System.Windows.Forms.Label();
            this.lblEmpTel = new System.Windows.Forms.Label();
            this.lblEmpProvincia = new System.Windows.Forms.Label();
            this.lblEmpLocalidad = new System.Windows.Forms.Label();
            this.lblEmpCodPostal = new System.Windows.Forms.Label();
            this.lblEmpDomicilio = new System.Windows.Forms.Label();
            this.lblEmpRazonSocial = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.comboProvincia = new System.Windows.Forms.ComboBox();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilioEntrega = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTEmpCuit = new System.Windows.Forms.Label();
            this.lblEmpCuit = new System.Windows.Forms.Label();
            this.lblTEmpIngBrut = new System.Windows.Forms.Label();
            this.lblEmpIngBrutos = new System.Windows.Forms.Label();
            this.lblTInicioActividades = new System.Windows.Forms.Label();
            this.lblEmpInicioActividades = new System.Windows.Forms.Label();
            this.gbxFiscales = new System.Windows.Forms.GroupBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtClienteCod = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblClienteCod = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.grdDetallePresupuesto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.txtCondiciones = new System.Windows.Forms.TextBox();
            this.txtDisponibilidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarImprimir = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTNumFact = new System.Windows.Forms.Label();
            this.txtNumPresupuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPesos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxEmpresa.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxFiscales.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallePresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(575, 58);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(97, 20);
            this.dtpFechaEmision.TabIndex = 2;
            // 
            // gbxEmpresa
            // 
            this.gbxEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.gbxEmpresa.Controls.Add(this.lblTEmpProvincia);
            this.gbxEmpresa.Controls.Add(this.lblTEmpPosicionIva);
            this.gbxEmpresa.Controls.Add(this.lblTEmpFax);
            this.gbxEmpresa.Controls.Add(this.lblTEmpTelefono);
            this.gbxEmpresa.Controls.Add(this.lblEmpPosicionIVA);
            this.gbxEmpresa.Controls.Add(this.lblEmpFax);
            this.gbxEmpresa.Controls.Add(this.lblEmpTel);
            this.gbxEmpresa.Controls.Add(this.lblEmpProvincia);
            this.gbxEmpresa.Controls.Add(this.lblEmpLocalidad);
            this.gbxEmpresa.Controls.Add(this.lblEmpCodPostal);
            this.gbxEmpresa.Controls.Add(this.lblEmpDomicilio);
            this.gbxEmpresa.Controls.Add(this.lblEmpRazonSocial);
            this.gbxEmpresa.Location = new System.Drawing.Point(8, 46);
            this.gbxEmpresa.Name = "gbxEmpresa";
            this.gbxEmpresa.Size = new System.Drawing.Size(291, 111);
            this.gbxEmpresa.TabIndex = 3;
            this.gbxEmpresa.TabStop = false;
            this.gbxEmpresa.Text = "Empresa";
            this.toolTipControl.SetToolTip(this.gbxEmpresa, "Información de la empresa");
            // 
            // lblTEmpProvincia
            // 
            this.lblTEmpProvincia.AutoSize = true;
            this.lblTEmpProvincia.Location = new System.Drawing.Point(172, 52);
            this.lblTEmpProvincia.Name = "lblTEmpProvincia";
            this.lblTEmpProvincia.Size = new System.Drawing.Size(31, 13);
            this.lblTEmpProvincia.TabIndex = 11;
            this.lblTEmpProvincia.Text = "Pcia.";
            // 
            // lblTEmpPosicionIva
            // 
            this.lblTEmpPosicionIva.AutoSize = true;
            this.lblTEmpPosicionIva.Location = new System.Drawing.Point(16, 92);
            this.lblTEmpPosicionIva.Name = "lblTEmpPosicionIva";
            this.lblTEmpPosicionIva.Size = new System.Drawing.Size(33, 13);
            this.lblTEmpPosicionIva.TabIndex = 10;
            this.lblTEmpPosicionIva.Text = "I.V.A.";
            // 
            // lblTEmpFax
            // 
            this.lblTEmpFax.AutoSize = true;
            this.lblTEmpFax.Location = new System.Drawing.Point(172, 72);
            this.lblTEmpFax.Name = "lblTEmpFax";
            this.lblTEmpFax.Size = new System.Drawing.Size(27, 13);
            this.lblTEmpFax.TabIndex = 9;
            this.lblTEmpFax.Text = "Fax.";
            // 
            // lblTEmpTelefono
            // 
            this.lblTEmpTelefono.AutoSize = true;
            this.lblTEmpTelefono.Location = new System.Drawing.Point(16, 72);
            this.lblTEmpTelefono.Name = "lblTEmpTelefono";
            this.lblTEmpTelefono.Size = new System.Drawing.Size(25, 13);
            this.lblTEmpTelefono.TabIndex = 8;
            this.lblTEmpTelefono.Text = "Tel.";
            // 
            // lblEmpPosicionIVA
            // 
            this.lblEmpPosicionIVA.AutoSize = true;
            this.lblEmpPosicionIVA.Location = new System.Drawing.Point(54, 92);
            this.lblEmpPosicionIVA.Name = "lblEmpPosicionIVA";
            this.lblEmpPosicionIVA.Size = new System.Drawing.Size(78, 13);
            this.lblEmpPosicionIVA.TabIndex = 7;
            this.lblEmpPosicionIVA.Text = "POSICION IVA";
            // 
            // lblEmpFax
            // 
            this.lblEmpFax.AutoSize = true;
            this.lblEmpFax.Location = new System.Drawing.Point(203, 72);
            this.lblEmpFax.Name = "lblEmpFax";
            this.lblEmpFax.Size = new System.Drawing.Size(27, 13);
            this.lblEmpFax.TabIndex = 6;
            this.lblEmpFax.Text = "FAX";
            // 
            // lblEmpTel
            // 
            this.lblEmpTel.AutoSize = true;
            this.lblEmpTel.Location = new System.Drawing.Point(47, 72);
            this.lblEmpTel.Name = "lblEmpTel";
            this.lblEmpTel.Size = new System.Drawing.Size(64, 13);
            this.lblEmpTel.TabIndex = 5;
            this.lblEmpTel.Text = "TELEFONO";
            // 
            // lblEmpProvincia
            // 
            this.lblEmpProvincia.AutoSize = true;
            this.lblEmpProvincia.Location = new System.Drawing.Point(203, 52);
            this.lblEmpProvincia.Name = "lblEmpProvincia";
            this.lblEmpProvincia.Size = new System.Drawing.Size(65, 13);
            this.lblEmpProvincia.TabIndex = 4;
            this.lblEmpProvincia.Text = "PROVINCIA";
            // 
            // lblEmpLocalidad
            // 
            this.lblEmpLocalidad.AutoSize = true;
            this.lblEmpLocalidad.Location = new System.Drawing.Point(65, 53);
            this.lblEmpLocalidad.Name = "lblEmpLocalidad";
            this.lblEmpLocalidad.Size = new System.Drawing.Size(67, 13);
            this.lblEmpLocalidad.TabIndex = 3;
            this.lblEmpLocalidad.Text = "LOCALIDAD";
            // 
            // lblEmpCodPostal
            // 
            this.lblEmpCodPostal.AutoSize = true;
            this.lblEmpCodPostal.Location = new System.Drawing.Point(16, 52);
            this.lblEmpCodPostal.Name = "lblEmpCodPostal";
            this.lblEmpCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblEmpCodPostal.TabIndex = 2;
            this.lblEmpCodPostal.Text = "(CP)";
            // 
            // lblEmpDomicilio
            // 
            this.lblEmpDomicilio.AutoSize = true;
            this.lblEmpDomicilio.Location = new System.Drawing.Point(16, 35);
            this.lblEmpDomicilio.Name = "lblEmpDomicilio";
            this.lblEmpDomicilio.Size = new System.Drawing.Size(62, 13);
            this.lblEmpDomicilio.TabIndex = 1;
            this.lblEmpDomicilio.Text = "DOMICILIO";
            // 
            // lblEmpRazonSocial
            // 
            this.lblEmpRazonSocial.AutoSize = true;
            this.lblEmpRazonSocial.Location = new System.Drawing.Point(16, 16);
            this.lblEmpRazonSocial.Name = "lblEmpRazonSocial";
            this.lblEmpRazonSocial.Size = new System.Drawing.Size(86, 13);
            this.lblEmpRazonSocial.TabIndex = 0;
            this.lblEmpRazonSocial.Text = "RAZON SOCIAL";
            // 
            // gbxCliente
            // 
            this.gbxCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbxCliente.Controls.Add(this.btnLocalidad);
            this.gbxCliente.Controls.Add(this.comboProvincia);
            this.gbxCliente.Controls.Add(this.cmbRazonSocial);
            this.gbxCliente.Controls.Add(this.btnClientes);
            this.gbxCliente.Controls.Add(this.txtCodPostal);
            this.gbxCliente.Controls.Add(this.txtLocalidad);
            this.gbxCliente.Controls.Add(this.txtDomicilioEntrega);
            this.gbxCliente.Controls.Add(this.lblProvincia);
            this.gbxCliente.Controls.Add(this.lblCodPostal);
            this.gbxCliente.Controls.Add(this.lblLocalidad);
            this.gbxCliente.Controls.Add(this.lblDomicilio);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Location = new System.Drawing.Point(8, 166);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(672, 92);
            this.gbxCliente.TabIndex = 3;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalidad.Location = new System.Drawing.Point(297, 66);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 28;
            this.toolTipControl.SetToolTip(this.btnLocalidad, "Buscador de Localidades");
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // comboProvincia
            // 
            this.comboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincia.FormattingEnabled = true;
            this.comboProvincia.Location = new System.Drawing.Point(538, 64);
            this.comboProvincia.Name = "comboProvincia";
            this.comboProvincia.Size = new System.Drawing.Size(121, 21);
            this.comboProvincia.TabIndex = 27;
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.BackColor = System.Drawing.Color.Azure;
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(76, 12);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(272, 21);
            this.cmbRazonSocial.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.cmbRazonSocial, "Seleccione un cliente o utilice el buscador");
            this.cmbRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cmbRazonSocial_SelectedIndexChanged);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClientes.Location = new System.Drawing.Point(360, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(32, 23);
            this.btnClientes.TabIndex = 1;
            this.toolTipControl.SetToolTip(this.btnClientes, "Buscador de Clientes");
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.BackColor = System.Drawing.Color.White;
            this.txtCodPostal.Location = new System.Drawing.Point(396, 66);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(75, 20);
            this.txtCodPostal.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.Color.White;
            this.txtLocalidad.Location = new System.Drawing.Point(76, 67);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(215, 20);
            this.txtLocalidad.TabIndex = 4;
            // 
            // txtDomicilioEntrega
            // 
            this.txtDomicilioEntrega.BackColor = System.Drawing.Color.White;
            this.txtDomicilioEntrega.Location = new System.Drawing.Point(76, 39);
            this.txtDomicilioEntrega.Name = "txtDomicilioEntrega";
            this.txtDomicilioEntrega.Size = new System.Drawing.Size(215, 20);
            this.txtDomicilioEntrega.TabIndex = 3;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(479, 69);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 16;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(328, 71);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodPostal.TabIndex = 15;
            this.lblCodPostal.Text = "Cod. Postal:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 65);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(13, 39);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lblDomicilio.TabIndex = 13;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(16, 15);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(49, 13);
            this.lblRazonSocial.TabIndex = 12;
            this.lblRazonSocial.Text = "Señores:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(521, 64);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTEmpCuit
            // 
            this.lblTEmpCuit.AutoSize = true;
            this.lblTEmpCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblTEmpCuit.Location = new System.Drawing.Point(521, 91);
            this.lblTEmpCuit.Name = "lblTEmpCuit";
            this.lblTEmpCuit.Size = new System.Drawing.Size(35, 13);
            this.lblTEmpCuit.TabIndex = 6;
            this.lblTEmpCuit.Text = "CUIT:";
            // 
            // lblEmpCuit
            // 
            this.lblEmpCuit.AutoSize = true;
            this.lblEmpCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpCuit.Location = new System.Drawing.Point(562, 91);
            this.lblEmpCuit.Name = "lblEmpCuit";
            this.lblEmpCuit.Size = new System.Drawing.Size(83, 13);
            this.lblEmpCuit.TabIndex = 7;
            this.lblEmpCuit.Text = "NUMERO CUIT";
            // 
            // lblTEmpIngBrut
            // 
            this.lblTEmpIngBrut.AutoSize = true;
            this.lblTEmpIngBrut.BackColor = System.Drawing.Color.Transparent;
            this.lblTEmpIngBrut.Location = new System.Drawing.Point(431, 116);
            this.lblTEmpIngBrut.Name = "lblTEmpIngBrut";
            this.lblTEmpIngBrut.Size = new System.Drawing.Size(127, 13);
            this.lblTEmpIngBrut.TabIndex = 8;
            this.lblTEmpIngBrut.Text = "Ing. Brutos Conv. Mult.N°";
            // 
            // lblEmpIngBrutos
            // 
            this.lblEmpIngBrutos.AutoSize = true;
            this.lblEmpIngBrutos.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpIngBrutos.Location = new System.Drawing.Point(562, 116);
            this.lblEmpIngBrutos.Name = "lblEmpIngBrutos";
            this.lblEmpIngBrutos.Size = new System.Drawing.Size(110, 13);
            this.lblEmpIngBrutos.TabIndex = 9;
            this.lblEmpIngBrutos.Text = "NUMERO ING BRUT";
            // 
            // lblTInicioActividades
            // 
            this.lblTInicioActividades.AutoSize = true;
            this.lblTInicioActividades.BackColor = System.Drawing.Color.Transparent;
            this.lblTInicioActividades.Location = new System.Drawing.Point(450, 141);
            this.lblTInicioActividades.Name = "lblTInicioActividades";
            this.lblTInicioActividades.Size = new System.Drawing.Size(108, 13);
            this.lblTInicioActividades.TabIndex = 10;
            this.lblTInicioActividades.Text = "Inicio de Actividades:";
            // 
            // lblEmpInicioActividades
            // 
            this.lblEmpInicioActividades.AutoSize = true;
            this.lblEmpInicioActividades.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpInicioActividades.Location = new System.Drawing.Point(564, 141);
            this.lblEmpInicioActividades.Name = "lblEmpInicioActividades";
            this.lblEmpInicioActividades.Size = new System.Drawing.Size(83, 13);
            this.lblEmpInicioActividades.TabIndex = 11;
            this.lblEmpInicioActividades.Text = "FECHA INI ACT";
            // 
            // gbxFiscales
            // 
            this.gbxFiscales.BackColor = System.Drawing.Color.Transparent;
            this.gbxFiscales.Controls.Add(this.dtpVencimiento);
            this.gbxFiscales.Controls.Add(this.txtClienteCod);
            this.gbxFiscales.Controls.Add(this.txtCuit);
            this.gbxFiscales.Controls.Add(this.lblVencimiento);
            this.gbxFiscales.Controls.Add(this.lblClienteCod);
            this.gbxFiscales.Controls.Add(this.lblCuit);
            this.gbxFiscales.Location = new System.Drawing.Point(8, 257);
            this.gbxFiscales.Name = "gbxFiscales";
            this.gbxFiscales.Size = new System.Drawing.Size(672, 73);
            this.gbxFiscales.TabIndex = 4;
            this.gbxFiscales.TabStop = false;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(548, 29);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpVencimiento.TabIndex = 2;
            // 
            // txtClienteCod
            // 
            this.txtClienteCod.Location = new System.Drawing.Point(296, 29);
            this.txtClienteCod.Name = "txtClienteCod";
            this.txtClienteCod.ReadOnly = true;
            this.txtClienteCod.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCod.TabIndex = 58;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(68, 29);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(474, 32);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(68, 13);
            this.lblVencimiento.TabIndex = 5;
            this.lblVencimiento.Text = "Vencimiento:";
            // 
            // lblClienteCod
            // 
            this.lblClienteCod.AutoSize = true;
            this.lblClienteCod.Location = new System.Drawing.Point(233, 32);
            this.lblClienteCod.Name = "lblClienteCod";
            this.lblClienteCod.Size = new System.Drawing.Size(57, 13);
            this.lblClienteCod.TabIndex = 4;
            this.lblClienteCod.Text = "Cliente N°:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(17, 32);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(50, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT N°:";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbxDetalle.Controls.Add(this.grdDetallePresupuesto);
            this.gbxDetalle.Location = new System.Drawing.Point(8, 337);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(672, 255);
            this.gbxDetalle.TabIndex = 5;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // grdDetallePresupuesto
            // 
            this.grdDetallePresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetallePresupuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Totales});
            this.grdDetallePresupuesto.Location = new System.Drawing.Point(6, 15);
            this.grdDetallePresupuesto.Name = "grdDetallePresupuesto";
            this.grdDetallePresupuesto.Size = new System.Drawing.Size(658, 234);
            this.grdDetallePresupuesto.TabIndex = 0;
            this.grdDetallePresupuesto.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetallePresupuesto_CellValueChanged);
            this.grdDetallePresupuesto.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetallePresupuesto_CellValidated);
            this.grdDetallePresupuesto.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdDetallePresupuesto_UserDeletedRow);
            this.grdDetallePresupuesto.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDetallePresupuesto_CellValidating);
            this.grdDetallePresupuesto.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetallePresupuesto_RowValidated);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ToolTipText = "Código y Color de Artículo";
            this.Codigo.Width = 80;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ToolTipText = "Cantidad de Artículos";
            this.Cantidad.Width = 70;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descripcion.ToolTipText = "Descripción del Artículo";
            this.Descripcion.Width = 300;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.ToolTipText = "Precio";
            this.Precio.Width = 70;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            this.Totales.ToolTipText = "Totales";
            this.Totales.Width = 90;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.BackColor = System.Drawing.Color.Transparent;
            this.lblCondiciones.Location = new System.Drawing.Point(9, 629);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(68, 13);
            this.lblCondiciones.TabIndex = 6;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(11, 645);
            this.txtCondiciones.MaxLength = 250;
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCondiciones.Size = new System.Drawing.Size(391, 39);
            this.txtCondiciones.TabIndex = 7;
            this.toolTipControl.SetToolTip(this.txtCondiciones, "Condiciones de pago (Ej. Efectivo)");
            // 
            // txtDisponibilidad
            // 
            this.txtDisponibilidad.Location = new System.Drawing.Point(12, 703);
            this.txtDisponibilidad.MaxLength = 250;
            this.txtDisponibilidad.Multiline = true;
            this.txtDisponibilidad.Name = "txtDisponibilidad";
            this.txtDisponibilidad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDisponibilidad.Size = new System.Drawing.Size(390, 32);
            this.txtDisponibilidad.TabIndex = 30;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(174, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 31);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "       Guardar";
            this.toolTipControl.SetToolTip(this.btnGuardar, "Guardar Presupuesto");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(285, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "       Cancelar";
            this.toolTipControl.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarImprimir
            // 
            this.btnGuardarImprimir.BackgroundImage = global::ConexcoFacturación.Properties.Resources.imprimir3;
            this.btnGuardarImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardarImprimir.Location = new System.Drawing.Point(12, 4);
            this.btnGuardarImprimir.Name = "btnGuardarImprimir";
            this.btnGuardarImprimir.Size = new System.Drawing.Size(139, 31);
            this.btnGuardarImprimir.TabIndex = 10;
            this.btnGuardarImprimir.Text = "       Guardar e Imprimir";
            this.toolTipControl.SetToolTip(this.btnGuardarImprimir, "Guardar e Imprimir Presupuesto");
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            this.btnGuardarImprimir.Click += new System.EventHandler(this.btnGuardarImprimir_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(575, 603);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(100, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "0";
            // 
            // lblTTotal
            // 
            this.lblTTotal.AutoSize = true;
            this.lblTTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTTotal.Location = new System.Drawing.Point(507, 602);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTTotal.TabIndex = 27;
            this.lblTTotal.Text = "Total $:";
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(383, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(99, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "PRESUPUESTO";
            // 
            // lblTNumFact
            // 
            this.lblTNumFact.AutoSize = true;
            this.lblTNumFact.BackColor = System.Drawing.Color.Transparent;
            this.lblTNumFact.Location = new System.Drawing.Point(383, 76);
            this.lblTNumFact.Name = "lblTNumFact";
            this.lblTNumFact.Size = new System.Drawing.Size(19, 13);
            this.lblTNumFact.TabIndex = 43;
            this.lblTNumFact.Text = "N°";
            // 
            // txtNumPresupuesto
            // 
            this.txtNumPresupuesto.BackColor = System.Drawing.Color.Azure;
            this.txtNumPresupuesto.Location = new System.Drawing.Point(404, 73);
            this.txtNumPresupuesto.MaxLength = 20;
            this.txtNumPresupuesto.Name = "txtNumPresupuesto";
            this.txtNumPresupuesto.Size = new System.Drawing.Size(100, 20);
            this.txtNumPresupuesto.TabIndex = 1;
            this.txtNumPresupuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.txtNumPresupuesto.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "P";
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.BackColor = System.Drawing.Color.Transparent;
            this.lblPesos.Location = new System.Drawing.Point(9, 687);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(72, 13);
            this.lblPesos.TabIndex = 29;
            this.lblPesos.Text = "Disponibilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 603);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "Los importes expresados no incluyen I.V.A.";
            // 
            // FrmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FacturaBmp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(689, 748);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumPresupuesto);
            this.Controls.Add(this.lblTNumFact);
            this.Controls.Add(this.btnGuardarImprimir);
            this.Controls.Add(this.lblTTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDisponibilidad);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.lblCondiciones);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxFiscales);
            this.Controls.Add(this.lblEmpInicioActividades);
            this.Controls.Add(this.lblTInicioActividades);
            this.Controls.Add(this.lblEmpIngBrutos);
            this.Controls.Add(this.lblTEmpIngBrut);
            this.Controls.Add(this.lblEmpCuit);
            this.Controls.Add(this.lblTEmpCuit);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxEmpresa);
            this.Controls.Add(this.dtpFechaEmision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPresupuesto";
            this.Text = "Formulario de Presupuesto";
            this.Load += new System.EventHandler(this.FrmPresupuesto_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPresupuesto_FormClosing);
            this.gbxEmpresa.ResumeLayout(false);
            this.gbxEmpresa.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxFiscales.ResumeLayout(false);
            this.gbxFiscales.PerformLayout();
            this.gbxDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetallePresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.GroupBox gbxEmpresa;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.Label lblEmpLocalidad;
        private System.Windows.Forms.Label lblEmpCodPostal;
        private System.Windows.Forms.Label lblEmpDomicilio;
        private System.Windows.Forms.Label lblEmpRazonSocial;
        private System.Windows.Forms.Label lblEmpPosicionIVA;
        private System.Windows.Forms.Label lblEmpFax;
        private System.Windows.Forms.Label lblEmpTel;
        private System.Windows.Forms.Label lblEmpProvincia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTEmpCuit;
        private System.Windows.Forms.Label lblEmpCuit;
        private System.Windows.Forms.Label lblTEmpIngBrut;
        private System.Windows.Forms.Label lblEmpIngBrutos;
        private System.Windows.Forms.Label lblTInicioActividades;
        private System.Windows.Forms.Label lblEmpInicioActividades;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilioEntrega;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox gbxFiscales;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblClienteCod;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.TextBox txtClienteCod;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.DataGridView grdDetallePresupuesto;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.TextBox txtCondiciones;
        private System.Windows.Forms.TextBox txtDisponibilidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarImprimir;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.Label lblTEmpProvincia;
        private System.Windows.Forms.Label lblTEmpPosicionIva;
        private System.Windows.Forms.Label lblTEmpFax;
        private System.Windows.Forms.Label lblTEmpTelefono;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.ComboBox cmbRazonSocial;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
        private System.Windows.Forms.DataGridViewComboBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.TextBox txtNumPresupuesto;
        private System.Windows.Forms.Label lblTNumFact;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProvincia;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.Label label2;

    }
}