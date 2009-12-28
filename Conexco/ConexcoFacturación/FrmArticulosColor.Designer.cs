namespace ConexcoFacturación
{
    partial class FrmArticulosColor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticulosColor));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreColor = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxNuevoColor = new System.Windows.Forms.GroupBox();
            this.gbxColoresExistentes = new System.Windows.Forms.GroupBox();
            this.grdColoresExistentes = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbxNuevoColor.SuspendLayout();
            this.gbxColoresExistentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColoresExistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtNombreColor
            // 
            this.txtNombreColor.Location = new System.Drawing.Point(97, 87);
            this.txtNombreColor.MaxLength = 20;
            this.txtNombreColor.Name = "txtNombreColor";
            this.txtNombreColor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreColor.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.guardar3png;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuardar.Location = new System.Drawing.Point(27, 141);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 30);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(108, 141);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(77, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.OnCancel);
            // 
            // txtCodColor
            // 
            this.txtCodColor.Location = new System.Drawing.Point(97, 58);
            this.txtCodColor.MaxLength = 10;
            this.txtCodColor.Name = "txtCodColor";
            this.txtCodColor.Size = new System.Drawing.Size(100, 20);
            this.txtCodColor.TabIndex = 0;
            this.txtCodColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SinGuion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Código Color:";
            // 
            // gbxNuevoColor
            // 
            this.gbxNuevoColor.BackColor = System.Drawing.Color.Transparent;
            this.gbxNuevoColor.Controls.Add(this.txtCodColor);
            this.gbxNuevoColor.Controls.Add(this.label1);
            this.gbxNuevoColor.Controls.Add(this.label3);
            this.gbxNuevoColor.Controls.Add(this.txtNombreColor);
            this.gbxNuevoColor.Controls.Add(this.btnCancelar);
            this.gbxNuevoColor.Controls.Add(this.btnGuardar);
            this.gbxNuevoColor.Location = new System.Drawing.Point(12, 12);
            this.gbxNuevoColor.Name = "gbxNuevoColor";
            this.gbxNuevoColor.Size = new System.Drawing.Size(214, 177);
            this.gbxNuevoColor.TabIndex = 0;
            this.gbxNuevoColor.TabStop = false;
            this.gbxNuevoColor.Text = "Nuevo Color";
            // 
            // gbxColoresExistentes
            // 
            this.gbxColoresExistentes.BackColor = System.Drawing.Color.Transparent;
            this.gbxColoresExistentes.Controls.Add(this.btnEliminar);
            this.gbxColoresExistentes.Controls.Add(this.grdColoresExistentes);
            this.gbxColoresExistentes.Location = new System.Drawing.Point(247, 12);
            this.gbxColoresExistentes.Name = "gbxColoresExistentes";
            this.gbxColoresExistentes.Size = new System.Drawing.Size(260, 177);
            this.gbxColoresExistentes.TabIndex = 1;
            this.gbxColoresExistentes.TabStop = false;
            this.gbxColoresExistentes.Text = "Colores Existentes";
            // 
            // grdColoresExistentes
            // 
            this.grdColoresExistentes.AllowUserToAddRows = false;
            this.grdColoresExistentes.AllowUserToDeleteRows = false;
            this.grdColoresExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdColoresExistentes.Location = new System.Drawing.Point(9, 15);
            this.grdColoresExistentes.MultiSelect = false;
            this.grdColoresExistentes.Name = "grdColoresExistentes";
            this.grdColoresExistentes.ReadOnly = true;
            this.grdColoresExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdColoresExistentes.Size = new System.Drawing.Size(243, 116);
            this.grdColoresExistentes.TabIndex = 0;
            this.grdColoresExistentes.SelectionChanged += new System.EventHandler(this.grdColoresExistentes_SelectionChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.eliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(177, 141);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 30);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmArticulosColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(519, 201);
            this.Controls.Add(this.gbxColoresExistentes);
            this.Controls.Add(this.gbxNuevoColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmArticulosColor";
            this.Text = "Agregar Color";
            this.Load += new System.EventHandler(this.FrmArticulosColor_Load);
            this.gbxNuevoColor.ResumeLayout(false);
            this.gbxNuevoColor.PerformLayout();
            this.gbxColoresExistentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdColoresExistentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreColor;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbxNuevoColor;
        private System.Windows.Forms.GroupBox gbxColoresExistentes;
        private System.Windows.Forms.DataGridView grdColoresExistentes;
        private System.Windows.Forms.Button btnEliminar;
    }
}