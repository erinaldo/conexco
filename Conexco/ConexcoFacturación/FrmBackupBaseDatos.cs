using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ConexcoFacturación.Properties;

namespace ConexcoFacturación
{
    public partial class FrmBackupBaseDatos : Form
    {
        public FrmBackupBaseDatos()
        {
            InitializeComponent();
        }

        private void FrmBackupBaseDatos_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialogCarpetaBackup.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectorio.Text = folderBrowserDialogCarpetaBackup.SelectedPath;
                btnAceptar.Enabled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var directorio = (txtDirectorio.Text.EndsWith(@"\"))
                                 ? txtDirectorio.Text + "Conexco Backup.bak"
                                 : txtDirectorio.Text + "\\Conexco Backup.bak";
            string sBackup = "BACKUP DATABASE Conexco" +
                 " TO DISK = N'" + directorio +
                 "' WITH NOFORMAT, NOINIT, NAME =N'Conexco " + DateTime.Now.ToShortDateString() +
                 " -Full Database Backup',SKIP, STATS = 10";
            
            using (var con = new SqlConnection(Settings.Default.ConexcoConnectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmdBackUp = new SqlCommand(sBackup, con);

                    cmdBackUp.ExecuteNonQuery();

                    MessageBox.Show("Se ha creado una Copia de Seguridad de La base de datos satisfactoriamente",
                                    "Copia de seguridad de base de datos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Se produjo un error en la copia de seguridad, compruebe que el directorio seleccionado es correcto (Nota: El escritorio ni el directorio raíz (C:\) son directorios válidos. Ej directorio válido: 'C:\Nueva Carpeta')",
                                    "Error al copiar la base de datos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}
