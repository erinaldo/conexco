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
            string sBackup = "BACKUP DATABASE Conexco" +
                 " TO DISK = N'" + txtDirectorio.Text + "\\Conexco Backup.bak" +
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
                    MessageBox.Show(ex.Message,
                                    "Error al copiar la base de datos",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
