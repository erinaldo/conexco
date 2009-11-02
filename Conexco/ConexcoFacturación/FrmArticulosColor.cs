using System;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class FrmArticulosColor : Form
    {
        public FrmArticulosColor()
        {
            InitializeComponent();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }
    }
}
