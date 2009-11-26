namespace ConexcoFacturación
{
    partial class FrmBackupBaseDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupBaseDatos));
            this.folderBrowserDialogCarpetaBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.toolTipBackup = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // folderBrowserDialogCarpetaBackup
            // 
            this.folderBrowserDialogCarpetaBackup.Description = "Seleccione la carpeta donde guardar el archivo Backup";
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(155, 51);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(75, 23);
            this.btnExplorar.TabIndex = 0;
            this.btnExplorar.Text = "Examinar...";
            this.toolTipBackup.SetToolTip(this.btnExplorar, "Busque la carpeta donde quiere hacer la Copia de Seguridad");
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(17, 54);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.ReadOnly = true;
            this.txtDirectorio.Size = new System.Drawing.Size(132, 20);
            this.txtDirectorio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione la carpeta donde quiere hacer la";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "copia de seguridad, luego presione Aceptar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.aceptar;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Location = new System.Drawing.Point(17, 97);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 32);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "       Aceptar";
            this.toolTipBackup.SetToolTip(this.btnAceptar, "Crear Copia de Seguridad");
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::ConexcoFacturación.Properties.Resources.cancelar;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Location = new System.Drawing.Point(143, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(83, 32);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "       Cancelar";
            this.toolTipBackup.SetToolTip(this.btnCancelar, "Cancelar");
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmBackupBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ConexcoFacturación.Properties.Resources.FondoTodos;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(238, 146);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.btnExplorar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBackupBaseDatos";
            this.Text = "Copia de Seguridad";
            this.Load += new System.EventHandler(this.FrmBackupBaseDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCarpetaBackup;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtDirectorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ToolTip toolTipBackup;
    }
}