using System;
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
            
            
            switch (objectId)
            {
                case "rdTodas":
                    _ActualizarGrillaFacturas(String.Empty);
                    break;
                case "rdPagadas":
                    _ActualizarGrillaFacturas("Pagado");
                    break;
                case "rdPendientes":
                    _ActualizarGrillaFacturas("Pendiente");
                    break;
                case "rdAnuladas":
                    _ActualizarGrillaFacturas("Anulado");
                    break;
            }

            
        }

        private void _ActualizarGrillaFacturas(string estado)
        {
            var dataSourceGrilla = FacturasController.ListarFacturas(estado);
            gridFacturas.DataSource = dataSourceGrilla.Tables[0];
            gridFacturas.Columns[0].Visible = false;
            gridFacturas.Columns[1].Visible = false;
        }

        private void gridFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (gridFacturas.SelectedRows.Count > 0)
            {
                var idFactura = gridFacturas.SelectedRows[0].Cells[0].Value.ToString();
                var idCliente = gridFacturas.SelectedRows[0].Cells[1].Value.ToString();

                _RecargarDetalle(idFactura, idCliente);
                this.btnVer.Enabled = true;
            }
            else
            {
                this.btnVer.Enabled = false;
            }
        }

        private void _RecargarDetalle(string idFactura, string idCliente)
        {
            var factura = FacturasController.DatosFactura(Convert.ToInt32(idFactura));
            var clientesController = new ClientesController();
            var cliente = clientesController.DatosCliente(Convert.ToInt32(idCliente));

            txtTipo.Text = factura.Documentos_Tipo.Codigo;
            txtNumero.Text = factura.Numero;
            txtTotal.Text = string.Format("${0}", factura.Total);
            txtDesc.Text = string.Format("${0}", factura.Descuento);
            txtIVA.Text = string.Format("${0}", factura.TotalIVA);
            txtNeto.Text = string.Format("${0}", factura.TotalNeto);
            txtVto.Text = factura.FechaVto.HasValue ? factura.FechaVto.Value.ToString("dd/MM/yyyy") : string.Empty;
            txtCliente.Text = cliente.RazonSocial;

            comboEstado.SelectedIndex = comboEstado.FindString(factura.Documentos_Estado.Descripcion);
        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            var estadosFactura = FacturasController.EstadosFactura();
            comboEstado.DisplayMember = "Descripcion";
            comboEstado.ValueMember = "Descripcion";
            comboEstado.DataSource = estadosFactura;

            rdPendientes.Checked = true;
            this.btnVer.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var estado = ((Documentos_Estado)comboEstado.SelectedItem).Descripcion;
            var idFactura = Convert.ToInt32(gridFacturas.SelectedRows[0].Cells[0].Value.ToString());
            var resultado = FacturasController.ActualizarFactura(idFactura, estado);

            if (resultado)
            {
                MessageBox.Show("La factura ha sido modificada correctamente!");

                RadioButton rd;
                if (this.rdAnuladas.Checked)
                {
                    rd = this.rdAnuladas;
                }
                else if (this.rdPagadas.Checked)
                {
                    rd = this.rdPagadas;
                }
                else if (this.rdPendientes.Checked)
                {
                    rd = this.rdPendientes;
                }
                else
                {
                    rd = this.rdTodas;
                }

                this.CheckedCriterioFiltroChange((object) rd, e);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar modificar la factura. Inténtelo nuevamente.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = "";
            foreach (var control in gbxCriteriosBusqueda.Controls)
            {
                if (control.GetType() == typeof(RadioButton))
                {
                    var radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        criterioBusqueda = radioButton.Text;
                    }
                }
            }

            var estadoFactura = string.Empty;

            if (this.rdPagadas.Checked)
            {
                estadoFactura = "Pagado";
            }
            else if (this.rdPendientes.Checked)
            {
                estadoFactura = "Pendiente";
            }
            else if (this.rdAnuladas.Checked)
            {
                estadoFactura = "Anulado";
            }

            var facturasEncontradas = FacturasController.ListarFacturasPorCriterio(estadoFactura,
                                                                                   criterioBusqueda,
                                                                                   txtValorBusqueda.Text);

            if (facturasEncontradas.Tables[0] != null && facturasEncontradas.Tables[0].Rows.Count > 0)
            {
                gridFacturas.DataSource = facturasEncontradas.Tables[0];
            }
            else
            {
                MessageBox.Show("No se encontraron facturas con ese criterio");
            } 
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var idFactura = Convert.ToInt32(gridFacturas.SelectedRows[0].Cells[0].Value.ToString());

            if (idFactura > 0)
            {
                if (txtTipo.Text == "A")
                    new FrmFacturaImprimir() { IdFactura = idFactura }.ShowDialog();
                else
                    new FrmFacturaBImprimir() { IdFactura = idFactura }.ShowDialog();
            }
        }
    }
}
