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
    public partial class FrmArticulosStock : Form
    {
        public FrmArticulosStock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulos_Stock stock = new Articulos_Stock();
            stock.idArticulo = Convert.ToInt32(textBox1.Text);
            stock.Stock = Convert.ToInt32(textBox2.Text);
            ArticulosController articulosController = new ArticulosController();
            articulosController.IngresoStock(stock);
        }
    }
}
