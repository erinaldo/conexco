using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexco.Controller;

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

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _CargarDatosArticulo()
        {
            var articulo = ArticulosController.DatosArticuloPorCodigo(IdArticulo);
            codArticulo.Text = articulo.Codigo;
            nombreArticulo.Text = articulo.Codigo;
        }
    }
}
