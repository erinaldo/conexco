using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;
using Conexco.Utils;

namespace ConexcoFacturación
{
    public partial class FrmEgreso : Form
    {
        public StockController StockController { get; set; }
        public ArticulosController ArticulosController { get; set; }
        public int IdArticulo { get; set; }

        public FrmEgreso()
        {
            InitializeComponent();
        }

        private void FrmEgreso_Load(object sender, EventArgs e)
        {
            StockController = new StockController();
            ArticulosController = new ArticulosController();
            if (IdArticulo>0)
                _CargarDatosArticulo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text))
            {
                errorProvider1.SetError(txtCantidad,"Ingrese cantidad.");
                return;
            }

            var stockActual = Convert.ToDecimal(txtStockActual.Text);
            var stockEgreso = Convert.ToDecimal(txtCantidad.Text);

            if (stockActual < stockEgreso)
            {
                MessageBox.Show(Constants.ERROR_STOCK_INSUFICIENTE);
                return;
            }

            var egresoArticulo = new Egreso_Stock()
                                     {
                                         Cantidad = stockEgreso,
                                         FechaEgreso = DateTime.Now,
                                         Motivo = ddlMotivos.SelectedText,
                                         idArticulo = IdArticulo
                                     };
            var articulo = new Articulo(){
                                            idArticulo = IdArticulo,
                                            Stock = Convert.ToDecimal(txtStockActual.Text) - Convert.ToDecimal(txtCantidad.Text)
                                         };

            try
            {
                var resultadoArticuloGuardado = ArticulosController.ActualizarStockArticulo(articulo);
                var resultadoEgreso = StockController.EgresoStockArticulo(egresoArticulo);

                if (resultadoArticuloGuardado && resultadoEgreso)
                {
                    MessageBox.Show(Constants.OK_EGRESO_STOCK);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show(Constants.ERROR_EGRESO_STOCK);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el egreso de stock, verifique los datos");
                this.Close();
            }
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            codArticulo.Text = articulo.Codigo;
            nombreArticulo.Text = articulo.Descripcion;
            txtStockActual.Text = articulo.Stock.ToString();
            ddlMotivos.DataSource = StockController.ListadoMotivosEgreso();
        }

        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '.')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
