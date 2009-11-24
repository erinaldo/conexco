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
    public partial class FrmPresupuesto : Form
    {
        public FrmPresupuesto()
        {
            InitializeComponent();
        }

        private void FrmPresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Realmente desea Salir? Se perderán los cambios no guardados", "Atención",
                             MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
