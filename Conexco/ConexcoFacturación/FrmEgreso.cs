using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

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
            var egresoArticulo = new Egreso_Stock()
                                     {
                                         Cantidad = Convert.ToDecimal(txtCantidad.Text),
                                         FechaEgreso = DateTime.Now,
                                         Motivo = ddlMotivos.SelectedText,
                                         idArticulo = IdArticulo
                                     };
            var resultado = StockController.EgresoStockArticulo(egresoArticulo);
            
            if (resultado)
            {
                MessageBox.Show("Egreso guardado satisfactoriamente");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al guardar el Egreso, intentelo de nuevo");
            }
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            codArticulo.Text = articulo.Codigo;
            nombreArticulo.Text = articulo.Descripcion;
            ddlMotivos.DataSource = StockController.ListadoMotivosEgreso();
        }
    }
}
