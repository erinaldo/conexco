﻿namespace ConexcoFacturación
{
    partial class FrmLocalidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalidades));
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblNuevaLocalidad = new System.Windows.Forms.Label();
            this.lblCodPostal = new System.Windows.Forms.Label();
            this.lblNuevoCodPostal = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNuevaLocalidad = new System.Windows.Forms.TextBox();
            this.txtNuevoCodPostal = new System.Windows.Forms.TextBox();
            this.lblTCodPostal = new System.Windows.Forms.Label();
            this.toolTipLocalidades = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensajeNuevaLocalidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProvincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(100, 22);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(121, 21);
            this.cmbProvincia.TabIndex = 0;
            this.toolTipLocalidades.SetToolTip(this.cmbProvincia, "Selecciona la Provincia");
            this.cmbProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            this.cmbProvincia.SelectedIndexChanged += new System.EventHandler(this.cmbProvincia_SelectedIndexChanged);
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.BackColor = System.Drawing.Color.Transparent;
            this.lblProvincia.Location = new System.Drawing.Point(33, 24);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 1;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Location = new System.Drawing.Point(31, 60);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 2;
            this.lblLocalidad.Text = "Localidad";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(100, 57);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(121, 21);
            this.cmbLocalidad.Sorted = true;
            this.cmbLocalidad.TabIndex = 1;
            this.toolTipLocalidades.SetToolTip(this.cmbLocalidad, "Seleccione la Localidad");
            this.cmbLocalidad.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            this.cmbLocalidad.SelectedIndexChanged += new System.EventHandler(this.cmbLocalidad_SelectedIndexChanged);
            // 
            // lblMensaje
            // 
            this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
            this.lblMensaje.Location = new System.Drawing.Point(12, 115);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(240, 32);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Si no encuentra la Localidad para la Provincia seleccionada, ingresela aqui:";
            // 
            // lblNuevaLocalidad
            // 
            this.lblNuevaLocalidad.AutoSize = true;
            this.lblNuevaLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaLocalidad.Location = new System.Drawing.Point(34, 159);
            this.lblNuevaLocalidad.Name = "lblNuevaLocalidad";
            this.lblNuevaLocalidad.Size = new System.Drawing.Size(88, 13);
            this.lblNuevaLocalidad.TabIndex = 5;
            this.lblNuevaLocalidad.Text = "Nueva Localidad";
            // 
            // lblCodPostal
            // 
            this.lblCodPostal.AutoSize = true;
            this.lblCodPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblCodPostal.Location = new System.Drawing.Point(100, 91);
            this.lblCodPostal.Name = "lblCodPostal";
            this.lblCodPostal.Size = new System.Drawing.Size(0, 13);
            this.lblCodPostal.TabIndex = 6;
            // 
            // lblNuevoCodPostal
            // 
            this.lblNuevoCodPostal.AutoSize = true;
            this.lblNuevoCodPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevoCodPostal.Location = new System.Drawing.Point(15, 192);
            this.lblNuevoCodPostal.Name = "lblNuevoCodPostal";
            this.lblNuevoCodPostal.Size = new System.Drawing.Size(107, 13);
            this.lblNuevoCodPostal.TabIndex = 7;
            this.lblNuevoCodPostal.Text = "Nuevo Código Postal";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(45, 263);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 30);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(142, 263);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNuevaLocalidad
            // 
            this.txtNuevaLocalidad.Location = new System.Drawing.Point(138, 156);
            this.txtNuevaLocalidad.MaxLength = 100;
            this.txtNuevaLocalidad.Name = "txtNuevaLocalidad";
            this.txtNuevaLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaLocalidad.TabIndex = 2;
            this.toolTipLocalidades.SetToolTip(this.txtNuevaLocalidad, "Ingrese aquí la nueva Localidad");
            this.txtNuevaLocalidad.TextChanged += new System.EventHandler(this.txtNuevaLocalidadCodPostal_TextChanged);
            // 
            // txtNuevoCodPostal
            // 
            this.txtNuevoCodPostal.Location = new System.Drawing.Point(138, 189);
            this.txtNuevoCodPostal.MaxLength = 10;
            this.txtNuevoCodPostal.Name = "txtNuevoCodPostal";
            this.txtNuevoCodPostal.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoCodPostal.TabIndex = 3;
            this.toolTipLocalidades.SetToolTip(this.txtNuevoCodPostal, "Ingrese aquí el nuevo Código Postal");
            this.txtNuevoCodPostal.TextChanged += new System.EventHandler(this.txtNuevaLocalidadCodPostal_TextChanged);
            // 
            // lblTCodPostal
            // 
            this.lblTCodPostal.AutoSize = true;
            this.lblTCodPostal.BackColor = System.Drawing.Color.Transparent;
            this.lblTCodPostal.Location = new System.Drawing.Point(12, 91);
            this.lblTCodPostal.Name = "lblTCodPostal";
            this.lblTCodPostal.Size = new System.Drawing.Size(72, 13);
            this.lblTCodPostal.TabIndex = 12;
            this.lblTCodPostal.Text = "Código Postal";
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // lblMensajeNuevaLocalidad
            // 
            this.lblMensajeNuevaLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeNuevaLocalidad.Location = new System.Drawing.Point(12, 217);
            this.lblMensajeNuevaLocalidad.Name = "lblMensajeNuevaLocalidad";
            this.lblMensajeNuevaLocalidad.Size = new System.Drawing.Size(240, 32);
            this.lblMensajeNuevaLocalidad.TabIndex = 13;
            this.lblMensajeNuevaLocalidad.Text = "Una vez agregada la nueva Localidad, podrá seleccionarla en futuras búsquedas";
            this.lblMensajeNuevaLocalidad.Visible = false;
            // 
            // FrmLocalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(268, 310);
            this.Controls.Add(this.lblMensajeNuevaLocalidad);
            this.Controls.Add(this.lblTCodPostal);
            this.Controls.Add(this.txtNuevoCodPostal);
            this.Controls.Add(this.txtNuevaLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNuevoCodPostal);
            this.Controls.Add(this.lblCodPostal);
            this.Controls.Add(this.lblNuevaLocalidad);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.cmbLocalidad);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblProvincia);
            this.Controls.Add(this.cmbProvincia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLocalidades";
            this.Text = "Seleccionar Localidad";
            this.Load += new System.EventHandler(this.FrmLocalidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblNuevaLocalidad;
        private System.Windows.Forms.Label lblCodPostal;
        private System.Windows.Forms.Label lblNuevoCodPostal;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNuevaLocalidad;
        private System.Windows.Forms.TextBox txtNuevoCodPostal;
        private System.Windows.Forms.Label lblTCodPostal;
        private System.Windows.Forms.ToolTip toolTipLocalidades;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
        private System.Windows.Forms.Label lblMensajeNuevaLocalidad;
    }
}