namespace ConexcoFacturación
{
    partial class FrmRemito
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
            this.lblLetra = new System.Windows.Forms.Label();
            this.lblTNumFact = new System.Windows.Forms.Label();
            this.btnGuardarImprimir = new System.Windows.Forms.Button();
            this.lblValorDeclarado = new System.Windows.Forms.Label();
            this.txtCondIva = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.grdDetalleRemito = new System.Windows.Forms.DataGridView();
            this.Envases = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxDetalle = new System.Windows.Forms.GroupBox();
            this.lblTArticulo = new System.Windows.Forms.Label();
            this.lblTCantidad = new System.Windows.Forms.Label();
            this.gbxFiscales = new System.Windows.Forms.GroupBox();
            this.lblCantBultos = new System.Windows.Forms.Label();
            this.txtCantBultos = new System.Windows.Forms.TextBox();
            this.txtOrdenCompra = new System.Windows.Forms.TextBox();
            this.lblOrdenCompra = new System.Windows.Forms.Label();
            this.txtTransportistaCUIT = new System.Windows.Forms.TextBox();
            this.lblTransportistaCUIT = new System.Windows.Forms.Label();
            this.btnTransportistas = new System.Windows.Forms.Button();
            this.txtTransportistaDomicilio = new System.Windows.Forms.TextBox();
            this.txtTransportistaRazonSocial = new System.Windows.Forms.TextBox();
            this.lblDomicilioComercial = new System.Windows.Forms.Label();
            this.lblTTransportista = new System.Windows.Forms.Label();
            this.txtClienteCod = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblClienteCod = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblEmpInicioActividades = new System.Windows.Forms.Label();
            this.lblTInicioActividades = new System.Windows.Forms.Label();
            this.lblEmpIngBrutos = new System.Windows.Forms.Label();
            this.lblTEmpIngBrut = new System.Windows.Forms.Label();
            this.lblTEmpPosicionIva = new System.Windows.Forms.Label();
            this.lblEmpCuit = new System.Windows.Forms.Label();
            this.lblTEmpProvincia = new System.Windows.Forms.Label();
            this.lblEstadoDoc = new System.Windows.Forms.Label();
            this.cmbEstadoDoc = new System.Windows.Forms.ComboBox();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblTEmpFax = new System.Windows.Forms.Label();
            this.lblTEmpTelefono = new System.Windows.Forms.Label();
            this.txtProvincia = new System.Windows.Forms.TextBox();
            this.lblEmpPosicionIVA = new System.Windows.Forms.Label();
            this.lblEmpFax = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.gbxEmpresa = new System.Windows.Forms.GroupBox();
            this.lblEmpTel = new System.Windows.Forms.Label();
            this.lblEmpProvincia = new System.Windows.Forms.Label();
            this.lblEmpLocalidad = new System.Windows.Forms.Label();
            this.lblEmpCodPostal = new System.Windows.Forms.Label();
            this.lblEmpDomicilio = new System.Windows.Forms.Label();
            this.lblEmpRazonSocial = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.lblTEmpCuit = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.btnIva = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleRemito)).BeginInit();
            this.gbxDetalle.SuspendLayout();
            this.gbxFiscales.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.Location = new System.Drawing.Point(333, 23);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(23, 24);
            this.lblLetra.TabIndex = 0;
            this.lblLetra.Text = "R";
            // 
            // lblTNumFact
            // 
            this.lblTNumFact.AutoSize = true;
            this.lblTNumFact.Location = new System.Drawing.Point(384, 37);
            this.lblTNumFact.Name = "lblTNumFact";
            this.lblTNumFact.Size = new System.Drawing.Size(19, 13);
            this.lblTNumFact.TabIndex = 78;
            this.lblTNumFact.Text = "N°";
            // 
            // btnGuardarImprimir
            // 
            this.btnGuardarImprimir.Location = new System.Drawing.Point(146, 710);
            this.btnGuardarImprimir.Name = "btnGuardarImprimir";
            this.btnGuardarImprimir.Size = new System.Drawing.Size(109, 23);
            this.btnGuardarImprimir.TabIndex = 77;
            this.btnGuardarImprimir.Text = "Guardar e Imprimir";
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            // 
            // lblValorDeclarado
            // 
            this.lblValorDeclarado.AutoSize = true;
            this.lblValorDeclarado.Location = new System.Drawing.Point(452, 593);
            this.lblValorDeclarado.Name = "lblValorDeclarado";
            this.lblValorDeclarado.Size = new System.Drawing.Size(95, 13);
            this.lblValorDeclarado.TabIndex = 62;
            this.lblValorDeclarado.Text = "Valor Declarado $:";
            // 
            // txtCondIva
            // 
            this.txtCondIva.Location = new System.Drawing.Point(393, 68);
            this.txtCondIva.Name = "txtCondIva";
            this.txtCondIva.ReadOnly = true;
            this.txtCondIva.Size = new System.Drawing.Size(100, 20);
            this.txtCondIva.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(419, 710);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(581, 593);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(100, 13);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "0";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(291, 710);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // grdDetalleRemito
            // 
            this.grdDetalleRemito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalleRemito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Envases,
            this.Unidades,
            this.Codigo,
            this.Descripcion,
            this.Precio,
            this.Totales});
            this.grdDetalleRemito.Location = new System.Drawing.Point(3, 46);
            this.grdDetalleRemito.Name = "grdDetalleRemito";
            this.grdDetalleRemito.Size = new System.Drawing.Size(658, 200);
            this.grdDetalleRemito.TabIndex = 0;
            this.grdDetalleRemito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleRemito_CellValueChanged);
            // 
            // Envases
            // 
            this.Envases.HeaderText = "Envases";
            this.Envases.Name = "Envases";
            this.Envases.Width = 50;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.Width = 70;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descripcion.Width = 280;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 70;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            this.Totales.Width = 70;
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.Controls.Add(this.lblTArticulo);
            this.gbxDetalle.Controls.Add(this.lblTCantidad);
            this.gbxDetalle.Controls.Add(this.grdDetalleRemito);
            this.gbxDetalle.Location = new System.Drawing.Point(9, 314);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(672, 255);
            this.gbxDetalle.TabIndex = 60;
            this.gbxDetalle.TabStop = false;
            this.gbxDetalle.Text = "Detalle";
            // 
            // lblTArticulo
            // 
            this.lblTArticulo.AutoSize = true;
            this.lblTArticulo.Location = new System.Drawing.Point(325, 22);
            this.lblTArticulo.Name = "lblTArticulo";
            this.lblTArticulo.Size = new System.Drawing.Size(61, 13);
            this.lblTArticulo.TabIndex = 2;
            this.lblTArticulo.Text = "ARTICULO";
            // 
            // lblTCantidad
            // 
            this.lblTCantidad.AutoSize = true;
            this.lblTCantidad.Location = new System.Drawing.Point(70, 22);
            this.lblTCantidad.Name = "lblTCantidad";
            this.lblTCantidad.Size = new System.Drawing.Size(62, 13);
            this.lblTCantidad.TabIndex = 1;
            this.lblTCantidad.Text = "CANTIDAD";
            // 
            // gbxFiscales
            // 
            this.gbxFiscales.Controls.Add(this.lblCantBultos);
            this.gbxFiscales.Controls.Add(this.txtCantBultos);
            this.gbxFiscales.Controls.Add(this.txtOrdenCompra);
            this.gbxFiscales.Controls.Add(this.lblOrdenCompra);
            this.gbxFiscales.Controls.Add(this.txtTransportistaCUIT);
            this.gbxFiscales.Controls.Add(this.lblTransportistaCUIT);
            this.gbxFiscales.Controls.Add(this.btnTransportistas);
            this.gbxFiscales.Controls.Add(this.txtTransportistaDomicilio);
            this.gbxFiscales.Controls.Add(this.txtTransportistaRazonSocial);
            this.gbxFiscales.Controls.Add(this.lblDomicilioComercial);
            this.gbxFiscales.Controls.Add(this.lblTTransportista);
            this.gbxFiscales.Location = new System.Drawing.Point(9, 217);
            this.gbxFiscales.Name = "gbxFiscales";
            this.gbxFiscales.Size = new System.Drawing.Size(672, 91);
            this.gbxFiscales.TabIndex = 59;
            this.gbxFiscales.TabStop = false;
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(364, 53);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(131, 13);
            this.lblCantBultos.TabIndex = 66;
            this.lblCantBultos.Text = "Cant. de bultos/Paquetes:";
            // 
            // txtCantBultos
            // 
            this.txtCantBultos.Location = new System.Drawing.Point(498, 46);
            this.txtCantBultos.Name = "txtCantBultos";
            this.txtCantBultos.Size = new System.Drawing.Size(100, 20);
            this.txtCantBultos.TabIndex = 65;
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(498, 15);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenCompra.TabIndex = 64;
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.Location = new System.Drawing.Point(384, 20);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(108, 13);
            this.lblOrdenCompra.TabIndex = 63;
            this.lblOrdenCompra.Text = "Orden de Compra N°:";
            // 
            // txtTransportistaCUIT
            // 
            this.txtTransportistaCUIT.Location = new System.Drawing.Point(76, 65);
            this.txtTransportistaCUIT.Name = "txtTransportistaCUIT";
            this.txtTransportistaCUIT.ReadOnly = true;
            this.txtTransportistaCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtTransportistaCUIT.TabIndex = 62;
            // 
            // lblTransportistaCUIT
            // 
            this.lblTransportistaCUIT.AutoSize = true;
            this.lblTransportistaCUIT.Location = new System.Drawing.Point(18, 65);
            this.lblTransportistaCUIT.Name = "lblTransportistaCUIT";
            this.lblTransportistaCUIT.Size = new System.Drawing.Size(50, 13);
            this.lblTransportistaCUIT.TabIndex = 61;
            this.lblTransportistaCUIT.Text = "CUIT N°:";
            // 
            // btnTransportistas
            // 
            this.btnTransportistas.Location = new System.Drawing.Point(329, 12);
            this.btnTransportistas.Name = "btnTransportistas";
            this.btnTransportistas.Size = new System.Drawing.Size(32, 23);
            this.btnTransportistas.TabIndex = 60;
            this.btnTransportistas.Text = "...";
            this.btnTransportistas.UseVisualStyleBackColor = true;
            // 
            // txtTransportistaDomicilio
            // 
            this.txtTransportistaDomicilio.Location = new System.Drawing.Point(125, 41);
            this.txtTransportistaDomicilio.Name = "txtTransportistaDomicilio";
            this.txtTransportistaDomicilio.ReadOnly = true;
            this.txtTransportistaDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtTransportistaDomicilio.TabIndex = 57;
            // 
            // txtTransportistaRazonSocial
            // 
            this.txtTransportistaRazonSocial.Location = new System.Drawing.Point(90, 13);
            this.txtTransportistaRazonSocial.Name = "txtTransportistaRazonSocial";
            this.txtTransportistaRazonSocial.ReadOnly = true;
            this.txtTransportistaRazonSocial.Size = new System.Drawing.Size(229, 20);
            this.txtTransportistaRazonSocial.TabIndex = 6;
            // 
            // lblDomicilioComercial
            // 
            this.lblDomicilioComercial.AutoSize = true;
            this.lblDomicilioComercial.Location = new System.Drawing.Point(18, 46);
            this.lblDomicilioComercial.Name = "lblDomicilioComercial";
            this.lblDomicilioComercial.Size = new System.Drawing.Size(101, 13);
            this.lblDomicilioComercial.TabIndex = 3;
            this.lblDomicilioComercial.Text = "Domicilio Comercial:";
            // 
            // lblTTransportista
            // 
            this.lblTTransportista.AutoSize = true;
            this.lblTTransportista.Location = new System.Drawing.Point(16, 16);
            this.lblTTransportista.Name = "lblTTransportista";
            this.lblTTransportista.Size = new System.Drawing.Size(71, 13);
            this.lblTTransportista.TabIndex = 0;
            this.lblTTransportista.Text = "Transportista:";
            // 
            // txtClienteCod
            // 
            this.txtClienteCod.Location = new System.Drawing.Point(572, 66);
            this.txtClienteCod.Name = "txtClienteCod";
            this.txtClienteCod.ReadOnly = true;
            this.txtClienteCod.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCod.TabIndex = 58;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(499, 42);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // lblClienteCod
            // 
            this.lblClienteCod.AutoSize = true;
            this.lblClienteCod.Location = new System.Drawing.Point(509, 68);
            this.lblClienteCod.Name = "lblClienteCod";
            this.lblClienteCod.Size = new System.Drawing.Size(57, 13);
            this.lblClienteCod.TabIndex = 4;
            this.lblClienteCod.Text = "Cliente N°:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(367, 68);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(443, 48);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(50, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT N°:";
            // 
            // lblEmpInicioActividades
            // 
            this.lblEmpInicioActividades.AutoSize = true;
            this.lblEmpInicioActividades.Location = new System.Drawing.Point(565, 103);
            this.lblEmpInicioActividades.Name = "lblEmpInicioActividades";
            this.lblEmpInicioActividades.Size = new System.Drawing.Size(83, 13);
            this.lblEmpInicioActividades.TabIndex = 58;
            this.lblEmpInicioActividades.Text = "FECHA INI ACT";
            // 
            // lblTInicioActividades
            // 
            this.lblTInicioActividades.AutoSize = true;
            this.lblTInicioActividades.Location = new System.Drawing.Point(451, 103);
            this.lblTInicioActividades.Name = "lblTInicioActividades";
            this.lblTInicioActividades.Size = new System.Drawing.Size(108, 13);
            this.lblTInicioActividades.TabIndex = 57;
            this.lblTInicioActividades.Text = "Inicio de Actividades:";
            // 
            // lblEmpIngBrutos
            // 
            this.lblEmpIngBrutos.AutoSize = true;
            this.lblEmpIngBrutos.Location = new System.Drawing.Point(563, 84);
            this.lblEmpIngBrutos.Name = "lblEmpIngBrutos";
            this.lblEmpIngBrutos.Size = new System.Drawing.Size(110, 13);
            this.lblEmpIngBrutos.TabIndex = 56;
            this.lblEmpIngBrutos.Text = "NUMERO ING BRUT";
            // 
            // lblTEmpIngBrut
            // 
            this.lblTEmpIngBrut.AutoSize = true;
            this.lblTEmpIngBrut.Location = new System.Drawing.Point(432, 84);
            this.lblTEmpIngBrut.Name = "lblTEmpIngBrut";
            this.lblTEmpIngBrut.Size = new System.Drawing.Size(127, 13);
            this.lblTEmpIngBrut.TabIndex = 55;
            this.lblTEmpIngBrut.Text = "Ing. Brutos Conv. Mult.N°";
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
            // lblEmpCuit
            // 
            this.lblEmpCuit.AutoSize = true;
            this.lblEmpCuit.Location = new System.Drawing.Point(563, 52);
            this.lblEmpCuit.Name = "lblEmpCuit";
            this.lblEmpCuit.Size = new System.Drawing.Size(83, 13);
            this.lblEmpCuit.TabIndex = 54;
            this.lblEmpCuit.Text = "NUMERO CUIT";
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
            // lblEstadoDoc
            // 
            this.lblEstadoDoc.AutoSize = true;
            this.lblEstadoDoc.Location = new System.Drawing.Point(393, 23);
            this.lblEstadoDoc.Name = "lblEstadoDoc";
            this.lblEstadoDoc.Size = new System.Drawing.Size(84, 13);
            this.lblEstadoDoc.TabIndex = 26;
            this.lblEstadoDoc.Text = "Estado del doc.:";
            // 
            // cmbEstadoDoc
            // 
            this.cmbEstadoDoc.FormattingEnabled = true;
            this.cmbEstadoDoc.Location = new System.Drawing.Point(483, 16);
            this.cmbEstadoDoc.Name = "cmbEstadoDoc";
            this.cmbEstadoDoc.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoDoc.TabIndex = 25;
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
            // txtProvincia
            // 
            this.txtProvincia.Location = new System.Drawing.Point(263, 68);
            this.txtProvincia.Name = "txtProvincia";
            this.txtProvincia.Size = new System.Drawing.Size(75, 20);
            this.txtProvincia.TabIndex = 24;
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
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.txtCondIva);
            this.gbxCliente.Controls.Add(this.lblEstadoDoc);
            this.gbxCliente.Controls.Add(this.txtClienteCod);
            this.gbxCliente.Controls.Add(this.cmbEstadoDoc);
            this.gbxCliente.Controls.Add(this.txtProvincia);
            this.gbxCliente.Controls.Add(this.btnClientes);
            this.gbxCliente.Controls.Add(this.txtCuit);
            this.gbxCliente.Controls.Add(this.lblClienteCod);
            this.gbxCliente.Controls.Add(this.txtCodPostal);
            this.gbxCliente.Controls.Add(this.txtLocalidad);
            this.gbxCliente.Controls.Add(this.lblIva);
            this.gbxCliente.Controls.Add(this.txtDomicilio);
            this.gbxCliente.Controls.Add(this.txtRazonSocial);
            this.gbxCliente.Controls.Add(this.lblProvincia);
            this.gbxCliente.Controls.Add(this.lblCuit);
            this.gbxCliente.Controls.Add(this.lblCodPostal);
            this.gbxCliente.Controls.Add(this.lblLocalidad);
            this.gbxCliente.Controls.Add(this.lblDomicilio);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Location = new System.Drawing.Point(9, 127);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(672, 92);
            this.gbxCliente.TabIndex = 45;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(331, 42);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(75, 20);
            this.txtCodPostal.TabIndex = 20;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(76, 68);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 19;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(76, 40);
            this.txtDomicilio.Name = "txtDomicilio";
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
            this.lblProvincia.Location = new System.Drawing.Point(203, 69);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 16;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(255, 47);
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
            this.gbxEmpresa.Location = new System.Drawing.Point(9, 7);
            this.gbxEmpresa.Name = "gbxEmpresa";
            this.gbxEmpresa.Size = new System.Drawing.Size(291, 111);
            this.gbxEmpresa.TabIndex = 50;
            this.gbxEmpresa.TabStop = false;
            this.gbxEmpresa.Text = "Empresa";
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
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(581, 19);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaEmision.TabIndex = 46;
            // 
            // lblTEmpCuit
            // 
            this.lblTEmpCuit.AutoSize = true;
            this.lblTEmpCuit.Location = new System.Drawing.Point(522, 52);
            this.lblTEmpCuit.Name = "lblTEmpCuit";
            this.lblTEmpCuit.Size = new System.Drawing.Size(35, 13);
            this.lblTEmpCuit.TabIndex = 53;
            this.lblTEmpCuit.Text = "CUIT:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(522, 25);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 52;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(380, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(49, 13);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "REMITO";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Location = new System.Drawing.Point(405, 34);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.Size = new System.Drawing.Size(100, 20);
            this.txtNumFactura.TabIndex = 79;
            // 
            // btnIva
            // 
            this.btnIva.Location = new System.Drawing.Point(506, 618);
            this.btnIva.Name = "btnIva";
            this.btnIva.Size = new System.Drawing.Size(41, 23);
            this.btnIva.TabIndex = 80;
            this.btnIva.Text = "21%";
            this.btnIva.UseVisualStyleBackColor = true;
            this.btnIva.Click += new System.EventHandler(this.btnIva_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(217, 601);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(100, 20);
            this.txtObservaciones.TabIndex = 81;
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(116, 601);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(78, 13);
            this.lblObservaciones.TabIndex = 82;
            this.lblObservaciones.Text = "Observaciones";
            // 
            // FrmRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.factura;
            this.ClientSize = new System.Drawing.Size(690, 740);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnIva);
            this.Controls.Add(this.lblTNumFact);
            this.Controls.Add(this.btnGuardarImprimir);
            this.Controls.Add(this.lblValorDeclarado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.gbxDetalle);
            this.Controls.Add(this.gbxFiscales);
            this.Controls.Add(this.lblEmpInicioActividades);
            this.Controls.Add(this.lblTInicioActividades);
            this.Controls.Add(this.lblEmpIngBrutos);
            this.Controls.Add(this.lblTEmpIngBrut);
            this.Controls.Add(this.lblEmpCuit);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.gbxEmpresa);
            this.Controls.Add(this.dtpFechaEmision);
            this.Controls.Add(this.lblTEmpCuit);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.lblLetra);
            this.Name = "FrmRemito";
            this.Text = "FrmRemito";
            this.Load += new System.EventHandler(this.FrmRemito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleRemito)).EndInit();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.gbxFiscales.ResumeLayout(false);
            this.gbxFiscales.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxEmpresa.ResumeLayout(false);
            this.gbxEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Label lblTNumFact;
        private System.Windows.Forms.Button btnGuardarImprimir;
        private System.Windows.Forms.Label lblValorDeclarado;
        private System.Windows.Forms.TextBox txtCondIva;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView grdDetalleRemito;
        private System.Windows.Forms.GroupBox gbxDetalle;
        private System.Windows.Forms.GroupBox gbxFiscales;
        private System.Windows.Forms.TextBox txtClienteCod;
        private System.Windows.Forms.TextBox txtTransportistaDomicilio;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtTransportistaRazonSocial;
        private System.Windows.Forms.Label lblClienteCod;
        private System.Windows.Forms.Label lblDomicilioComercial;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblTTransportista;
        private System.Windows.Forms.Label lblEmpInicioActividades;
        private System.Windows.Forms.Label lblTInicioActividades;
        private System.Windows.Forms.Label lblEmpIngBrutos;
        private System.Windows.Forms.Label lblTEmpIngBrut;
        private System.Windows.Forms.Label lblTEmpPosicionIva;
        private System.Windows.Forms.Label lblEmpCuit;
        private System.Windows.Forms.Label lblTEmpProvincia;
        private System.Windows.Forms.Label lblEstadoDoc;
        private System.Windows.Forms.ComboBox cmbEstadoDoc;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblTEmpFax;
        private System.Windows.Forms.Label lblTEmpTelefono;
        private System.Windows.Forms.TextBox txtProvincia;
        private System.Windows.Forms.Label lblEmpPosicionIVA;
        private System.Windows.Forms.Label lblEmpFax;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.GroupBox gbxEmpresa;
        private System.Windows.Forms.Label lblEmpTel;
        private System.Windows.Forms.Label lblEmpProvincia;
        private System.Windows.Forms.Label lblEmpLocalidad;
        private System.Windows.Forms.Label lblEmpCodPostal;
        private System.Windows.Forms.Label lblEmpDomicilio;
        private System.Windows.Forms.Label lblEmpRazonSocial;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label lblTEmpCuit;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Button btnTransportistas;
        private System.Windows.Forms.TextBox txtTransportistaCUIT;
        private System.Windows.Forms.Label lblTransportistaCUIT;
        private System.Windows.Forms.Label lblCantBultos;
        private System.Windows.Forms.TextBox txtCantBultos;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.Label lblOrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Envases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewComboBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
        private System.Windows.Forms.Label lblTArticulo;
        private System.Windows.Forms.Label lblTCantidad;
        private System.Windows.Forms.Button btnIva;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblObservaciones;
    }
}