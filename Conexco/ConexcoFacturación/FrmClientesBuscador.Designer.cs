namespace ConexcoFacturación
{
    partial class FrmClientesBuscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientesBuscador));
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.gbxCriteriosBusqueda = new System.Windows.Forms.GroupBox();
            this.txtValorBusqueda = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblValorBusqueda = new System.Windows.Forms.Label();
            this.rbtnCodPostal = new System.Windows.Forms.RadioButton();
            this.rbtnLocalidad = new System.Windows.Forms.RadioButton();
            this.rbtnCondIva = new System.Windows.Forms.RadioButton();
            this.rbtnCuit = new System.Windows.Forms.RadioButton();
            this.rbtnCodigoCliente = new System.Windows.Forms.RadioButton();
            this.rbtnNombreRazonSocial = new System.Windows.Forms.RadioButton();
            this.gbxResultados = new System.Windows.Forms.GroupBox();
            this.lblSeleccioneCliente = new System.Windows.Forms.Label();
            this.lblSeleccioneDomicilio = new System.Windows.Forms.Label();
            this.grdDomicilios = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.gbxCriteriosBusqueda.SuspendLayout();
            this.gbxResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDomicilios)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClientes.Location = new System.Drawing.Point(6, 35);
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.Size = new System.Drawing.Size(556, 115);
            this.grdClientes.TabIndex = 0;
            this.grdClientes.SelectionChanged += new System.EventHandler(this.grdClientes_SelectionChanged);
            // 
            // gbxCriteriosBusqueda
            // 
            this.gbxCriteriosBusqueda.BackColor = System.Drawing.Color.Transparent;
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
            this.gbxCriteriosBusqueda.Size = new System.Drawing.Size(568, 93);
            this.gbxCriteriosBusqueda.TabIndex = 1;
            this.gbxCriteriosBusqueda.TabStop = false;
            this.gbxCriteriosBusqueda.Text = "Criterios de Busqueda";
            // 
            // txtValorBusqueda
            // 
            this.txtValorBusqueda.Location = new System.Drawing.Point(371, 32);
            this.txtValorBusqueda.Name = "txtValorBusqueda";
            this.txtValorBusqueda.Size = new System.Drawing.Size(100, 20);
            this.txtValorBusqueda.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.LupaFacturaPequenia;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Location = new System.Drawing.Point(371, 58);
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
            this.lblValorBusqueda.Location = new System.Drawing.Point(287, 35);
            this.lblValorBusqueda.Name = "lblValorBusqueda";
            this.lblValorBusqueda.Size = new System.Drawing.Size(78, 13);
            this.lblValorBusqueda.TabIndex = 6;
            this.lblValorBusqueda.Text = "Valor a buscar:";
            // 
            // rbtnCodPostal
            // 
            this.rbtnCodPostal.AutoSize = true;
            this.rbtnCodPostal.Location = new System.Drawing.Point(174, 65);
            this.rbtnCodPostal.Name = "rbtnCodPostal";
            this.rbtnCodPostal.Size = new System.Drawing.Size(79, 17);
            this.rbtnCodPostal.TabIndex = 5;
            this.rbtnCodPostal.TabStop = true;
            this.rbtnCodPostal.Text = "Cod. Postal";
            this.rbtnCodPostal.UseVisualStyleBackColor = true;
            // 
            // rbtnLocalidad
            // 
            this.rbtnLocalidad.AutoSize = true;
            this.rbtnLocalidad.Location = new System.Drawing.Point(174, 42);
            this.rbtnLocalidad.Name = "rbtnLocalidad";
            this.rbtnLocalidad.Size = new System.Drawing.Size(71, 17);
            this.rbtnLocalidad.TabIndex = 4;
            this.rbtnLocalidad.TabStop = true;
            this.rbtnLocalidad.Text = "Localidad";
            this.rbtnLocalidad.UseVisualStyleBackColor = true;
            // 
            // rbtnCondIva
            // 
            this.rbtnCondIva.AutoSize = true;
            this.rbtnCondIva.Location = new System.Drawing.Point(174, 19);
            this.rbtnCondIva.Name = "rbtnCondIva";
            this.rbtnCondIva.Size = new System.Drawing.Size(73, 17);
            this.rbtnCondIva.TabIndex = 3;
            this.rbtnCondIva.TabStop = true;
            this.rbtnCondIva.Text = "Cond. IVA";
            this.rbtnCondIva.UseVisualStyleBackColor = true;
            // 
            // rbtnCuit
            // 
            this.rbtnCuit.AutoSize = true;
            this.rbtnCuit.Location = new System.Drawing.Point(6, 65);
            this.rbtnCuit.Name = "rbtnCuit";
            this.rbtnCuit.Size = new System.Drawing.Size(50, 17);
            this.rbtnCuit.TabIndex = 2;
            this.rbtnCuit.TabStop = true;
            this.rbtnCuit.Text = "CUIT";
            this.rbtnCuit.UseVisualStyleBackColor = true;
            // 
            // rbtnCodigoCliente
            // 
            this.rbtnCodigoCliente.AutoSize = true;
            this.rbtnCodigoCliente.Location = new System.Drawing.Point(6, 19);
            this.rbtnCodigoCliente.Name = "rbtnCodigoCliente";
            this.rbtnCodigoCliente.Size = new System.Drawing.Size(108, 17);
            this.rbtnCodigoCliente.TabIndex = 1;
            this.rbtnCodigoCliente.TabStop = true;
            this.rbtnCodigoCliente.Text = "Código de Cliente";
            this.rbtnCodigoCliente.UseVisualStyleBackColor = true;
            // 
            // rbtnNombreRazonSocial
            // 
            this.rbtnNombreRazonSocial.AutoSize = true;
            this.rbtnNombreRazonSocial.Location = new System.Drawing.Point(6, 42);
            this.rbtnNombreRazonSocial.Name = "rbtnNombreRazonSocial";
            this.rbtnNombreRazonSocial.Size = new System.Drawing.Size(137, 17);
            this.rbtnNombreRazonSocial.TabIndex = 0;
            this.rbtnNombreRazonSocial.TabStop = true;
            this.rbtnNombreRazonSocial.Text = "Nombre o Razón Social";
            this.rbtnNombreRazonSocial.UseVisualStyleBackColor = true;
            // 
            // gbxResultados
            // 
            this.gbxResultados.BackColor = System.Drawing.Color.Transparent;
            this.gbxResultados.Controls.Add(this.lblSeleccioneCliente);
            this.gbxResultados.Controls.Add(this.lblSeleccioneDomicilio);
            this.gbxResultados.Controls.Add(this.grdDomicilios);
            this.gbxResultados.Controls.Add(this.grdClientes);
            this.gbxResultados.Location = new System.Drawing.Point(12, 113);
            this.gbxResultados.Name = "gbxResultados";
            this.gbxResultados.Size = new System.Drawing.Size(568, 280);
            this.gbxResultados.TabIndex = 2;
            this.gbxResultados.TabStop = false;
            this.gbxResultados.Text = "Resultados";
            // 
            // lblSeleccioneCliente
            // 
            this.lblSeleccioneCliente.AutoSize = true;
            this.lblSeleccioneCliente.Location = new System.Drawing.Point(6, 19);
            this.lblSeleccioneCliente.Name = "lblSeleccioneCliente";
            this.lblSeleccioneCliente.Size = new System.Drawing.Size(106, 13);
            this.lblSeleccioneCliente.TabIndex = 7;
            this.lblSeleccioneCliente.Text = "Seleccione el Cliente";
            // 
            // lblSeleccioneDomicilio
            // 
            this.lblSeleccioneDomicilio.AutoSize = true;
            this.lblSeleccioneDomicilio.Location = new System.Drawing.Point(6, 155);
            this.lblSeleccioneDomicilio.Name = "lblSeleccioneDomicilio";
            this.lblSeleccioneDomicilio.Size = new System.Drawing.Size(116, 13);
            this.lblSeleccioneDomicilio.TabIndex = 6;
            this.lblSeleccioneDomicilio.Text = "Seleccione el Domicilio";
            // 
            // grdDomicilios
            // 
            this.grdDomicilios.AllowUserToAddRows = false;
            this.grdDomicilios.AllowUserToDeleteRows = false;
            this.grdDomicilios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDomicilios.Location = new System.Drawing.Point(6, 177);
            this.grdDomicilios.MultiSelect = false;
            this.grdDomicilios.Name = "grdDomicilios";
            this.grdDomicilios.ReadOnly = true;
            this.grdDomicilios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdDomicilios.Size = new System.Drawing.Size(556, 92);
            this.grdDomicilios.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(359, 401);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 32);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "       Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(121, 401);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 32);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "       Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmClientesBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(592, 442);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.gbxResultados);
            this.Controls.Add(this.gbxCriteriosBusqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientesBuscador";
            this.Text = "Buscador de Clientes";
            this.Load += new System.EventHandler(this.FrmClientesBuscador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.gbxCriteriosBusqueda.ResumeLayout(false);
            this.gbxCriteriosBusqueda.PerformLayout();
            this.gbxResultados.ResumeLayout(false);
            this.gbxResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDomicilios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.GroupBox gbxCriteriosBusqueda;
        private System.Windows.Forms.GroupBox gbxResultados;
        private System.Windows.Forms.RadioButton rbtnNombreRazonSocial;
        private System.Windows.Forms.RadioButton rbtnCodigoCliente;
        private System.Windows.Forms.RadioButton rbtnCuit;
        private System.Windows.Forms.RadioButton rbtnCondIva;
        private System.Windows.Forms.TextBox txtValorBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblValorBusqueda;
        private System.Windows.Forms.RadioButton rbtnCodPostal;
        private System.Windows.Forms.RadioButton rbtnLocalidad;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblSeleccioneCliente;
        private System.Windows.Forms.Label lblSeleccioneDomicilio;
        private System.Windows.Forms.DataGridView grdDomicilios;
    }
}