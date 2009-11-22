namespace ConexcoFacturación
{
    partial class FrmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactura));
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.cmbLetra = new System.Windows.Forms.ComboBox();
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
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.lblEstadoDoc = new System.Windows.Forms.Label();
            this.cmbEstadoDoc = new System.Windows.Forms.ComboBox();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTEmpCuit = new System.Windows.Forms.Label();
            this.lblEmpCuit = new System.Windows.Forms.Label();
            this.lblTEmpIngBrut = new System.Windows.Forms.Label();
            this.lblEmpIngBrutos = new System.Windows.Forms.Label();
            this.lblTInicioActividades = new System.Windows.Forms.Label();
            this.lblEmpInicioActividades = new System.Windows.Forms.Label();
            this.gbxFiscales = new System.Windows.Forms.GroupBox();
            this.txtCondIva = new System.Windows.Forms.TextBox();
            this.dtpVencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtClienteCod = new System.Windows.Forms.TextBox();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtRemito = new System.Windows.Forms.TextBox();
            this.lblVencimiento = new System.Windows.Forms.Label();
            this.lblClienteCod = new System.Windows.Forms.Label();
            this.lblOrdenCompra = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblRemito = new System.Windows.Forms.Label();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.gbxObservaciones = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.grdDetalleFactura = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCondiciones = new System.Windows.Forms.Label();
            this.txtCondiciones = new System.Windows.Forms.TextBox();
            this.lblPesos = new System.Windows.Forms.Label();
            this.txtSonPesos = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarImprimir = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblTNetoPagar = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTTotalIva = new System.Windows.Forms.Label();
            this.lblTSubtotal = new System.Windows.Forms.Label();
            this.lblTotalIva = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblNetoPagar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.btnTipoValor = new System.Windows.Forms.Button();
            this.lblTNumFact = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxEmpresa.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxFiscales.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            this.gbxObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).BeginInit();
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
            // cmbLetra
            // 
            this.cmbLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLetra.FormattingEnabled = true;
            this.cmbLetra.Location = new System.Drawing.Point(328, 64);
            this.cmbLetra.Name = "cmbLetra";
            this.cmbLetra.Size = new System.Drawing.Size(34, 21);
            this.cmbLetra.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.cmbLetra, "Tipo de Factura (A/B)");
            this.cmbLetra.SelectedIndexChanged += new System.EventHandler(this.cmbLetra_SelectedIndexChanged);
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
            this.gbxCliente.Controls.Add(this.cmbRazonSocial);
            this.gbxCliente.Controls.Add(this.lblEstadoDoc);
            this.gbxCliente.Controls.Add(this.cmbEstadoDoc);
            this.gbxCliente.Controls.Add(this.txtProvincia);
            this.gbxCliente.Controls.Add(this.btnClientes);
            this.gbxCliente.Controls.Add(this.txtCodPostal);
            this.gbxCliente.Controls.Add(this.txtLocalidad);
            this.gbxCliente.Controls.Add(this.txtDomicilio);
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
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.BackColor = System.Drawing.SystemColors.Window;
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
            // lblEstadoDoc
            // 
            this.lblEstadoDoc.AutoSize = true;
            this.lblEstadoDoc.Location = new System.Drawing.Point(449, 23);
            this.lblEstadoDoc.Name = "lblEstadoDoc";
            this.lblEstadoDoc.Size = new System.Drawing.Size(84, 13);
            this.lblEstadoDoc.TabIndex = 26;
            this.lblEstadoDoc.Text = "Estado del doc.:";
            // 
            // cmbEstadoDoc
            // 
            this.cmbEstadoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoDoc.FormattingEnabled = true;
            this.cmbEstadoDoc.Location = new System.Drawing.Point(538, 16);
            this.cmbEstadoDoc.Name = "cmbEstadoDoc";
            this.cmbEstadoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoDoc.TabIndex = 2;
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(538, 65);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(117, 20);
            this.txtProvincia.TabIndex = 6;
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
            this.txtCodPostal.Location = new System.Drawing.Point(367, 66);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.ReadOnly = true;
            this.txtCodPostal.Size = new System.Drawing.Size(75, 20);
            this.txtCodPostal.TabIndex = 5;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtLocalidad.Location = new System.Drawing.Point(76, 67);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(215, 20);
            this.txtLocalidad.TabIndex = 4;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.BackColor = System.Drawing.SystemColors.Control;
            this.txtDomicilio.Location = new System.Drawing.Point(76, 39);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(215, 20);
            this.txtDomicilio.TabIndex = 3;
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
            this.lblCodPostal.Location = new System.Drawing.Point(299, 71);
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
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(383, 57);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(64, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "FACTURA";
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
            this.gbxFiscales.Controls.Add(this.txtCondIva);
            this.gbxFiscales.Controls.Add(this.dtpVencimiento);
            this.gbxFiscales.Controls.Add(this.txtClienteCod);
            this.gbxFiscales.Controls.Add(this.txtOrdenCompra);
            this.gbxFiscales.Controls.Add(this.txtCuit);
            this.gbxFiscales.Controls.Add(this.txtRemito);
            this.gbxFiscales.Controls.Add(this.lblVencimiento);
            this.gbxFiscales.Controls.Add(this.lblClienteCod);
            this.gbxFiscales.Controls.Add(this.lblOrdenCompra);
            this.gbxFiscales.Controls.Add(this.lblIva);
            this.gbxFiscales.Controls.Add(this.lblCuit);
            this.gbxFiscales.Controls.Add(this.lblRemito);
            this.gbxFiscales.Location = new System.Drawing.Point(8, 257);
            this.gbxFiscales.Name = "gbxFiscales";
            this.gbxFiscales.Size = new System.Drawing.Size(672, 73);
            this.gbxFiscales.TabIndex = 4;
            this.gbxFiscales.TabStop = false;
            // 
            // txtCondIva
            // 
            this.txtCondIva.Location = new System.Drawing.Point(334, 16);
            this.txtCondIva.Name = "txtCondIva";
            this.txtCondIva.ReadOnly = true;
            this.txtCondIva.Size = new System.Drawing.Size(124, 20);
            this.txtCondIva.TabIndex = 59;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(555, 39);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpVencimiento.TabIndex = 2;
            // 
            // txtClienteCod
            // 
            this.txtClienteCod.Location = new System.Drawing.Point(555, 13);
            this.txtClienteCod.Name = "txtClienteCod";
            this.txtClienteCod.ReadOnly = true;
            this.txtClienteCod.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCod.TabIndex = 58;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(358, 42);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenCompra.TabIndex = 1;
            this.txtOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(68, 43);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // txtRemito
            // 
            this.txtRemito.Location = new System.Drawing.Point(68, 14);
            this.txtRemito.Name = "txtRemito";
            this.txtRemito.Size = new System.Drawing.Size(100, 20);
            this.txtRemito.TabIndex = 0;
            this.txtRemito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(530, 43);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(26, 13);
            this.lblVencimiento.TabIndex = 5;
            this.lblVencimiento.Text = "Vto.";
            // 
            // lblClienteCod
            // 
            this.lblClienteCod.AutoSize = true;
            this.lblClienteCod.Location = new System.Drawing.Point(499, 20);
            this.lblClienteCod.Name = "lblClienteCod";
            this.lblClienteCod.Size = new System.Drawing.Size(57, 13);
            this.lblClienteCod.TabIndex = 4;
            this.lblClienteCod.Text = "Cliente N°:";
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.Location = new System.Drawing.Point(244, 44);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(108, 13);
            this.lblOrdenCompra.TabIndex = 3;
            this.lblOrdenCompra.Text = "Orden de Compra N°:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(302, 17);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(17, 43);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(50, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT N°:";
            // 
            // lblRemito
            // 
            this.lblRemito.AutoSize = true;
            this.lblRemito.Location = new System.Drawing.Point(9, 17);
            this.lblRemito.Name = "lblRemito";
            this.lblRemito.Size = new System.Drawing.Size(58, 13);
            this.lblRemito.TabIndex = 0;
            this.lblRemito.Text = "Remito N°:";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbxDetalle.Controls.Add(this.gbxObservaciones);
            this.gbxDetalle.Controls.Add(this.grdDetalleFactura);
            this.gbxDetalle.Location = new System.Drawing.Point(8, 337);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(672, 255);
            this.gbxDetalle.TabIndex = 5;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // gbxObservaciones
            // 
            this.gbxObservaciones.Controls.Add(this.txtObservaciones);
            this.gbxObservaciones.Location = new System.Drawing.Point(4, 184);
            this.gbxObservaciones.Name = "gbxObservaciones";
            this.gbxObservaciones.Size = new System.Drawing.Size(660, 64);
            this.gbxObservaciones.TabIndex = 1;
            this.gbxObservaciones.TabStop = false;
            this.gbxObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(6, 12);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(648, 46);
            this.txtObservaciones.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.txtObservaciones, "Información Adicional (Ej. N° de Lote)");
            // 
            // grdDetalleFactura
            // 
            this.grdDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cantidad,
            this.Descripcion,
            this.Precio,
            this.Totales});
            this.grdDetalleFactura.Location = new System.Drawing.Point(6, 15);
            this.grdDetalleFactura.Name = "grdDetalleFactura";
            this.grdDetalleFactura.Size = new System.Drawing.Size(658, 163);
            this.grdDetalleFactura.TabIndex = 0;
            this.grdDetalleFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleFactura_CellValueChanged);
            this.grdDetalleFactura.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdDetalleFactura_UserDeletedRow);
            this.grdDetalleFactura.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDetalleFactura_CellValidating);
            this.grdDetalleFactura.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleFactura_RowValidated);
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
            this.Cantidad.ToolTipText = "Cantidad";
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
            this.lblCondiciones.Location = new System.Drawing.Point(8, 602);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(68, 13);
            this.lblCondiciones.TabIndex = 6;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(11, 615);
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCondiciones.Size = new System.Drawing.Size(391, 53);
            this.txtCondiciones.TabIndex = 7;
            this.toolTipControl.SetToolTip(this.txtCondiciones, "Condiciones de pago (Ej. Efectivo)");
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.BackColor = System.Drawing.Color.Transparent;
            this.lblPesos.Location = new System.Drawing.Point(9, 673);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(57, 13);
            this.lblPesos.TabIndex = 29;
            this.lblPesos.Text = "Son pesos";
            // 
            // txtSonPesos
            // 
            this.txtSonPesos.Location = new System.Drawing.Point(12, 689);
            this.txtSonPesos.Multiline = true;
            this.txtSonPesos.Name = "txtSonPesos";
            this.txtSonPesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSonPesos.Size = new System.Drawing.Size(390, 46);
            this.txtSonPesos.TabIndex = 30;
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
            this.toolTipControl.SetToolTip(this.btnGuardar, "Guardar Factura");
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
            this.toolTipControl.SetToolTip(this.btnGuardarImprimir, "Guardar e Imprimir factura");
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            this.btnGuardarImprimir.Click += new System.EventHandler(this.btnGuardarImprimir_Click);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(587, 628);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(88, 20);
            this.txtDescuento.TabIndex = 8;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            this.txtDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosDecimales_KeyPress);
            // 
            // lblTNetoPagar
            // 
            this.lblTNetoPagar.AutoSize = true;
            this.lblTNetoPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblTNetoPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNetoPagar.Location = new System.Drawing.Point(464, 711);
            this.lblTNetoPagar.Name = "lblTNetoPagar";
            this.lblTNetoPagar.Size = new System.Drawing.Size(86, 13);
            this.lblTNetoPagar.TabIndex = 34;
            this.lblTNetoPagar.Text = "Neto a Pagar:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Location = new System.Drawing.Point(575, 655);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubtotal.Size = new System.Drawing.Size(100, 13);
            this.lblSubtotal.TabIndex = 37;
            this.lblSubtotal.Text = "0";
            // 
            // lblTTotalIva
            // 
            this.lblTTotalIva.AutoSize = true;
            this.lblTTotalIva.BackColor = System.Drawing.Color.Transparent;
            this.lblTTotalIva.Location = new System.Drawing.Point(514, 682);
            this.lblTTotalIva.Name = "lblTTotalIva";
            this.lblTTotalIva.Size = new System.Drawing.Size(36, 13);
            this.lblTTotalIva.TabIndex = 33;
            this.lblTTotalIva.Text = "I.V.A.:";
            // 
            // lblTSubtotal
            // 
            this.lblTSubtotal.AutoSize = true;
            this.lblTSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTSubtotal.Location = new System.Drawing.Point(501, 654);
            this.lblTSubtotal.Name = "lblTSubtotal";
            this.lblTSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblTSubtotal.TabIndex = 32;
            this.lblTSubtotal.Text = "Subtotal:";
            // 
            // lblTotalIva
            // 
            this.lblTotalIva.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalIva.Location = new System.Drawing.Point(575, 682);
            this.lblTotalIva.Name = "lblTotalIva";
            this.lblTotalIva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalIva.Size = new System.Drawing.Size(100, 13);
            this.lblTotalIva.TabIndex = 39;
            this.lblTotalIva.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.Location = new System.Drawing.Point(488, 632);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 31;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblNetoPagar
            // 
            this.lblNetoPagar.BackColor = System.Drawing.Color.Transparent;
            this.lblNetoPagar.Location = new System.Drawing.Point(575, 712);
            this.lblNetoPagar.Name = "lblNetoPagar";
            this.lblNetoPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetoPagar.Size = new System.Drawing.Size(100, 13);
            this.lblNetoPagar.TabIndex = 40;
            this.lblNetoPagar.Text = "0";
            this.lblNetoPagar.TextChanged += new System.EventHandler(this.lblNetoPagar_TextChanged);
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
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
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
            // btnTipoValor
            // 
            this.btnTipoValor.Location = new System.Drawing.Point(563, 628);
            this.btnTipoValor.Name = "btnTipoValor";
            this.btnTipoValor.Size = new System.Drawing.Size(20, 20);
            this.btnTipoValor.TabIndex = 9;
            this.btnTipoValor.Text = "$";
            this.toolTipControl.SetToolTip(this.btnTipoValor, "Descuento en pesos o en porcentaje");
            this.btnTipoValor.UseVisualStyleBackColor = true;
            this.btnTipoValor.Click += new System.EventHandler(this.btnTipoValor_Click);
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
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(404, 73);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumFactura.TabIndex = 1;
            this.txtNumFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.txtNumFactura.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 748);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblTNumFact);
            this.Controls.Add(this.btnTipoValor);
            this.Controls.Add(this.btnGuardarImprimir);
            this.Controls.Add(this.lblTTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNetoPagar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtSonPesos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblTotalIva);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.lblTSubtotal);
            this.Controls.Add(this.lblCondiciones);
            this.Controls.Add(this.lblTTotalIva);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.gbxFiscales);
            this.Controls.Add(this.lblTNetoPagar);
            this.Controls.Add(this.lblEmpInicioActividades);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.lblTInicioActividades);
            this.Controls.Add(this.lblEmpIngBrutos);
            this.Controls.Add(this.lblTEmpIngBrut);
            this.Controls.Add(this.lblEmpCuit);
            this.Controls.Add(this.lblTEmpCuit);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxEmpresa);
            this.Controls.Add(this.cmbLetra);
            this.Controls.Add(this.dtpFechaEmision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmFactura";
            this.Text = "Formulario de Factura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.gbxEmpresa.ResumeLayout(false);
            this.gbxEmpresa.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxFiscales.ResumeLayout(false);
            this.gbxFiscales.PerformLayout();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxObservaciones.ResumeLayout(false);
            this.gbxObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.ComboBox cmbLetra;
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
        private System.Windows.Forms.Label lblTitulo;
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
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.GroupBox gbxFiscales;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtRemito;
        private System.Windows.Forms.Label lblVencimiento;
        private System.Windows.Forms.Label lblClienteCod;
        private System.Windows.Forms.Label lblOrdenCompra;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblRemito;
        private System.Windows.Forms.DateTimePicker dtpVencimiento;
        private System.Windows.Forms.TextBox txtClienteCod;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.DataGridView grdDetalleFactura;
        private System.Windows.Forms.GroupBox gbxObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblCondiciones;
        private System.Windows.Forms.TextBox txtCondiciones;
        private System.Windows.Forms.Label lblPesos;
        private System.Windows.Forms.TextBox txtSonPesos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarImprimir;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblTNetoPagar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTTotalIva;
        private System.Windows.Forms.Label lblTSubtotal;
        private System.Windows.Forms.Label lblTotalIva;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblNetoPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.Button btnTipoValor;
        private System.Windows.Forms.Label lblTNumFact;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label lblTEmpProvincia;
        private System.Windows.Forms.Label lblTEmpPosicionIva;
        private System.Windows.Forms.Label lblTEmpFax;
        private System.Windows.Forms.Label lblTEmpTelefono;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCondIva;
        private System.Windows.Forms.Label lblEstadoDoc;
        private System.Windows.Forms.ComboBox cmbEstadoDoc;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.ComboBox cmbRazonSocial;
        private System.Windows.Forms.DataGridViewComboBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;

    }
}