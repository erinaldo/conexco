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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxTransportista = new System.Windows.Forms.GroupBox();
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtInfoAdicional = new System.Windows.Forms.TextBox();
            this.gbxTransportista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportistas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(117, 321);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(453, 321);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(359, 321);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(275, 321);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(201, 321);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 23);
            this.btnNuevo.TabIndex = 27;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxTransportista
            // 
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
            this.gbxTransportista.Size = new System.Drawing.Size(517, 158);
            this.gbxTransportista.TabIndex = 26;
            this.gbxTransportista.TabStop = false;
            this.gbxTransportista.Text = "Detalle";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.Location = new System.Drawing.Point(385, 51);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(25, 23);
            this.btnLocalidad.TabIndex = 47;
            this.btnLocalidad.Text = "...";
            this.btnLocalidad.UseVisualStyleBackColor = true;
            this.btnLocalidad.Click += new System.EventHandler(this.btnLocalidad_Click);
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(279, 51);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(100, 21);
            this.cmbProvincia.Sorted = true;
            this.cmbProvincia.TabIndex = 46;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(198, 33);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 26;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(279, 26);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(100, 20);
            this.txtDomicilio.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(198, 83);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 41;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(279, 76);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 1;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(198, 55);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 43;
            this.lblProvincia.Text = "Provincia";
            // 
            // txtCodPostal
            // 
            this.txtCodPostal.Location = new System.Drawing.Point(279, 104);
            this.txtCodPostal.Name = "txtCodPostal";
            this.txtCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtCodPostal.TabIndex = 3;
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.Location = new System.Drawing.Point(198, 111);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblCodPostal.TabIndex = 45;
            this.lblCodPostal.Text = "Codigo Postal";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(129, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 25;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
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
            this.gridTransportistas.Size = new System.Drawing.Size(517, 83);
            this.gridTransportistas.TabIndex = 23;
            this.gridTransportistas.SelectionChanged += new System.EventHandler(this.gridTransportistas_SelectionChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 50;
            this.lblNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Telefono";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Información Adicional";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(59, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 53;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(59, 53);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 54;
            // 
            // txtInfoAdicional
            // 
            this.txtInfoAdicional.Location = new System.Drawing.Point(13, 97);
            this.txtInfoAdicional.Multiline = true;
            this.txtInfoAdicional.Name = "txtInfoAdicional";
            this.txtInfoAdicional.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInfoAdicional.Size = new System.Drawing.Size(156, 47);
            this.txtInfoAdicional.TabIndex = 55;
            // 
            // FrmClientesTransportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 363);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxTransportista);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gridTransportistas);
            this.Name = "FrmClientesTransportistas";
            this.Text = "Transportistas del cliente";
            this.Load += new System.EventHandler(this.FrmClientesTransportistas_Load);
            this.gbxTransportista.ResumeLayout(false);
            this.gbxTransportista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTransportistas)).EndInit();
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
    }
}