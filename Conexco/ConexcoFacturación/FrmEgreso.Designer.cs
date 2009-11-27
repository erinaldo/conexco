namespace ConexcoFacturación
{
    partial class FrmEgreso
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
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEgresoMotivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.codArticulo = new System.Windows.Forms.TextBox();
            this.nombreArticulo = new System.Windows.Forms.TextBox();
            this.ddlMotivos = new System.Windows.Forms.ComboBox();
            this.txtStockActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.BackColor = System.Drawing.Color.Transparent;
            this.lblCodArticulo.Location = new System.Drawing.Point(37, 39);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(81, 13);
            this.lblCodArticulo.TabIndex = 0;
            this.lblCodArticulo.Text = "Código Articulo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(37, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre Articulo:";
            // 
            // lblEgresoMotivo
            // 
            this.lblEgresoMotivo.AutoSize = true;
            this.lblEgresoMotivo.BackColor = System.Drawing.Color.Transparent;
            this.lblEgresoMotivo.Location = new System.Drawing.Point(37, 108);
            this.lblEgresoMotivo.Name = "lblEgresoMotivo";
            this.lblEgresoMotivo.Size = new System.Drawing.Size(78, 13);
            this.lblEgresoMotivo.TabIndex = 2;
            this.lblEgresoMotivo.Text = "Motivo Egreso:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cantidad a Quitar:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(66, 219);
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
            this.btnCancelar.Location = new System.Drawing.Point(147, 219);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // codArticulo
            // 
            this.codArticulo.Location = new System.Drawing.Point(134, 31);
            this.codArticulo.Name = "codArticulo";
            this.codArticulo.ReadOnly = true;
            this.codArticulo.Size = new System.Drawing.Size(100, 20);
            this.codArticulo.TabIndex = 6;
            // 
            // nombreArticulo
            // 
            this.nombreArticulo.Location = new System.Drawing.Point(134, 68);
            this.nombreArticulo.Name = "nombreArticulo";
            this.nombreArticulo.ReadOnly = true;
            this.nombreArticulo.Size = new System.Drawing.Size(100, 20);
            this.nombreArticulo.TabIndex = 7;
            // 
            // ddlMotivos
            // 
            this.ddlMotivos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlMotivos.FormattingEnabled = true;
            this.ddlMotivos.Location = new System.Drawing.Point(134, 101);
            this.ddlMotivos.Name = "ddlMotivos";
            this.ddlMotivos.Size = new System.Drawing.Size(121, 21);
            this.ddlMotivos.TabIndex = 9;
            // 
            // txtStockActual
            // 
            this.txtStockActual.Location = new System.Drawing.Point(134, 132);
            this.txtStockActual.Name = "txtStockActual";
            this.txtStockActual.ReadOnly = true;
            this.txtStockActual.Size = new System.Drawing.Size(100, 20);
            this.txtStockActual.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(37, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Stock Actual:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(135, 163);
            this.txtCantidad.MaxLength = 10;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 12;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosDecimales_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtStockActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ddlMotivos);
            this.Controls.Add(this.nombreArticulo);
            this.Controls.Add(this.codArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEgresoMotivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCodArticulo);
            this.Name = "FrmEgreso";
            this.Text = "Egreso Stock Artículo";
            this.Load += new System.EventHandler(this.FrmEgreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEgresoMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox codArticulo;
        private System.Windows.Forms.TextBox nombreArticulo;
        private System.Windows.Forms.ComboBox ddlMotivos;
        private System.Windows.Forms.TextBox txtStockActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}