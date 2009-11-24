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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemito));
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblTEmpFax = new System.Windows.Forms.Label();
            this.lblTEmpTelefono = new System.Windows.Forms.Label();
            this.lblEmpPosicionIVA = new System.Windows.Forms.Label();
            this.lblEmpFax = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.cmbRazonSocial = new System.Windows.Forms.ComboBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.btnLocalidad = new System.Windows.Forms.Button();
            this.txtCodPostal = new System.Windows.Forms.TextBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
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
            this.txtNumRemito = new System.Windows.Forms.TextBox();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.toolTipControl = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleRemito)).BeginInit();
            this.gbxDetalle.SuspendLayout();
            this.gbxFiscales.SuspendLayout();
            this.gbxCliente.SuspendLayout();
            this.gbxEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.BackColor = System.Drawing.Color.Transparent;
            this.lblLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetra.Location = new System.Drawing.Point(333, 63);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(23, 24);
            this.lblLetra.TabIndex = 0;
            this.lblLetra.Text = "R";
            this.toolTipControl.SetToolTip(this.lblLetra, "Remito");
            // 
            // lblTNumFact
            // 
            this.lblTNumFact.AutoSize = true;
            this.lblTNumFact.BackColor = System.Drawing.Color.Transparent;
            this.lblTNumFact.Location = new System.Drawing.Point(384, 77);
            this.lblTNumFact.Name = "lblTNumFact";
            this.lblTNumFact.Size = new System.Drawing.Size(19, 13);
            this.lblTNumFact.TabIndex = 78;
            this.lblTNumFact.Text = "N°";
            // 
            // btnGuardarImprimir
            // 
            this.btnGuardarImprimir.BackgroundImage = global::ConexcoFacturación.Properties.Resources.imprimir3;
            this.btnGuardarImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardarImprimir.Location = new System.Drawing.Point(12, 4);
            this.btnGuardarImprimir.Name = "btnGuardarImprimir";
            this.btnGuardarImprimir.Size = new System.Drawing.Size(139, 31);
            this.btnGuardarImprimir.TabIndex = 7;
            this.btnGuardarImprimir.Text = "       Guardar e Imprimir";
            this.toolTipControl.SetToolTip(this.btnGuardarImprimir, "Guardar e Imprimir Remito");
            this.btnGuardarImprimir.UseVisualStyleBackColor = true;
            this.btnGuardarImprimir.Click += new System.EventHandler(this.btnGuardarImprimir_Click);
            // 
            // lblValorDeclarado
            // 
            this.lblValorDeclarado.AutoSize = true;
            this.lblValorDeclarado.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDeclarado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDeclarado.Location = new System.Drawing.Point(436, 644);
            this.lblValorDeclarado.Name = "lblValorDeclarado";
            this.lblValorDeclarado.Size = new System.Drawing.Size(113, 13);
            this.lblValorDeclarado.TabIndex = 62;
            this.lblValorDeclarado.Text = "Valor Declarado $:";
            this.toolTipControl.SetToolTip(this.lblValorDeclarado, "Valor IVA Incluido");
            // 
            // txtCondIva
            // 
            this.txtCondIva.Location = new System.Drawing.Point(564, 80);
            this.txtCondIva.Name = "txtCondIva";
            this.txtCondIva.ReadOnly = true;
            this.txtCondIva.Size = new System.Drawing.Size(100, 20);
            this.txtCondIva.TabIndex = 59;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(285, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 31);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "       Cancelar";
            this.toolTipControl.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Location = new System.Drawing.Point(578, 644);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotal.Size = new System.Drawing.Size(100, 13);
            this.lblTotal.TabIndex = 63;
            this.lblTotal.Text = "0";
            this.toolTipControl.SetToolTip(this.lblTotal, "IVA Incluido");
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(174, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 31);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "       Guardar";
            this.toolTipControl.SetToolTip(this.btnGuardar, "Guardar Remito");
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
            this.grdDetalleRemito.Location = new System.Drawing.Point(7, 44);
            this.grdDetalleRemito.Name = "grdDetalleRemito";
            this.grdDetalleRemito.Size = new System.Drawing.Size(658, 178);
            this.grdDetalleRemito.TabIndex = 0;
            this.grdDetalleRemito.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleRemito_CellValueChanged);
            this.grdDetalleRemito.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleRemito_CellValidated);
            this.grdDetalleRemito.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.grdDetalleRemito_UserDeletedRow);
            this.grdDetalleRemito.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grdDetalleRemito_CellValidating);
            this.grdDetalleRemito.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDetalleRemito_RowValidated);
            // 
            // Envases
            // 
            this.Envases.HeaderText = "Envases";
            this.Envases.Name = "Envases";
            this.Envases.ToolTipText = "Cantidad de Envases";
            this.Envases.Width = 50;
            // 
            // Unidades
            // 
            this.Unidades.HeaderText = "Unidades";
            this.Unidades.Name = "Unidades";
            this.Unidades.ToolTipText = "Cantidad de Unidades";
            this.Unidades.Width = 60;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ToolTipText = "Código y Color de Artículo";
            this.Codigo.Width = 80;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Descripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Descripcion.ToolTipText = "Descripción de Artículo";
            this.Descripcion.Width = 280;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.ToolTipText = "IVA Incluido";
            this.Precio.Width = 60;
            // 
            // Totales
            // 
            this.Totales.HeaderText = "Totales";
            this.Totales.Name = "Totales";
            this.Totales.ReadOnly = true;
            this.Totales.ToolTipText = "IVA Incluido";
            this.Totales.Width = 70;
            // 
            // gbxDetalle
            // 
            this.gbxDetalle.BackColor = System.Drawing.Color.Transparent;
            this.gbxDetalle.Controls.Add(this.lblTArticulo);
            this.gbxDetalle.Controls.Add(this.lblTCantidad);
            this.gbxDetalle.Controls.Add(this.grdDetalleRemito);
            this.gbxDetalle.Location = new System.Drawing.Point(9, 401);
            this.gbxDetalle.Name = "gbxDetalle";
            this.gbxDetalle.Size = new System.Drawing.Size(672, 228);
            this.gbxDetalle.TabIndex = 5;
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
            this.gbxFiscales.BackColor = System.Drawing.Color.Transparent;
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
            this.gbxFiscales.Location = new System.Drawing.Point(9, 299);
            this.gbxFiscales.Name = "gbxFiscales";
            this.gbxFiscales.Size = new System.Drawing.Size(672, 91);
            this.gbxFiscales.TabIndex = 4;
            this.gbxFiscales.TabStop = false;
            // 
            // lblCantBultos
            // 
            this.lblCantBultos.AutoSize = true;
            this.lblCantBultos.Location = new System.Drawing.Point(424, 55);
            this.lblCantBultos.Name = "lblCantBultos";
            this.lblCantBultos.Size = new System.Drawing.Size(131, 13);
            this.lblCantBultos.TabIndex = 66;
            this.lblCantBultos.Text = "Cant. de bultos/Paquetes:";
            // 
            // txtCantBultos
            // 
            this.txtCantBultos.Location = new System.Drawing.Point(562, 48);
            this.txtCantBultos.Name = "txtCantBultos";
            this.txtCantBultos.Size = new System.Drawing.Size(100, 20);
            this.txtCantBultos.TabIndex = 3;
            this.txtCantBultos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // txtOrdenCompra
            // 
            this.txtOrdenCompra.Location = new System.Drawing.Point(562, 17);
            this.txtOrdenCompra.Name = "txtOrdenCompra";
            this.txtOrdenCompra.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenCompra.TabIndex = 2;
            this.txtOrdenCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            // 
            // lblOrdenCompra
            // 
            this.lblOrdenCompra.AutoSize = true;
            this.lblOrdenCompra.Location = new System.Drawing.Point(447, 22);
            this.lblOrdenCompra.Name = "lblOrdenCompra";
            this.lblOrdenCompra.Size = new System.Drawing.Size(108, 13);
            this.lblOrdenCompra.TabIndex = 63;
            this.lblOrdenCompra.Text = "Orden de Compra N°:";
            // 
            // txtTransportistaCUIT
            // 
            this.txtTransportistaCUIT.Location = new System.Drawing.Point(114, 65);
            this.txtTransportistaCUIT.Name = "txtTransportistaCUIT";
            this.txtTransportistaCUIT.ReadOnly = true;
            this.txtTransportistaCUIT.Size = new System.Drawing.Size(100, 20);
            this.txtTransportistaCUIT.TabIndex = 62;
            this.toolTipControl.SetToolTip(this.txtTransportistaCUIT, "CUIT del transportista");
            // 
            // lblTransportistaCUIT
            // 
            this.lblTransportistaCUIT.AutoSize = true;
            this.lblTransportistaCUIT.Location = new System.Drawing.Point(60, 68);
            this.lblTransportistaCUIT.Name = "lblTransportistaCUIT";
            this.lblTransportistaCUIT.Size = new System.Drawing.Size(50, 13);
            this.lblTransportistaCUIT.TabIndex = 61;
            this.lblTransportistaCUIT.Text = "CUIT N°:";
            // 
            // btnTransportistas
            // 
            this.btnTransportistas.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnTransportistas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTransportistas.Location = new System.Drawing.Point(358, 11);
            this.btnTransportistas.Name = "btnTransportistas";
            this.btnTransportistas.Size = new System.Drawing.Size(32, 23);
            this.btnTransportistas.TabIndex = 1;
            this.toolTipControl.SetToolTip(this.btnTransportistas, "Buscador de Transportistas");
            this.btnTransportistas.UseVisualStyleBackColor = true;
            this.btnTransportistas.Click += new System.EventHandler(this.btnTransportistas_Click);
            // 
            // txtTransportistaDomicilio
            // 
            this.txtTransportistaDomicilio.Location = new System.Drawing.Point(114, 39);
            this.txtTransportistaDomicilio.Name = "txtTransportistaDomicilio";
            this.txtTransportistaDomicilio.ReadOnly = true;
            this.txtTransportistaDomicilio.Size = new System.Drawing.Size(229, 20);
            this.txtTransportistaDomicilio.TabIndex = 57;
            this.toolTipControl.SetToolTip(this.txtTransportistaDomicilio, "Domicilio del transportista");
            // 
            // txtTransportistaRazonSocial
            // 
            this.txtTransportistaRazonSocial.Location = new System.Drawing.Point(114, 13);
            this.txtTransportistaRazonSocial.Name = "txtTransportistaRazonSocial";
            this.txtTransportistaRazonSocial.ReadOnly = true;
            this.txtTransportistaRazonSocial.Size = new System.Drawing.Size(229, 20);
            this.txtTransportistaRazonSocial.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.txtTransportistaRazonSocial, "Utilice el buscador para seleccionar un transportista");
            this.txtTransportistaRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblDomicilioComercial
            // 
            this.lblDomicilioComercial.AutoSize = true;
            this.lblDomicilioComercial.Location = new System.Drawing.Point(9, 42);
            this.lblDomicilioComercial.Name = "lblDomicilioComercial";
            this.lblDomicilioComercial.Size = new System.Drawing.Size(101, 13);
            this.lblDomicilioComercial.TabIndex = 3;
            this.lblDomicilioComercial.Text = "Domicilio Comercial:";
            // 
            // lblTTransportista
            // 
            this.lblTTransportista.AutoSize = true;
            this.lblTTransportista.Location = new System.Drawing.Point(39, 16);
            this.lblTTransportista.Name = "lblTTransportista";
            this.lblTTransportista.Size = new System.Drawing.Size(71, 13);
            this.lblTTransportista.TabIndex = 0;
            this.lblTTransportista.Text = "Transportista:";
            // 
            // txtClienteCod
            // 
            this.txtClienteCod.Location = new System.Drawing.Point(564, 54);
            this.txtClienteCod.Name = "txtClienteCod";
            this.txtClienteCod.ReadOnly = true;
            this.txtClienteCod.Size = new System.Drawing.Size(100, 20);
            this.txtClienteCod.TabIndex = 58;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(564, 30);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // lblClienteCod
            // 
            this.lblClienteCod.AutoSize = true;
            this.lblClienteCod.Location = new System.Drawing.Point(493, 57);
            this.lblClienteCod.Name = "lblClienteCod";
            this.lblClienteCod.Size = new System.Drawing.Size(57, 13);
            this.lblClienteCod.TabIndex = 4;
            this.lblClienteCod.Text = "Cliente N°:";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(523, 83);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(27, 13);
            this.lblIva.TabIndex = 2;
            this.lblIva.Text = "IVA:";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(500, 33);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(50, 13);
            this.lblCuit.TabIndex = 1;
            this.lblCuit.Text = "CUIT N°:";
            // 
            // lblEmpInicioActividades
            // 
            this.lblEmpInicioActividades.AutoSize = true;
            this.lblEmpInicioActividades.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpInicioActividades.Location = new System.Drawing.Point(563, 142);
            this.lblEmpInicioActividades.Name = "lblEmpInicioActividades";
            this.lblEmpInicioActividades.Size = new System.Drawing.Size(83, 13);
            this.lblEmpInicioActividades.TabIndex = 58;
            this.lblEmpInicioActividades.Text = "FECHA INI ACT";
            // 
            // lblTInicioActividades
            // 
            this.lblTInicioActividades.AutoSize = true;
            this.lblTInicioActividades.BackColor = System.Drawing.Color.Transparent;
            this.lblTInicioActividades.Location = new System.Drawing.Point(451, 142);
            this.lblTInicioActividades.Name = "lblTInicioActividades";
            this.lblTInicioActividades.Size = new System.Drawing.Size(108, 13);
            this.lblTInicioActividades.TabIndex = 57;
            this.lblTInicioActividades.Text = "Inicio de Actividades:";
            // 
            // lblEmpIngBrutos
            // 
            this.lblEmpIngBrutos.AutoSize = true;
            this.lblEmpIngBrutos.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpIngBrutos.Location = new System.Drawing.Point(563, 117);
            this.lblEmpIngBrutos.Name = "lblEmpIngBrutos";
            this.lblEmpIngBrutos.Size = new System.Drawing.Size(110, 13);
            this.lblEmpIngBrutos.TabIndex = 56;
            this.lblEmpIngBrutos.Text = "NUMERO ING BRUT";
            // 
            // lblTEmpIngBrut
            // 
            this.lblTEmpIngBrut.AutoSize = true;
            this.lblTEmpIngBrut.BackColor = System.Drawing.Color.Transparent;
            this.lblTEmpIngBrut.Location = new System.Drawing.Point(432, 117);
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
            this.lblEmpCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpCuit.Location = new System.Drawing.Point(563, 92);
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
            // btnClientes
            // 
            this.btnClientes.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClientes.Location = new System.Drawing.Point(335, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(32, 23);
            this.btnClientes.TabIndex = 1;
            this.toolTipControl.SetToolTip(this.btnClientes, "Buscador de Clientes");
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
            this.gbxCliente.BackColor = System.Drawing.Color.Transparent;
            this.gbxCliente.Controls.Add(this.cmbRazonSocial);
            this.gbxCliente.Controls.Add(this.cmbProvincia);
            this.gbxCliente.Controls.Add(this.btnLocalidad);
            this.gbxCliente.Controls.Add(this.txtCondIva);
            this.gbxCliente.Controls.Add(this.txtClienteCod);
            this.gbxCliente.Controls.Add(this.btnClientes);
            this.gbxCliente.Controls.Add(this.txtCuit);
            this.gbxCliente.Controls.Add(this.lblClienteCod);
            this.gbxCliente.Controls.Add(this.txtCodPostal);
            this.gbxCliente.Controls.Add(this.txtLocalidad);
            this.gbxCliente.Controls.Add(this.lblIva);
            this.gbxCliente.Controls.Add(this.txtDomicilio);
            this.gbxCliente.Controls.Add(this.lblProvincia);
            this.gbxCliente.Controls.Add(this.lblCuit);
            this.gbxCliente.Controls.Add(this.lblCodPostal);
            this.gbxCliente.Controls.Add(this.lblLocalidad);
            this.gbxCliente.Controls.Add(this.lblDomicilio);
            this.gbxCliente.Controls.Add(this.lblRazonSocial);
            this.gbxCliente.Location = new System.Drawing.Point(9, 167);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(672, 123);
            this.gbxCliente.TabIndex = 3;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente";
            // 
            // cmbRazonSocial
            // 
            this.cmbRazonSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRazonSocial.FormattingEnabled = true;
            this.cmbRazonSocial.Location = new System.Drawing.Point(76, 13);
            this.cmbRazonSocial.Name = "cmbRazonSocial";
            this.cmbRazonSocial.Size = new System.Drawing.Size(243, 21);
            this.cmbRazonSocial.TabIndex = 0;
            this.toolTipControl.SetToolTip(this.cmbRazonSocial, "Seleccione un cliente o utilice el buscador");
            this.cmbRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            this.cmbRazonSocial.SelectedIndexChanged += new System.EventHandler(this.cmbRazonSocial_SelectedIndexChanged);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(76, 92);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(149, 21);
            this.cmbProvincia.TabIndex = 5;
            this.toolTipControl.SetToolTip(this.cmbProvincia, "Provincia de Entrega");
            this.cmbProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnLocalidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLocalidad.Location = new System.Drawing.Point(239, 66);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 4;
            this.toolTipControl.SetToolTip(this.btnLocalidad, "Buscador de Localidades");
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(311, 94);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(75, 20);
            this.txtCodPostal.TabIndex = 6;
            this.toolTipControl.SetToolTip(this.txtCodPostal, "Código Postal de Entrega");
            this.txtCodPostal.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(76, 66);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(149, 20);
            this.txtLocalidad.TabIndex = 3;
            this.toolTipControl.SetToolTip(this.txtLocalidad, "Localidad de Entrega");
            this.txtLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(76, 40);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(243, 20);
            this.txtDomicilio.TabIndex = 2;
            this.toolTipControl.SetToolTip(this.txtDomicilio, "Domicilio de entrega");
            this.txtDomicilio.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(11, 95);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 16;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(244, 97);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(64, 13);
            this.lblCodPostal.TabIndex = 15;
            this.lblCodPostal.Text = "Cod. Postal:";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(9, 68);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 14;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(13, 42);
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
            this.gbxEmpresa.Location = new System.Drawing.Point(9, 47);
            this.gbxEmpresa.Name = "gbxEmpresa";
            this.gbxEmpresa.Size = new System.Drawing.Size(291, 111);
            this.gbxEmpresa.TabIndex = 50;
            this.gbxEmpresa.TabStop = false;
            this.gbxEmpresa.Text = "Empresa";
            this.toolTipControl.SetToolTip(this.gbxEmpresa, "Información de la Empresa");
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
            this.dtpFechaEmision.Location = new System.Drawing.Point(581, 59);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(83, 20);
            this.dtpFechaEmision.TabIndex = 2;
            this.toolTipControl.SetToolTip(this.dtpFechaEmision, "Seleccione la fecha");
            // 
            // lblTEmpCuit
            // 
            this.lblTEmpCuit.AutoSize = true;
            this.lblTEmpCuit.BackColor = System.Drawing.Color.Transparent;
            this.lblTEmpCuit.Location = new System.Drawing.Point(522, 92);
            this.lblTEmpCuit.Name = "lblTEmpCuit";
            this.lblTEmpCuit.Size = new System.Drawing.Size(35, 13);
            this.lblTEmpCuit.TabIndex = 53;
            this.lblTEmpCuit.Text = "CUIT:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Location = new System.Drawing.Point(522, 65);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 52;
            this.lblFecha.Text = "Fecha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(380, 58);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 13);
            this.lblTitulo.TabIndex = 51;
            this.lblTitulo.Text = "REMITO";
            // 
            // txtNumRemito
            // 
            this.txtNumRemito.Location = new System.Drawing.Point(405, 74);
            this.txtNumRemito.Name = "txtNumRemito";
            this.txtNumRemito.Size = new System.Drawing.Size(100, 20);
            this.txtNumRemito.TabIndex = 1;
            this.toolTipControl.SetToolTip(this.txtNumRemito, "Número de Remito");
            this.txtNumRemito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumeros_KeyPress);
            this.txtNumRemito.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.BackColor = System.Drawing.Color.Transparent;
            this.lblObservaciones.Location = new System.Drawing.Point(20, 642);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(159, 13);
            this.lblObservaciones.TabIndex = 82;
            this.lblObservaciones.Text = "Observaciones (No se imprimen)";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(16, 658);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(379, 53);
            this.txtObservaciones.TabIndex = 6;
            this.toolTipControl.SetToolTip(this.txtObservaciones, "Información Adicional (No se imprime)");
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // FrmRemito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 720);
            this.Controls.Add(this.lblObservaciones);
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
            this.Controls.Add(this.txtNumRemito);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.txtObservaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRemito";
            this.Text = "Formulario de Remito";
            this.Load += new System.EventHandler(this.FrmRemito_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmRemito_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalleRemito)).EndInit();
            this.gbxDetalle.ResumeLayout(false);
            this.gbxDetalle.PerformLayout();
            this.gbxFiscales.ResumeLayout(false);
            this.gbxFiscales.PerformLayout();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxEmpresa.ResumeLayout(false);
            this.gbxEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
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
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Label lblTEmpFax;
        private System.Windows.Forms.Label lblTEmpTelefono;
        private System.Windows.Forms.Label lblEmpPosicionIVA;
        private System.Windows.Forms.Label lblEmpFax;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.TextBox txtCodPostal;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
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
        private System.Windows.Forms.TextBox txtNumRemito;
        private System.Windows.Forms.Button btnTransportistas;
        private System.Windows.Forms.TextBox txtTransportistaCUIT;
        private System.Windows.Forms.Label lblTransportistaCUIT;
        private System.Windows.Forms.Label lblCantBultos;
        private System.Windows.Forms.TextBox txtCantBultos;
        private System.Windows.Forms.TextBox txtOrdenCompra;
        private System.Windows.Forms.Label lblOrdenCompra;
        private System.Windows.Forms.Label lblTArticulo;
        private System.Windows.Forms.Label lblTCantidad;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnLocalidad;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.ToolTip toolTipControl;
        private System.Windows.Forms.ComboBox cmbRazonSocial;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Envases;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidades;
        private System.Windows.Forms.DataGridViewComboBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewComboBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totales;
    }
}