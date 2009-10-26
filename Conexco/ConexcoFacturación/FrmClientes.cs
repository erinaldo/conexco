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
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            var result = new FrmClienteAlta().ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefrescarGrilla();
            }
        }

        private void grdClientes_SelectionChanged(object sender, EventArgs e)
        {
            btnModificarCliente.Enabled = true;
            btnEliminarCliente.Enabled = true;
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            var result = new FrmClienteAlta(){IdCliente = idCliente}.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                RefrescarGrilla();
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(grdClientes.SelectedRows[0].Cells[0].Value);
            if(ClientesController.EliminarCliente(idCliente))
            {
                MessageBox.Show("Cliente eliminado correctamente");
                RefrescarGrilla();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el cliente, intentelo nuevamente");
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
    }
}
