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
    public partial class FrmClientesTelefonos : Form
    {
        public ClientesController ClientesController { get; set; }
        public int IdCliente { get; set; }

        public FrmClientesTelefonos()
        {
            InitializeComponent();
        }

        private void FrmClientesTelefonos_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            lblCliente.Text = ClientesController.DatosCliente(IdCliente).RazonSocial;

            Refrescar();
        }

        private void Refrescar()
        {
            grdTelefonos.DataSource = ClientesController.ListarTelefonos(IdCliente);

            Habilitar(Accion.Inicio);
        }

        public void Habilitar(Accion accion)
        {
            if (accion == Accion.Inicio)
            {
                gbxTelefono.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtTelefono.Text = "";
                txtFax.Text = "";
                txtDescripcion.Text = "";
                grdTelefonos.ClearSelection();
                grdTelefonos.Enabled = true;
            }
            else
            {
                gbxTelefono.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;

                grdTelefonos.Enabled = false;

                if (accion == Accion.Crear)
                {
                    txtTelefono.Text = "";
                    txtFax.Text = "";
                    txtDescripcion.Text = "";
                    grdTelefonos.ClearSelection();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdTelefonos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdTelefonos.SelectedRows.Count > 0)
            {
                int idTelefono = Convert.ToInt32(grdTelefonos.SelectedRows[0].Cells[0].Value);
                var telefono = ClientesController.DatosTelefono(idTelefono);
                txtTelefono.Text = telefono.Telefono;
                txtFax.Text = telefono.Fax;
                txtDescripcion.Text = telefono.Descripcion;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilitar(Accion.Modificar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(Accion.Crear);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idTelefono = 0;
            if (grdTelefonos.SelectedRows.Count > 0)
                idTelefono = Convert.ToInt32(grdTelefonos.SelectedRows[0].Cells[0].Value);
            Clientes_Telefono telefono;
            if (idTelefono > 0)
            {
                telefono = ClientesController.DatosTelefono(idTelefono);
            }
            else
            {
                telefono = new Clientes_Telefono();
                ClientesController.DatosCliente(IdCliente).Clientes_Telefonos.Add(telefono);
            }

            telefono.Telefono = txtTelefono.Text;
            telefono.Fax = txtFax.Text;
            telefono.Descripcion = txtDescripcion.Text;

            if (ClientesController.GuardarCambios())
            {
                MessageBox.Show("Domicilio guardado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar el domicilio, intentelo de nuevo");
            }
            Refrescar();
        }
    }
}
