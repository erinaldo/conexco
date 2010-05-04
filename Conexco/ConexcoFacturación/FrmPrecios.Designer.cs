namespace ConexcoFacturación
{
    partial class FrmPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrecios));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTipLocalidades = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderRequerido = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMensajeNuevaLocalidad = new System.Windows.Forms.Label();
            this.gbSigno = new System.Windows.Forms.GroupBox();
            this.rbtnDisminucion = new System.Windows.Forms.RadioButton();
            this.rbtnAumento = new System.Windows.Forms.RadioButton();
            this.gbValor = new System.Windows.Forms.GroupBox();
            this.rbtnPorcentaje = new System.Windows.Forms.RadioButton();
            this.rbtnPesos = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValorAplicar = new System.Windows.Forms.Label();
            this.lblSigno = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblMensajePesos = new System.Windows.Forms.Label();
            this.lblMensajePesos2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).BeginInit();
            this.gbSigno.SuspendLayout();
            this.gbValor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(90, 201);
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
            this.btnCancelar.Location = new System.Drawing.Point(187, 201);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(79, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // errorProviderRequerido
            // 
            this.errorProviderRequerido.ContainerControl = this;
            // 
            // lblMensajeNuevaLocalidad
            // 
            this.lblMensajeNuevaLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajeNuevaLocalidad.Location = new System.Drawing.Point(12, 9);
            this.lblMensajeNuevaLocalidad.Name = "lblMensajeNuevaLocalidad";
            this.lblMensajeNuevaLocalidad.Size = new System.Drawing.Size(324, 32);
            this.lblMensajeNuevaLocalidad.TabIndex = 13;
            this.lblMensajeNuevaLocalidad.Text = "Desde esta sección, se puede aumentar o disminuir el precio de TODOS los articulo" +
                "s.";
            // 
            // gbSigno
            // 
            this.gbSigno.BackColor = System.Drawing.Color.Transparent;
            this.gbSigno.Controls.Add(this.rbtnDisminucion);
            this.gbSigno.Controls.Add(this.rbtnAumento);
            this.gbSigno.Location = new System.Drawing.Point(12, 48);
            this.gbSigno.Name = "gbSigno";
            this.gbSigno.Size = new System.Drawing.Size(200, 74);
            this.gbSigno.TabIndex = 14;
            this.gbSigno.TabStop = false;
            this.gbSigno.Text = "Tipo de modificación";
            // 
            // rbtnDisminucion
            // 
            this.rbtnDisminucion.AutoSize = true;
            this.rbtnDisminucion.Location = new System.Drawing.Point(19, 43);
            this.rbtnDisminucion.Name = "rbtnDisminucion";
            this.rbtnDisminucion.Size = new System.Drawing.Size(134, 17);
            this.rbtnDisminucion.TabIndex = 1;
            this.rbtnDisminucion.Text = "Disminución de precios";
            this.rbtnDisminucion.UseVisualStyleBackColor = true;
            this.rbtnDisminucion.CheckedChanged += new System.EventHandler(this.rbtnDisminucion_CheckedChanged);
            // 
            // rbtnAumento
            // 
            this.rbtnAumento.AutoSize = true;
            this.rbtnAumento.Checked = true;
            this.rbtnAumento.Location = new System.Drawing.Point(19, 20);
            this.rbtnAumento.Name = "rbtnAumento";
            this.rbtnAumento.Size = new System.Drawing.Size(119, 17);
            this.rbtnAumento.TabIndex = 0;
            this.rbtnAumento.TabStop = true;
            this.rbtnAumento.Text = "Aumento de precios";
            this.rbtnAumento.UseVisualStyleBackColor = true;
            this.rbtnAumento.CheckedChanged += new System.EventHandler(this.rbtnAumento_CheckedChanged);
            // 
            // gbValor
            // 
            this.gbValor.BackColor = System.Drawing.Color.Transparent;
            this.gbValor.Controls.Add(this.rbtnPorcentaje);
            this.gbValor.Controls.Add(this.rbtnPesos);
            this.gbValor.Location = new System.Drawing.Point(227, 48);
            this.gbValor.Name = "gbValor";
            this.gbValor.Size = new System.Drawing.Size(109, 74);
            this.gbValor.TabIndex = 15;
            this.gbValor.TabStop = false;
            this.gbValor.Text = "Tipo de valor";
            // 
            // rbtnPorcentaje
            // 
            this.rbtnPorcentaje.AutoSize = true;
            this.rbtnPorcentaje.Checked = true;
            this.rbtnPorcentaje.Location = new System.Drawing.Point(19, 20);
            this.rbtnPorcentaje.Name = "rbtnPorcentaje";
            this.rbtnPorcentaje.Size = new System.Drawing.Size(76, 17);
            this.rbtnPorcentaje.TabIndex = 1;
            this.rbtnPorcentaje.TabStop = true;
            this.rbtnPorcentaje.Text = "Porcentaje";
            this.rbtnPorcentaje.UseVisualStyleBackColor = true;
            this.rbtnPorcentaje.CheckedChanged += new System.EventHandler(this.rbtnPorcentaje_CheckedChanged);
            // 
            // rbtnPesos
            // 
            this.rbtnPesos.AutoSize = true;
            this.rbtnPesos.Location = new System.Drawing.Point(19, 43);
            this.rbtnPesos.Name = "rbtnPesos";
            this.rbtnPesos.Size = new System.Drawing.Size(54, 17);
            this.rbtnPesos.TabIndex = 0;
            this.rbtnPesos.Text = "Pesos";
            this.rbtnPesos.UseVisualStyleBackColor = true;
            this.rbtnPesos.CheckedChanged += new System.EventHandler(this.rbtnPesos_CheckedChanged);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(200, 166);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 16;
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SoloNumerosDecimales_KeyPress);
            this.txtValor.Validating += new System.ComponentModel.CancelEventHandler(this.CampoRequerido_Validating);
            // 
            // lblValorAplicar
            // 
            this.lblValorAplicar.AutoSize = true;
            this.lblValorAplicar.BackColor = System.Drawing.Color.Transparent;
            this.lblValorAplicar.Location = new System.Drawing.Point(56, 169);
            this.lblValorAplicar.Name = "lblValorAplicar";
            this.lblValorAplicar.Size = new System.Drawing.Size(77, 13);
            this.lblValorAplicar.TabIndex = 17;
            this.lblValorAplicar.Text = "Valor a aplicar:";
            // 
            // lblSigno
            // 
            this.lblSigno.AutoSize = true;
            this.lblSigno.BackColor = System.Drawing.Color.Transparent;
            this.lblSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigno.Location = new System.Drawing.Point(147, 162);
            this.lblSigno.Name = "lblSigno";
            this.lblSigno.Size = new System.Drawing.Size(21, 24);
            this.lblSigno.TabIndex = 18;
            this.lblSigno.Text = "+";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(169, 162);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(25, 24);
            this.lblTipo.TabIndex = 19;
            this.lblTipo.Text = "%";
            // 
            // lblMensajePesos
            // 
            this.lblMensajePesos.AutoSize = true;
            this.lblMensajePesos.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajePesos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensajePesos.Location = new System.Drawing.Point(15, 129);
            this.lblMensajePesos.Name = "lblMensajePesos";
            this.lblMensajePesos.Size = new System.Drawing.Size(315, 13);
            this.lblMensajePesos.TabIndex = 20;
            this.lblMensajePesos.Text = "ATENCION: Al disminuir los precios por pesos, NO se modificarán";
            this.lblMensajePesos.Visible = false;
            // 
            // lblMensajePesos2
            // 
            this.lblMensajePesos2.AutoSize = true;
            this.lblMensajePesos2.BackColor = System.Drawing.Color.Transparent;
            this.lblMensajePesos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensajePesos2.Location = new System.Drawing.Point(14, 144);
            this.lblMensajePesos2.Name = "lblMensajePesos2";
            this.lblMensajePesos2.Size = new System.Drawing.Size(324, 13);
            this.lblMensajePesos2.TabIndex = 21;
            this.lblMensajePesos2.Text = "los valores de los Articulos que tengan un menor valor al ingresado.";
            this.lblMensajePesos2.Visible = false;
            // 
            // FrmPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(357, 255);
            this.Controls.Add(this.lblMensajePesos2);
            this.Controls.Add(this.lblMensajePesos);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblSigno);
            this.Controls.Add(this.lblValorAplicar);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.gbValor);
            this.Controls.Add(this.gbSigno);
            this.Controls.Add(this.lblMensajeNuevaLocalidad);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrecios";
            this.Text = "Modificador de Precios";
            this.Load += new System.EventHandler(this.FrmPrecios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderRequerido)).EndInit();
            this.gbSigno.ResumeLayout(false);
            this.gbSigno.PerformLayout();
            this.gbValor.ResumeLayout(false);
            this.gbValor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTipLocalidades;
        private System.Windows.Forms.ErrorProvider errorProviderRequerido;
        private System.Windows.Forms.Label lblMensajeNuevaLocalidad;
        private System.Windows.Forms.GroupBox gbValor;
        private System.Windows.Forms.RadioButton rbtnPorcentaje;
        private System.Windows.Forms.RadioButton rbtnPesos;
        private System.Windows.Forms.GroupBox gbSigno;
        private System.Windows.Forms.RadioButton rbtnDisminucion;
        private System.Windows.Forms.RadioButton rbtnAumento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSigno;
        private System.Windows.Forms.Label lblValorAplicar;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblMensajePesos;
        private System.Windows.Forms.Label lblMensajePesos2;
    }
}