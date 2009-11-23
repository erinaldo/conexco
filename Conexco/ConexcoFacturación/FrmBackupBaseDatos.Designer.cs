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
            this.folderBrowserDialogCarpetaBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExplorar = new System.Windows.Forms.Button();
            this.txtDirectorio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialogCarpetaBackup
            // 
            this.folderBrowserDialogCarpetaBackup.Description = "Seleccione la carpeta donde guardar el archivo Backup";
            // 
            // btnExplorar
            // 
            this.btnExplorar.Location = new System.Drawing.Point(174, 32);
            this.btnExplorar.Name = "btnExplorar";
            this.btnExplorar.Size = new System.Drawing.Size(75, 23);
            this.btnExplorar.TabIndex = 0;
            this.btnExplorar.Text = "Explorar...";
            this.btnExplorar.UseVisualStyleBackColor = true;
            this.btnExplorar.Click += new System.EventHandler(this.btnExplorar_Click);
            // 
            // txtDirectorio
            // 
            this.txtDirectorio.Location = new System.Drawing.Point(68, 34);
            this.txtDirectorio.Name = "txtDirectorio";
            this.txtDirectorio.Size = new System.Drawing.Size(100, 20);
            this.txtDirectorio.TabIndex = 1;
            // 
            // FrmBackupBaseDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.txtDirectorio);
            this.Controls.Add(this.btnExplorar);
            this.Name = "FrmBackupBaseDatos";
            this.Text = "FrmBackupBaseDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogCarpetaBackup;
        private System.Windows.Forms.Button btnExplorar;
        private System.Windows.Forms.TextBox txtDirectorio;
    }
}