using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmArticulosColor : Form
    {
        public string NombreColorSeleccionado { get; set; }
        public string CodigoColorSeleccionado { get; set; }
        public ArticulosController ArticulosController { get; set; }

        public FrmArticulosColor()
        {
            InitializeComponent();
            ArticulosController = new ArticulosController();
        }

        private void OnCancel(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var colorNuevo = new Articulos_Color();

            NombreColorSeleccionado = txtNombreColor.Text;
            CodigoColorSeleccionado = txtCodColor.Text;


            colorNuevo.Codigo = txtCodColor.Text;
            colorNuevo.Descripcion = txtNombreColor.Text;
            colorNuevo.RGB = HexConverter(this.colorDialog1.Color);
            colorNuevo.R = 0;
            colorNuevo.G = 0;
            colorNuevo.B = 0;

            if (ArticulosController.DatosArticuloColorPorCodigoColor(txtCodColor.Text) == null)
            {
                var resultado = ArticulosController.GuardarColor(colorNuevo);

                if (resultado)
                {
                    MessageBox.Show("El color se ha guardado correctamente.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show("Error al intentar guardar el color!");
            }
            else
                MessageBox.Show("El Código de Color ya existe");

        }

        private void SinGuion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
                e.Handled = true;
        }

        private void FrmArticulosColor_Load(object sender, EventArgs e)
        {
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grdColoresExistentes.DataSource = ArticulosController.ListarColoresObjeto();
            grdColoresExistentes.Columns[0].Visible = false;
            grdColoresExistentes.Columns[3].Visible = false;
            grdColoresExistentes.Columns[4].Visible = false;
            grdColoresExistentes.Columns[5].Visible = false;
            grdColoresExistentes.Columns[6].Visible = false;
            grdColoresExistentes.Columns[7].Visible = false;

            grdColoresExistentes.Columns[1].HeaderText = "Código";
            grdColoresExistentes.Columns[2].HeaderText = "Descripción";
        }

        private void grdColoresExistentes_SelectionChanged(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Al eliminar un color se mantendrá en todos los articulos que lo utilicen hasta el momento, pero no podrá utilizarse nuevamente. Esta seguro?",
                             "Atención", MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            int idColor = Convert.ToInt32(grdColoresExistentes.SelectedRows[0].Cells[0].Value);
            if(ArticulosController.EliminarArticulosColor(idColor))
            {
                MessageBox.Show("Color eliminado correctamente");
                RefrescarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el color, inténtelo nuevamente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var result = this.colorDialog1.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.btnColor.BackColor = this.colorDialog1.Color;
            }
        }

        private static String HexConverter(System.Drawing.Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }

            return rtn;
        }
    }
}
