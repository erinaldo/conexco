using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmListadoFacturas : Form
    {
        FacturasController FacturasController { get; set; }
        public FrmListadoFacturas()
        {
            FacturasController = new FacturasController();
            InitializeComponent();
        }

        private void CheckedCriterioFiltroChange(object sender, EventArgs e)
        {
            var objectId = ((RadioButton) sender).Name;
            var dataSourceGrilla = new List<Factura>();
            
            switch (objectId)
            {
                case "rdTodas":
                    dataSourceGrilla = FacturasController.ListarFacturas(String.Empty);
                    break;
                case "rdPagadas":
                    dataSourceGrilla = FacturasController.ListarFacturas("Pagado");
                    break;
                case "rdPendientes":
                    dataSourceGrilla = FacturasController.ListarFacturas("Pendiente");
                    break;
                case "rdAnuladas":
                    dataSourceGrilla = FacturasController.ListarFacturas("Anulado");
                    break;
            }

            _RecargarGrilla(dataSourceGrilla);
        }

        private void _RecargarGrilla(List<Factura> facturas)
        {
            gridFacturas.DataSource = facturas;
            gridFacturas.Columns[1].Visible = false;
            gridFacturas.Columns[3].Visible = false;
            gridFacturas.Columns[5].Visible = false;
            gridFacturas.Columns[6].Visible = false;
            gridFacturas.Columns[8].Visible = false;
            gridFacturas.Columns[9].Visible = false;
            gridFacturas.Columns[10].Visible = false;
            gridFacturas.Columns[11].Visible = false;
            gridFacturas.Columns[12].Visible = false;
            gridFacturas.Columns[13].Visible = false;
            gridFacturas.Columns[14].Visible = false;
            gridFacturas.Columns[15].Visible = false;
            gridFacturas.Columns[16].Visible = false;
            gridFacturas.Columns[17].Visible = false;
            gridFacturas.Columns[18].Visible = false;
        }
    }
}
