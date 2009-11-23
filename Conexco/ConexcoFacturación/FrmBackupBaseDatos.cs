using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class FrmBackupBaseDatos : Form
    {
        public FrmBackupBaseDatos()
        {
            InitializeComponent();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialogCarpetaBackup.ShowDialog();
            if(result == System.Windows.Forms.DialogResult.OK)
            {
                txtDirectorio.Text = folderBrowserDialogCarpetaBackup.SelectedPath;
            }
        }
    }
}
