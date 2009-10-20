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
    public partial class FrmClienteAlta : Form
    {
        public FrmClienteAlta()
        {
            InitializeComponent();
        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            var clientesController = new ClientesController();
            var cliente = new Cliente();
            cliente.Codigo = txtCodCliente.Text;
            cliente.RazonSocial = txtRazonSocial.Text;
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.CUIT = txtCuit.Text;
            cliente.idCondicionIVA = Convert.ToInt32(txtCondIva.Text);
            cliente.Email = txtEmail.Text;
            cliente.Pagos = txtPagos.Text;
            cliente.Web = txtWeb.Text;

            clientesController.AgregarCliente(cliente);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().Show();
        }
    }
}
