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
    public partial class FrmClientesAlta : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public FiscalesController FiscalesController { get; set; }
        public int IdCliente { get; set; }

        public FrmClientesAlta()
        {
            InitializeComponent();
        }

        private void FrmClienteAlta_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();
            FiscalesController = new FiscalesController();

            try
            {
                cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
                cmbProvincia.ValueMember = "idProvincia";
                cmbProvincia.DisplayMember = "Provincia1";

                cmbCondicionIva.DataSource = FiscalesController.ListarCondicionIVA();
                cmbCondicionIva.ValueMember = "idCondicionIVA";
                cmbCondicionIva.DisplayMember = "Descripcion";

                _CargarControles();
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede mostrar el cliente, inténtelo nuevamente");
                this.Close();
            }
        }

        private void _CargarControles()
        {
            if(IdCliente > 0)
            {
                this.Text = "Modificar Cliente";
                var cliente = ClientesController.DatosCliente(IdCliente);
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtEmail.Text = cliente.Email;
                txtWeb.Text = cliente.Web;
                var telefono = cliente.Clientes_Telefonos.FirstOrDefault();
                if (telefono != null)
                {
                    txtTelefono.Text = telefono.Telefono;
                    txtFax.Text = telefono.Fax;
                }
                txtCodCliente.Text = cliente.Codigo;
                txtRazonSocial.Text = cliente.RazonSocial;
                txtCuit.Text = cliente.CUIT;
                cmbCondicionIva.SelectedValue = cliente.idCondicionIVA;
                txtPagos.Text = cliente.Pagos;
                var domicilio = cliente.Clientes_Domicilios.FirstOrDefault();
                if (domicilio != null)
                {
                    txtDomicilio.Text = domicilio.Domicilio;
                    cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
                    txtLocalidad.Text = domicilio.Localidad;
                    txtCodPostal.Text = domicilio.CodPostal;
                }
            }
            else
            {
                this.Text = "Alta de Clientes";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(_FaltaCampoRequerido())
                return;

            try
            {
                Cliente cliente;
                if (IdCliente > 0)
                    cliente = ClientesController.DatosCliente(IdCliente);
                else
                    cliente = new Cliente();

                cliente.Codigo = txtCodCliente.Text;
                cliente.RazonSocial = txtRazonSocial.Text;
                cliente.Nombre = txtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.CUIT = txtCuit.Text;
                cliente.idCondicionIVA = Convert.ToInt32(cmbCondicionIva.SelectedValue);
                cliente.Email = txtEmail.Text;
                cliente.Pagos = txtPagos.Text;
                cliente.Web = txtWeb.Text;

                var domicilio = new Clientes_Domicilio
                                    {
                                        Domicilio = txtDomicilio.Text,
                                        Provincia = cmbProvincia.Text,
                                        Localidad = txtLocalidad.Text,
                                        CodPostal = txtCodPostal.Text,
                                        Descripcion = "Domicilio Principal"
                                    };

                var telefono = new Clientes_Telefono
                                   {
                                       Telefono = txtTelefono.Text,
                                       Fax = txtFax.Text,
                                       Descripcion = "Telefono Principal"
                                   };

                bool correcto;

                if (cliente.idCliente > 0)
                {
                    var domicilioGuardado = cliente.Clientes_Domicilios.FirstOrDefault();
                    if (domicilioGuardado != null)
                    {
                        domicilioGuardado.Domicilio = domicilio.Domicilio;
                        domicilioGuardado.Provincia = domicilio.Provincia;
                        domicilioGuardado.Localidad = domicilio.Localidad;
                        domicilioGuardado.CodPostal = domicilio.CodPostal;
                    }
                    else
                        cliente.Clientes_Domicilios.Add(domicilio);

                    var telefonoGuardado = cliente.Clientes_Telefonos.FirstOrDefault();
                    if (telefonoGuardado != null)
                    {
                        telefonoGuardado.Telefono = telefono.Telefono;
                        telefonoGuardado.Fax = telefono.Fax;
                    }
                    else
                        cliente.Clientes_Telefonos.Add(telefono);

                    correcto = ClientesController.GuardarCambios();
                }
                else
                {
                    cliente.Clientes_Domicilios.Add(domicilio);
                    cliente.Clientes_Telefonos.Add(telefono);
                    correcto = ClientesController.AgregarCliente(cliente);
                }

                if (correcto)
                {
                    MessageBox.Show("Cliente guardado satisfactoriamente");
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al guardar el cliente, intentelo de nuevo");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar el cliente, inténtelo nuevamente");
                this.Close();
            }
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var frmLocalidades = new FrmLocalidades();
            var result = frmLocalidades.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtLocalidad.Text = frmLocalidades.LocalidadSeleccionada;
                txtCodPostal.Text = frmLocalidades.CodPostalSeleccionado;
                cmbProvincia.SelectedValue = frmLocalidades.ProvinciaSeleccionada.idProvincia;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            if (String.IsNullOrEmpty(txtCodCliente.Text))
                error = true;
            if (String.IsNullOrEmpty(txtRazonSocial.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCuit.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbCondicionIva.Text))
                error = true;
            if (String.IsNullOrEmpty(txtNombre.Text))
                error = true;
            if (String.IsNullOrEmpty(txtApellido.Text))
                error = true;
            if (String.IsNullOrEmpty(txtTelefono.Text))
                error = true;
            if (String.IsNullOrEmpty(txtDomicilio.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbProvincia.Text))
                error = true;
            if (String.IsNullOrEmpty(txtLocalidad.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCodPostal.Text))
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos");

            return error;
        }
    }
}
