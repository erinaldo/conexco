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
    public partial class FrmClientesBuscador : Form
    {
        public ClientesController ClientesController { get; set; }
        public Cliente ClienteSeleccionado { get; set; }
        public Clientes_Domicilio DomicilioSeleccionado { get; set; }

        public FrmClientesBuscador()
        {
            InitializeComponent();
        }

        private void FrmClientesBuscador_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            _RefrescarGrilla();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterioBusqueda = "";
            foreach (var control in gbxCriteriosBusqueda.Controls)
            {
                if(control.GetType() == typeof(RadioButton))
                {
                    var radioButton = (RadioButton) control;
                    if(radioButton.Checked)
                    {
                        criterioBusqueda = radioButton.Text;
                    }
                }
            }

            var clientesEncontrados = ClientesController.ListarClientesPorCriterio(criterioBusqueda,
                                                                                   txtValorBusqueda.Text);
            if(clientesEncontrados.Count > 0)
            {
                _RefrescarGrilla(clientesEncontrados);
            }
            else
            {
                MessageBox.Show("No se encontraron clientes con ese criterio");
            }            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(grdClientes.SelectedRows.Count > 0)
            {
                ClienteSeleccionado = 
                    ClientesController.DatosCliente(Convert.ToInt32(grdClientes.SelectedCells[0].Value));
                DomicilioSeleccionado =
                    ClientesController.DatosDomicilio(Convert.ToInt32(grdDomicilios.SelectedCells[0].Value));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            if(grdClientes.SelectedRows.Count > 0)
                _RefrescarDomicilios(Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value));            
        }

        private void _RefrescarGrilla()
        {
            var clientes = ClientesController.ListarClientes();
            if (clientes.Count > 0)
            {
                grdClientes.DataSource = clientes;
                grdClientes.Columns[0].Visible = false;
                grdClientes.Columns[2].HeaderText = "Razón Social";
                grdClientes.Columns[6].Visible = false;
                grdClientes.Columns[10].Visible = false;
                grdClientes.Columns[11].HeaderText = "Condición IVA";

                _RefrescarDomicilios(Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value));
            }
            else
            {
                var result = MessageBox.Show("No hay clientes cargados, desea crear un cliente ahora?", "Atencion",
                                MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new FrmClientes().ShowDialog();
                    _RefrescarGrilla(ClientesController.ListarClientes());
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void _RefrescarGrilla(List<Cliente> clientes)
        {
            grdClientes.DataSource = clientes;
            grdClientes.Columns[0].Visible = false;
            grdClientes.Columns[2].HeaderText = "Razón Social";
            grdClientes.Columns[6].Visible = false;
            grdClientes.Columns[10].Visible = false;
            grdClientes.Columns[11].HeaderText = "Condición IVA";

            _RefrescarDomicilios(Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value));
        }

        private void _RefrescarDomicilios(int idCliente)
        {
            grdDomicilios.DataSource = ClientesController.ListarDomicilios(idCliente);
            grdDomicilios.Columns[0].Visible = false;
            grdDomicilios.Columns[1].Visible = false;
            grdDomicilios.Columns[5].HeaderText = "Código Postal";
            grdDomicilios.Columns[7].Visible = false;
            grdDomicilios.Columns[8].Visible = false;
        }
    }
}
