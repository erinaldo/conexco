using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;
using Conexco.Utils;

namespace ConexcoFacturación
{
    public partial class FrmIngreso : Form
    {
        public ArticulosController ArticulosController { get; set; }
        public int IdArticulo { get; set; }

        public FrmIngreso()
        {
            InitializeComponent();
            if (IdArticulo>0)
                _CargarDatosArticulo();
        }

        private void FromIngreso_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            ArticulosController = new ArticulosController();
            if (IdArticulo > 0)
                _CargarDatosArticulo();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var articulo = new Articulo() 
                                {
                                    idArticulo = IdArticulo,
                                    Stock = Convert.ToDecimal(txtStockActual.Text) + Convert.ToDecimal(txtCantidad.Text)
                                };
            try
            {
                var resultado = ArticulosController.ActualizarStockArticulo(articulo);
                if (resultado)
                {
                    MessageBox.Show(Constants.OK_ACTUALIZAR_STOCK);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                    MessageBox.Show(Constants.ERROR_ACTUALIZAR_STOCK);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el ingreso de stock, verifique los datos");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            codArticulo.Text = articulo.Codigo;
            txtStockActual.Text = articulo.Stock.ToString();
            nombreArticulo.Text = articulo.Descripcion;
        }

        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
