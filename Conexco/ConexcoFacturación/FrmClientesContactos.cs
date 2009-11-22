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
    public partial class FrmClientesContactos : Form
    {
        public ClientesController ClientesController { get; set; }
        public int IdCliente { get; set; }

        public FrmClientesContactos()
        {
            InitializeComponent();
        }

        private void FrmClientesContactos_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            lblCliente.Text = ClientesController.DatosCliente(IdCliente).RazonSocial;

            _Refrescar();
        }

        private void _Refrescar()
        {
            grdContactos.DataSource = ClientesController.ListarContactos(IdCliente);
            grdContactos.Columns[0].Visible = false;
            grdContactos.Columns[1].Visible = false;
            grdContactos.Columns[4].Visible = false;
            grdContactos.Columns[3].HeaderText = "E-Mail";

            Habilitar(Accion.Inicio);
        }

        public void Habilitar(Accion accion)
        {
            if (accion == Accion.Inicio)
            {
                gbxContactos.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtNombre.Text = "";
                txtEmail.Text = "";
                grdContactos.ClearSelection();
                grdContactos.Enabled = true;
            }
            else
            {
                gbxContactos.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;

                grdContactos.Enabled = false;

                if (accion == Accion.Crear)
                {
                    txtNombre.Text = "";
                    txtEmail.Text = "";
                    grdContactos.ClearSelection();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(_FaltaCampoRequerido())
                return;

            try
            {
                int idContacto = 0;
                if (grdContactos.SelectedRows.Count > 0)
                    idContacto = Convert.ToInt32(grdContactos.SelectedRows[0].Cells[0].Value);
                Clientes_Contacto contacto;
                if (idContacto > 0)
                {
                    contacto = ClientesController.DatosContacto(idContacto);
                }
                else
                {
                    contacto = new Clientes_Contacto();
                    ClientesController.DatosCliente(IdCliente).Clientes_Contactos.Add(contacto);
                }

                contacto.Nombre = txtNombre.Text;
                contacto.Email = txtEmail.Text;

                if (ClientesController.GuardarCambios())
                {
                    MessageBox.Show("Contacto guardado correctamente");
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al guardar el contacto, intentelo de nuevo");
                }
                _Refrescar();
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el contacto, inténtelo nuevamente");
                this.Close();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Habilitar(Accion.Crear);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Habilitar(Accion.Modificar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente desea eliminar el contacto?", "Atención", MessageBoxButtons.OKCancel);
            if(result != System.Windows.Forms.DialogResult.OK)
                return;

            int idContacto = 0;
            if (grdContactos.SelectedRows.Count > 0)
                idContacto = Convert.ToInt32(grdContactos.SelectedRows[0].Cells[0].Value);
            if (idContacto > 0)
            {
                if (ClientesController.EliminarContacto(idContacto))
                    MessageBox.Show("Contacto eliminado correctamente");
                else
                    MessageBox.Show("Ocurrio un problema al eliminar el contacto, intentelo nuevamente");
                _Refrescar();
            }
            else
                MessageBox.Show("Debe seleccionar un contacto");
        }

        private void grdContactos_SelectionChanged(object sender, EventArgs e)
        {
            if (grdContactos.SelectedRows.Count > 0)
            {
                int idContacto = Convert.ToInt32(grdContactos.SelectedRows[0].Cells[0].Value);
                var contacto = ClientesController.DatosContacto(idContacto);
                txtNombre.Text = contacto.Nombre;
                txtEmail.Text = contacto.Email;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
            }
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

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtNombre.Text))
                error = true;
            if (String.IsNullOrEmpty(txtEmail.Text))
                error = true;
            if (error)
                MessageBox.Show("Ingrese los campos requeridos");

            return error;
        }
    }
}
