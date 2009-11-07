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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
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
            this.btnIva = new System.Windows.Forms.Button();
            this.lblTSubtotal = new System.Windows.Forms.Label();
            this.lblTotalIva = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblNetoPagar = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTTotal = new System.Windows.Forms.Label();
            this.btnTipoValor = new System.Windows.Forms.Button();
            this.lblTNumFact = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.gbxEmpresa.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxFiscales.SuspendLayout();
            this.gbxDetalle.SuspendLayout();
            this.gbxObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(580, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // cmbLetra
            // 
            this.cmbLetra.FormattingEnabled = true;
            this.cmbLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmbLetra.Location = new System.Drawing.Point(329, 24);
            this.cmbLetra.Name = "cmbLetra";
            this.cmbLetra.Size = new System.Drawing.Size(34, 21);
            this.cmbLetra.TabIndex = 2;
            // 
            // gbxEmpresa
            // 
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
            this.gbxEmpresa.Location = new System.Drawing.Point(8, 6);
            this.gbxEmpresa.Name = "gbxEmpresa";
            this.gbxEmpresa.Size = new System.Drawing.Size(291, 111);
            this.gbxEmpresa.TabIndex = 3;
            this.gbxEmpresa.TabStop = false;
            this.gbxEmpresa.Text = "Empresa";
            // 
            // lblTEmpProvincia
            // 
            this.lblTEmpProvincia.AutoSize = true;
            this.lblTEmpProvincia.Location = new System.Drawing.Point(172, 53);
            this.lblTEmpProvincia.Name = "lblTEmpProvincia";
            this.lblTEmpProvincia.Size = new System.Drawing.Size(31, 13);
            this.lblTEmpProvincia.TabIndex = 11;
            this.lblTEmpProvincia.Text = "Pcia.";
            // 
            // lblTEmpPosicionIva
            // 
            this.lblTEmpPosicionIva.AutoSize = true;
            this.lblTEmpPosicionIva.Location = new System.Drawing.Point(16, 93);
            this.lblTEmpPosicionIva.Name = "lblTEmpPosicionIva";
            this.lblTEmpPosicionIva.Size = new System.Drawing.Size(33, 13);
            this.lblTEmpPosicionIva.TabIndex = 10;
            this.lblTEmpPosicionIva.Text = "I.V.A.";
            // 
            // lblTEmpFax
            // 
            this.lblTEmpFax.AutoSize = true;
            this.lblTEmpFax.Location = new System.Drawing.Point(172, 73);
            this.lblTEmpFax.Name = "lblTEmpFax";
            this.lblTEmpFax.Size = new System.Drawing.Size(27, 13);
            this.lblTEmpFax.TabIndex = 9;
            this.lblTEmpFax.Text = "Fax.";
            // 
            // lblTEmpTelefono
            // 
            this.lblTEmpTelefono.AutoSize = true;
            this.lblTEmpTelefono.Location = new System.Drawing.Point(16, 73);
            this.lblTEmpTelefono.Name = "lblTEmpTelefono";
            this.lblTEmpTelefono.Size = new System.Drawing.Size(25, 13);
            this.lblTEmpTelefono.TabIndex = 8;
            this.lblTEmpTelefono.Text = "Tel.";
            // 
            // lblEmpPosicionIVA
            // 
            this.lblEmpPosicionIVA.AutoSize = true;
            this.lblEmpPosicionIVA.Location = new System.Drawing.Point(54, 93);
            this.lblEmpPosicionIVA.Name = "lblEmpPosicionIVA";
            this.lblEmpPosicionIVA.Size = new System.Drawing.Size(78, 13);
            this.lblEmpPosicionIVA.TabIndex = 7;
            this.lblEmpPosicionIVA.Text = "POSICION IVA";
            // 
            // lblEmpFax
            // 
            this.lblEmpFax.AutoSize = true;
            this.lblEmpFax.Location = new System.Drawing.Point(203, 73);
            this.lblEmpFax.Name = "lblEmpFax";
            this.lblEmpFax.Size = new System.Drawing.Size(27, 13);
            this.lblEmpFax.TabIndex = 6;
            this.lblEmpFax.Text = "FAX";
            // 
            // lblEmpTel
            // 
            this.lblEmpTel.AutoSize = true;
            this.lblEmpTel.Location = new System.Drawing.Point(47, 73);
            this.lblEmpTel.Name = "lblEmpTel";
            this.lblEmpTel.Size = new System.Drawing.Size(64, 13);
            this.lblEmpTel.TabIndex = 5;
            this.lblEmpTel.Text = "TELEFONO";
            // 
            // lblEmpProvincia
            // 
            this.lblEmpProvincia.AutoSize = true;
            this.lblEmpProvincia.Location = new System.Drawing.Point(203, 53);
            this.lblEmpProvincia.Name = "lblEmpProvincia";
            this.lblEmpProvincia.Size = new System.Drawing.Size(65, 13);
            this.lblEmpProvincia.TabIndex = 4;
            this.lblEmpProvincia.Text = "PROVINCIA";
            // 
            // lblEmpLocalidad
            // 
            this.lblEmpLocalidad.AutoSize = true;
            this.lblEmpLocalidad.Location = new System.Drawing.Point(65, 54);
            this.lblEmpLocalidad.Name = "lblEmpLocalidad";
            this.lblEmpLocalidad.Size = new System.Drawing.Size(67, 13);
            this.lblEmpLocalidad.TabIndex = 3;
            this.lblEmpLocalidad.Text = "LOCALIDAD";
            // 
            // lblEmpCodPostal
            // 
            this.lblEmpCodPostal.AutoSize = true;
            this.lblEmpCodPostal.Location = new System.Drawing.Point(16, 53);
            this.lblEmpCodPostal.Name = "lblEmpCodPostal";
            this.lblEmpCodPostal.Size = new System.Drawing.Size(27, 13);
            this.lblEmpCodPostal.TabIndex = 2;
            this.lblEmpCodPostal.Text = "(CP)";
            // 
            // lblEmpDomicilio
            // 
            this.lblEmpDomicilio.AutoSize = true;
            this.lblEmpDomicilio.Location = new System.Drawing.Point(16, 36);
            this.lblEmpDomicilio.Name = "lblEmpDomicilio";
            this.lblEmpDomicilio.Size = new System.Drawing.Size(62, 13);
            this.lblEmpDomicilio.TabIndex = 1;
            this.lblEmpDomicilio.Text = "DOMICILIO";
            // 
            // lblEmpRazonSocial
            // 
            this.lblEmpRazonSocial.AutoSize = true;
            this.lblEmpRazonSocial.Location = new System.Drawing.Point(16, 17);
            this.lblEmpRazonSocial.Name = "lblEmpRazonSocial";
            this.lblEmpRazonSocial.Size = new System.Drawing.Size(86, 13);
            this.lblEmpRazonSocial.TabIndex = 0;
            this.lblEmpRazonSocial.Text = "RAZON SOCIAL";
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtProvincia);
            this.gbxCliente.Controls.Add(this.btnClientes);
            this.gbxCliente.Controls.Add(this.txtCodPostal);
            this.gbxCliente.Controls.Add(this.txtLocalidad);
            this.gbxCliente.Controls.Add(this.txtDomicilio);
            this.gbxCliente.Controls.Add(this.txtRazonSocial);
            this.gbxCliente.Controls.Add(this.lblProvincia);
            this.gbxCliente.Controls.Add(this.lblCodPostal);
            this.gbxCliente.Controls.Add(this.lblLocalidad);
            this.gbxCliente.Controls.Add(this.lblDomicilio);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Location = new System.Drawing.Point(8, 126);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(672, 92);
            this.gbxCliente.TabIndex = 0;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(543, 66);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.ReadOnly = true;
            this.txtProvincia.Size = new System.Drawing.Size(75, 20);
            this.txtProvincia.TabIndex = 24;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(329, 13);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(32, 23);
            this.btnClientes.TabIndex = 22;
            this.btnClientes.Text = "...";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(319, 67);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.ReadOnly = true;
            this.txtCodPostal.Size = new System.Drawing.Size(75, 20);
            this.txtCodPostal.TabIndex = 20;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(76, 68);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.ReadOnly = true;
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 19;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(76, 40);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(154, 20);
            this.txtDomicilio.TabIndex = 18;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(76, 13);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.ReadOnly = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(243, 20);
            this.txtRazonSocial.TabIndex = 17;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(467, 70);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 16;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(249, 72);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodPostal.TabIndex = 15;
            this.lblCodPostal.Text = "Cod. Postal:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 66);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(16, 40);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lblDomicilio.TabIndex = 13;
            this.lblDomicilio.Text = "Domicilio:";
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Location = new System.Drawing.Point(16, 16);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(49, 13);
            this.lblRazonSocial.TabIndex = 12;
            this.lblRazonSocial.Text = "Señores:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(379, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "FACTURA";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(521, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTEmpCuit
            // 
            this.lblTEmpCuit.AutoSize = true;
            this.lblTEmpCuit.Location = new System.Drawing.Point(521, 51);
            this.lblTEmpCuit.Name = "lblTEmpCuit";
            this.lblTEmpCuit.Size = new System.Drawing.Size(35, 13);
            this.lblTEmpCuit.TabIndex = 6;
            this.lblTEmpCuit.Text = "CUIT:";
            // 
            // lblEmpCuit
            // 
            this.lblEmpCuit.AutoSize = true;
            this.lblEmpCuit.Location = new System.Drawing.Point(562, 51);
            this.lblEmpCuit.Name = "lblEmpCuit";
            this.lblEmpCuit.Size = new System.Drawing.Size(83, 13);
            this.lblEmpCuit.TabIndex = 7;
            this.lblEmpCuit.Text = "NUMERO CUIT";
            // 
            // lblTEmpIngBrut
            // 
            this.lblTEmpIngBrut.AutoSize = true;
            this.lblTEmpIngBrut.Location = new System.Drawing.Point(431, 83);
            this.lblTEmpIngBrut.Name = "lblTEmpIngBrut";
            this.lblTEmpIngBrut.Size = new System.Drawing.Size(127, 13);
            this.lblTEmpIngBrut.TabIndex = 8;
            this.lblTEmpIngBrut.Text = "Ing. Brutos Conv. Mult.N°";
            // 
            // lblEmpIngBrutos
            // 
            this.lblEmpIngBrutos.AutoSize = true;
            this.lblEmpIngBrutos.Location = new System.Drawing.Point(562, 83);
            this.lblEmpIngBrutos.Name = "lblEmpIngBrutos";
            this.lblEmpIngBrutos.Size = new System.Drawing.Size(110, 13);
            this.lblEmpIngBrutos.TabIndex = 9;
            this.lblEmpIngBrutos.Text = "NUMERO ING BRUT";
            // 
            // lblTInicioActividades
            // 
            this.lblTInicioActividades.AutoSize = true;
            this.lblTInicioActividades.Location = new System.Drawing.Point(450, 102);
            this.lblTInicioActividades.Name = "lblTInicioActividades";
            this.lblTInicioActividades.Size = new System.Drawing.Size(108, 13);
            this.lblTInicioActividades.TabIndex = 10;
            this.lblTInicioActividades.Text = "Inicio de Actividades:";
            // 
            // lblEmpInicioActividades
            // 
            this.lblEmpInicioActividades.AutoSize = true;
            this.lblEmpInicioActividades.Location = new System.Drawing.Point(564, 102);
            this.lblEmpInicioActividades.Name = "lblEmpInicioActividades";
            this.lblEmpInicioActividades.Size = new System.Drawing.Size(83, 13);
            this.lblEmpInicioActividades.TabIndex = 11;
            this.lblEmpInicioActividades.Text = "FECHA INI ACT";
            // 
            // gbxFiscales
            // 
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
            this.gbxFiscales.Location = new System.Drawing.Point(8, 218);
            this.gbxFiscales.Name = "gbxFiscales";
            this.gbxFiscales.Size = new System.Drawing.Size(672, 73);
            this.gbxFiscales.TabIndex = 24;
            this.gbxFiscales.TabStop = false;
            this.gbxFiscales.Text = "Fiscales";
            // 
            // txtCondIva
            // 
            this.txtCondIva.Location = new System.Drawing.Point(358, 17);
            this.txtCondIva.Name = "txtCondIva";
            this.txtCondIva.ReadOnly = true;
            this.txtCondIva.Size = new System.Drawing.Size(100, 20);
            this.txtCondIva.TabIndex = 59;
            // 
            // dtpVencimiento
            // 
            this.dtpVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVencimiento.Location = new System.Drawing.Point(572, 40);
            this.dtpVencimiento.Name = "dtpVencimiento";
            this.dtpVencimiento.Size = new System.Drawing.Size(83, 20);
            this.dtpVencimiento.TabIndex = 25;
            // 
            // txtClienteCod
            // 
            this.txtClienteCod.Location = new System.Drawing.Point(555, 14);
            this.txtClienteCod.Name = "txtClienteCod";
            this.txtClienteCod.ReadOnly = true;
            this.txtClienteCod.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCod.TabIndex = 58;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(358, 43);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenCompra.TabIndex = 57;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(68, 44);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // txtRemito
            // 
            this.txtRemito.Location = new System.Drawing.Point(68, 15);
            this.txtRemito.Name = "txtRemito";
            this.txtRemito.Size = new System.Drawing.Size(100, 20);
            this.txtRemito.TabIndex = 6;
            // 
            // lblVencimiento
            // 
            this.lblVencimiento.AutoSize = true;
            this.lblVencimiento.Location = new System.Drawing.Point(540, 44);
            this.lblVencimiento.Name = "lblVencimiento";
            this.lblVencimiento.Size = new System.Drawing.Size(26, 13);
            this.lblVencimiento.TabIndex = 5;
            this.lblVencimiento.Text = "Vto.";
            // 
            // lblClienteCod
            // 
            this.lblClienteCod.AutoSize = true;
            this.lblClienteCod.Location = new System.Drawing.Point(499, 21);
            this.lblClienteCod.Name = "lblClienteCod";
            this.lblClienteCod.Size = new System.Drawing.Size(57, 13);
            this.lblClienteCod.TabIndex = 4;
            this.lblClienteCod.Text = "Cliente N°:";
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.Location = new System.Drawing.Point(243, 43);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(108, 13);
            this.lblOrdenCompra.TabIndex = 3;
            this.lblOrdenCompra.Text = "Orden de Compra N°:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(321, 18);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(9, 44);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(50, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT N°:";
            // 
            // lblRemito
            // 
            this.lblRemito.AutoSize = true;
            this.lblRemito.Location = new System.Drawing.Point(9, 18);
            this.lblRemito.Name = "lblRemito";
            this.lblRemito.Size = new System.Drawing.Size(58, 13);
            this.lblRemito.TabIndex = 0;
            this.lblRemito.Text = "Remito N°:";
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.gbxObservaciones);
            this.gbxDetalle.Controls.Add(this.grdDetalleFactura);
            this.gbxDetalle.Location = new System.Drawing.Point(8, 297);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(672, 255);
            this.gbxDetalle.TabIndex = 25;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // gbxObservaciones
            // 
            this.gbxObservaciones.Controls.Add(this.txtObservaciones);
            this.gbxObservaciones.Location = new System.Drawing.Point(4, 185);
            this.gbxObservaciones.Name = "gbxObservaciones";
            this.gbxObservaciones.Size = new System.Drawing.Size(660, 64);
            this.gbxObservaciones.TabIndex = 1;
            this.gbxObservaciones.TabStop = false;
            this.gbxObservaciones.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(6, 19);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(648, 39);
            this.txtObservaciones.TabIndex = 0;
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
            this.grdDetalleFactura.Location = new System.Drawing.Point(6, 16);
            this.grdDetalleFactura.Name = "grdDetalleFactura";
            this.grdDetalleFactura.Size = new System.Drawing.Size(658, 163);
            this.grdDetalleFactura.TabIndex = 0;
            this.grdDetalleFactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleFactura_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            // 
            // lblCondiciones
            // 
            this.lblCondiciones.AutoSize = true;
            this.lblCondiciones.Location = new System.Drawing.Point(8, 562);
            this.lblCondiciones.Name = "lblCondiciones";
            this.lblCondiciones.Size = new System.Drawing.Size(68, 13);
            this.lblCondiciones.TabIndex = 1;
            this.lblCondiciones.Text = "Condiciones:";
            // 
            // txtCondiciones
            // 
            this.txtCondiciones.Location = new System.Drawing.Point(11, 575);
            this.txtCondiciones.Multiline = true;
            this.txtCondiciones.Name = "txtCondiciones";
            this.txtCondiciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCondiciones.Size = new System.Drawing.Size(350, 53);
            this.txtCondiciones.TabIndex = 26;
            // 
            // lblPesos
            // 
            this.lblPesos.AutoSize = true;
            this.lblPesos.Location = new System.Drawing.Point(9, 633);
            this.lblPesos.Name = "lblPesos";
            this.lblPesos.Size = new System.Drawing.Size(57, 13);
            this.lblPesos.TabIndex = 29;
            this.lblPesos.Text = "Son pesos";
            // 
            // txtSonPesos
            // 
            this.txtSonPesos.Location = new System.Drawing.Point(12, 649);
            this.txtSonPesos.Multiline = true;
            this.txtSonPesos.Name = "txtSonPesos";
            this.txtSonPesos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSonPesos.Size = new System.Drawing.Size(349, 46);
            this.txtSonPesos.TabIndex = 30;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(290, 709);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(418, 709);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarImprimir
            // 
            this.btnGuardarImprimir.Location = new System.Drawing.Point(145, 709);
            this.btnGuardarImprimir.Name = "btnGuardarImprimir";
            this.btnGuardarImprimir.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarImprimir.TabIndex = 42;
            this.btnGuardarImprimir.Text = "Guardar e Imprimir";
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(569, 588);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 35;
            this.txtDescuento.Text = "0";
            this.txtDescuento.TextChanged += new System.EventHandler(this.txtDescuento_TextChanged);
            // 
            // lblTNetoPagar
            // 
            this.lblTNetoPagar.AutoSize = true;
            this.lblTNetoPagar.Location = new System.Drawing.Point(462, 668);
            this.lblTNetoPagar.Name = "lblTNetoPagar";
            this.lblTNetoPagar.Size = new System.Drawing.Size(73, 13);
            this.lblTNetoPagar.TabIndex = 34;
            this.lblTNetoPagar.Text = "Neto a Pagar:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(656, 611);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubtotal.Size = new System.Drawing.Size(13, 13);
            this.lblSubtotal.TabIndex = 37;
            this.lblSubtotal.Text = "0";
            // 
            // lblTTotalIva
            // 
            this.lblTTotalIva.AutoSize = true;
            this.lblTTotalIva.Location = new System.Drawing.Point(465, 638);
            this.lblTTotalIva.Name = "lblTTotalIva";
            this.lblTTotalIva.Size = new System.Drawing.Size(36, 13);
            this.lblTTotalIva.TabIndex = 33;
            this.lblTTotalIva.Text = "I.V.A.:";
            // 
            // btnIva
            // 
            this.btnIva.Location = new System.Drawing.Point(507, 633);
            this.btnIva.Name = "btnIva";
            this.btnIva.Size = new System.Drawing.Size(41, 23);
            this.btnIva.TabIndex = 38;
            this.btnIva.Text = "21%";
            this.btnIva.UseVisualStyleBackColor = true;
            // 
            // lblTSubtotal
            // 
            this.lblTSubtotal.AutoSize = true;
            this.lblTSubtotal.Location = new System.Drawing.Point(462, 614);
            this.lblTSubtotal.Name = "lblTSubtotal";
            this.lblTSubtotal.Size = new System.Drawing.Size(49, 13);
            this.lblTSubtotal.TabIndex = 32;
            this.lblTSubtotal.Text = "Subtotal:";
            // 
            // lblTotalIva
            // 
            this.lblTotalIva.AutoSize = true;
            this.lblTotalIva.Location = new System.Drawing.Point(656, 638);
            this.lblTotalIva.Name = "lblTotalIva";
            this.lblTotalIva.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalIva.Size = new System.Drawing.Size(13, 13);
            this.lblTotalIva.TabIndex = 39;
            this.lblTotalIva.Text = "0";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(462, 592);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(62, 13);
            this.lblDescuento.TabIndex = 31;
            this.lblDescuento.Text = "Descuento:";
            // 
            // lblNetoPagar
            // 
            this.lblNetoPagar.AutoSize = true;
            this.lblNetoPagar.Location = new System.Drawing.Point(656, 668);
            this.lblNetoPagar.Name = "lblNetoPagar";
            this.lblNetoPagar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblNetoPagar.Size = new System.Drawing.Size(13, 13);
            this.lblNetoPagar.TabIndex = 40;
            this.lblNetoPagar.Text = "0";
            this.lblNetoPagar.TextChanged += new System.EventHandler(this.lblNetoPagar_TextChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(656, 562);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "0";
            this.lblTotal.TextChanged += new System.EventHandler(this.lblTotal_TextChanged);
            // 
            // lblTTotal
            // 
            this.lblTTotal.AutoSize = true;
            this.lblTTotal.Location = new System.Drawing.Point(507, 562);
            this.lblTTotal.Name = "lblTTotal";
            this.lblTTotal.Size = new System.Drawing.Size(43, 13);
            this.lblTTotal.TabIndex = 27;
            this.lblTTotal.Text = "Total $:";
            // 
            // btnTipoValor
            // 
            this.btnTipoValor.Location = new System.Drawing.Point(530, 588);
            this.btnTipoValor.Name = "btnTipoValor";
            this.btnTipoValor.Size = new System.Drawing.Size(20, 20);
            this.btnTipoValor.TabIndex = 36;
            this.btnTipoValor.Text = "$";
            this.btnTipoValor.UseVisualStyleBackColor = true;
            this.btnTipoValor.Click += new System.EventHandler(this.btnTipoValor_Click);
            // 
            // lblTNumFact
            // 
            this.lblTNumFact.AutoSize = true;
            this.lblTNumFact.Location = new System.Drawing.Point(383, 36);
            this.lblTNumFact.Name = "lblTNumFact";
            this.lblTNumFact.Size = new System.Drawing.Size(19, 13);
            this.lblTNumFact.TabIndex = 43;
            this.lblTNumFact.Text = "N°";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(404, 33);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumFactura.TabIndex = 44;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.factura;
            this.ClientSize = new System.Drawing.Size(691, 741);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblTNumFact);
            this.Controls.Add(this.btnTipoValor);
            this.Controls.Add(this.btnGuardarImprimir);
            this.Controls.Add(this.lblTTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblNetoPagar);
            this.Controls.Add(this.txtSonPesos);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPesos);
            this.Controls.Add(this.lblTotalIva);
            this.Controls.Add(this.txtCondiciones);
            this.Controls.Add(this.lblTSubtotal);
            this.Controls.Add(this.lblCondiciones);
            this.Controls.Add(this.btnIva);
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
            this.Controls.Add(this.dateTimePicker1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private System.Windows.Forms.TextBox txtRazonSocial;
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
        private System.Windows.Forms.Button btnIva;
        private System.Windows.Forms.Label lblTSubtotal;
        private System.Windows.Forms.Label lblTotalIva;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblNetoPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTTotal;
        private System.Windows.Forms.Button btnTipoValor;
        private System.Windows.Forms.Label lblTNumFact;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.DataGridViewComboBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.Label lblTEmpProvincia;
        private System.Windows.Forms.Label lblTEmpPosicionIva;
        private System.Windows.Forms.Label lblTEmpFax;
        private System.Windows.Forms.Label lblTEmpTelefono;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.TextBox txtCondIva;

    }
}