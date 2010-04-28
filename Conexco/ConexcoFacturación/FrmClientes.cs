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
    public partial class FrmClientes : Form
    {
        public ClientesController ClientesController { get; set; }

        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            RefrescarGrilla();
        }

        private void RefrescarGrilla()
        {
            grdClientes.DataSource = ClientesController.ListarClientes();
            grdClientes.Columns[0].Visible = false;
            grdClientes.Columns[2].HeaderText = "Razón Social";
            grdClientes.Columns[6].Visible = false;
            grdClientes.Columns[10].Visible = false;
            grdClientes.Columns[11].HeaderText = "Condición IVA";
        }

        private void RefrescarGrilla(List<Conexco.Model.Cliente> clientes)
        {
            grdClientes.DataSource = clientes;
            grdClientes.Columns[0].Visible = false;
            grdClientes.Columns[2].HeaderText = "Razón Social";
            grdClientes.Columns[6].Visible = false;
            grdClientes.Columns[10].Visible = false;
            grdClientes.Columns[11].HeaderText = "Condición IVA";
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var result = new FrmClientesAlta().ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefrescarGrilla();
            }
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
            btnDomicilios.Enabled = true;
            btnTelefonos.Enabled = true;
            btnContactos.Enabled = true;
            btnTransportistas.Enabled = true;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClientesAlta(){IdCliente = idCliente}.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefrescarGrilla();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro que desea eliminar el cliente? Se perderan todos sus datos.",
                                         "Atención", MessageBoxButtons.OKCancel);
            if(result != System.Windows.Forms.DialogResult.OK)
                return;

            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            if(ClientesController.EliminarCliente(idCliente))
            {
                MessageBox.Show("Cliente eliminado correctamente");
                RefrescarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente, inténtelo nuevamente");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDomicilios_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClientesDomicilios() { IdCliente = idCliente }.ShowDialog();
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClientesTelefonos() { IdCliente = idCliente }.ShowDialog();
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClientesContactos() { IdCliente = idCliente }.ShowDialog();
        }

        private void btnTransportistas_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClientesTransportistas() { IdCliente = idCliente }.ShowDialog();
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

            var clientesEncontrados = ClientesController.ListarClientesPorCriterio(criterioBusqueda,
                                                                                   txtValorBusqueda.Text);
            if (clientesEncontrados.Count > 0)
            {
                RefrescarGrilla(clientesEncontrados);
            }
            else
            {
                MessageBox.Show("No se encontraron clientes con ese criterio");
            }  
        }
    }
}
