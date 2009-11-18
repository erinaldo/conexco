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
    }
}
