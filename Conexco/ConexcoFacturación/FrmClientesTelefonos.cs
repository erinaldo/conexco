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

            _Refrescar();
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
            _Habilitar(Accion.Modificar);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _Habilitar(Accion.Crear);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(_FaltaCampoRequerido())
                return;
            try
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
                    MessageBox.Show("Ocurrio un problema al guardar el domicilio, inténtelo de nuevo");
                }
                _Refrescar();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un problema al guardar el domicilio, inténtelo de nuevo");
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente desea eliminar el teléfono?", "Atención", MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            int idTelefono = 0;
            if (grdTelefonos.SelectedRows.Count > 0)
                idTelefono = Convert.ToInt32(grdTelefonos.SelectedRows[0].Cells[0].Value);
            if (idTelefono > 0)
            {
                if (ClientesController.EliminarTelefono(idTelefono))
                    MessageBox.Show("Telefono eliminado correctamente");
                else
                    MessageBox.Show("Ocurrio un problema al eliminar el telefono, inténtelo nuevamente");
                _Refrescar();
            }
            else
                MessageBox.Show("Debe seleccionar un telefono");
        }

        private void CampoRequerido_Validating(object sender, CancelEventArgs e)
        {
            var control = (Control)sender;
            if (control.Text.Length == 0 || control.Text.Trim().StartsWith("-"))
            {
                errorProviderRequerido.SetError(control, "Campo Requerido");
            }
            else
            {
                errorProviderRequerido.Clear();
            }
        }

        private void SoloNumerosYGuion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == '-')
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void _Refrescar()
        {
            grdTelefonos.DataSource = ClientesController.ListarTelefonos(IdCliente);
            grdTelefonos.Columns[0].Visible = false;
            grdTelefonos.Columns[1].Visible = false;
            grdTelefonos.Columns[5].Visible = false;
            grdTelefonos.Columns[6].Visible = false;

            _Habilitar(Accion.Inicio);
        }

        public void _Habilitar(Accion accion)
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

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtTelefono.Text))
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos");

            return error;
        }
    }
}
