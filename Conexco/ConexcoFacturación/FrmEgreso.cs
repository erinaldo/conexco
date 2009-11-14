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
    public partial class FrmEgreso : Form
    {
        public StockController StockController { get; set; }
        public ArticulosController ArticulosController { get; set; }
        public string IdArticulo { get; set; }

        public FrmEgreso()
        {
            InitializeComponent();
        }

        private void FrmEgreso_Load(object sender, EventArgs e)
        {
            StockController = new StockController();
            ArticulosController = new ArticulosController();
        }
    }
}
