namespace ConexcoFacturación
{
    partial class FrmClientesContactos
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
            this.gbxContactos = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grdContactos = new System.Windows.Forms.DataGridView();
            this.gbxContactos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(91, 150);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(427, 150);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 39;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(333, 150);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 38;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(249, 150);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(175, 150);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(65, 23);
            this.btnNuevo.TabIndex = 36;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxContactos
            // 
            this.gbxContactos.Controls.Add(this.lblNombre);
            this.gbxContactos.Controls.Add(this.txtNombre);
            this.gbxContactos.Controls.Add(this.lblEmail);
            this.gbxContactos.Controls.Add(this.txtEmail);
            this.gbxContactos.Enabled = false;
            this.gbxContactos.Location = new System.Drawing.Point(287, 46);
            this.gbxContactos.Name = "gbxContactos";
            this.gbxContactos.Size = new System.Drawing.Size(215, 84);
            this.gbxContactos.TabIndex = 35;
            this.gbxContactos.TabStop = false;
            this.gbxContactos.Text = "Detalle";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 52);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 13);
            this.lblEmail.TabIndex = 41;
            this.lblEmail.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 45);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(129, 21);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(0, 13);
            this.lblCliente.TabIndex = 34;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(12, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 13);
            this.lblTitulo.TabIndex = 33;
            this.lblTitulo.Text = "Contactos del cliente: ";
            // 
            // grdContactos
            // 
            this.grdContactos.AllowUserToAddRows = false;
            this.grdContactos.AllowUserToDeleteRows = false;
            this.grdContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdContactos.Location = new System.Drawing.Point(12, 46);
            this.grdContactos.MultiSelect = false;
            this.grdContactos.Name = "grdContactos";
            this.grdContactos.ReadOnly = true;
            this.grdContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdContactos.Size = new System.Drawing.Size(243, 84);
            this.grdContactos.TabIndex = 32;
            this.grdContactos.SelectionChanged += new System.EventHandler(this.grdContactos_SelectionChanged);
            // 
            // FrmClientesContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 186);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.gbxContactos);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.grdContactos);
            this.Name = "FrmClientesContactos";
            this.Text = "Contactos del cliente";
            this.Load += new System.EventHandler(this.FrmClientesContactos_Load);
            this.gbxContactos.ResumeLayout(false);
            this.gbxContactos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContactos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox gbxContactos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView grdContactos;
    }
}