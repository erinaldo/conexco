using System;
using System.Collections.Generic;
using System.Data;
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
        }

        private void gridFacturas_SelectionChanged(object sender, EventArgs e)
        {
            if (gridFacturas.SelectedRows.Count > 0)
            {
                var idFactura = gridFacturas.SelectedRows[0].Cells[0].Value.ToString();
                var idCliente = gridFacturas.SelectedRows[0].Cells[2].Value.ToString();

                _RecardarDetalle(idFactura, idCliente);
            }
        }

        private void _RecardarDetalle(string idFactura, string idCliente)
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
            txtVto.Text = factura.FechaVto.ToString();
            txtCliente.Text = cliente.RazonSocial;

            comboEstado.SelectedIndex = comboEstado.FindString(factura.Documentos_Estado.Descripcion);
        }

        private void FrmListadoFacturas_Load(object sender, EventArgs e)
        {
            var estadosFactura = FacturasController.EstadosFactura();
            comboEstado.DisplayMember = "Descripcion";
            comboEstado.ValueMember = "Descripcion";
            comboEstado.DataSource = estadosFactura;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var estado = ((Documentos_Estado)comboEstado.SelectedItem).Descripcion;
            var idFactura = Convert.ToInt32(gridFacturas.SelectedRows[0].Cells[0].Value.ToString());
            var resultado = FacturasController.ActualizarFactura(idFactura, estado);

            if (resultado)
            {
                MessageBox.Show("La factura ha sido modificada correctamente!");
                _ActualizarGrillaFacturas(estado);
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al intentar modificar la factura. Inténtelo nuevamente.");
            }
        }

        
    }
}
