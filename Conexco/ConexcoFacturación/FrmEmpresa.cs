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
    public partial class FrmEmpresa : Form
    {
        public EmpresaController EmpresaController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public FiscalesController FiscalesController { get; set; }
        public int IdEmpresa { get; set; }

        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            EmpresaController = new EmpresaController();
            LocalidadesController = new LocalidadesController();
            FiscalesController = new FiscalesController();

            cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.DisplayMember = "Provincia1";

            cmbCondicionIva.DataSource = FiscalesController.ListarCondicionIVA();
            cmbCondicionIva.ValueMember = "idCondicionIVA";
            cmbCondicionIva.DisplayMember = "Descripcion";

            var empresa = EmpresaController.DatosEmpresa();

            if (empresa != null)
            {
                CargarControles(empresa);
            }
        }

        private void CargarControles(Empresa empresa)
        {
            IdEmpresa = empresa.idEmpresa;
            txtRazonSocial.Text = empresa.RazonSocial;
            txtNombre.Text = empresa.Nombre;
            txtApellido.Text = empresa.Apellido;
            txtTelefono.Text = empresa.Telefono;
            txtFax.Text = empresa.Fax;
            txtEmail.Text = empresa.Email;
            txtWeb.Text = empresa.Web;
            txtDomicilio.Text = empresa.Domicilio;
            cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(empresa.Provincia).idProvincia;
            txtLocalidad.Text = empresa.Localidad;
            txtCodPostal.Text = empresa.CodPostal;
            txtCuit.Text = empresa.CUIT;
            cmbCondicionIva.SelectedValue = empresa.idCondicionIVA;
            dtpInicioActividades.Value = empresa.InicioActividades;
            txtIngresosBrutos.Text = empresa.IngBrutos;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var empresa = new Empresa();
            empresa.idEmpresa = IdEmpresa;
            empresa.RazonSocial = txtRazonSocial.Text;
            empresa.Nombre = txtNombre.Text;
            empresa.Apellido = txtApellido.Text;
            empresa.Telefono = txtTelefono.Text;
            empresa.Fax = txtFax.Text;
            empresa.Email = txtEmail.Text;
            empresa.Web = txtWeb.Text;
            empresa.Domicilio = txtDomicilio.Text;
            empresa.Provincia = cmbProvincia.Text;
            empresa.Localidad = txtLocalidad.Text;
            empresa.CodPostal = txtCodPostal.Text;
            empresa.CUIT = txtCuit.Text;
            empresa.idCondicionIVA = Convert.ToInt32(cmbCondicionIva.SelectedValue);
            empresa.InicioActividades = dtpInicioActividades.Value;
            empresa.IngBrutos = txtIngresosBrutos.Text;


            if(EmpresaController.CrearOActualizarEmpresa(empresa))
            {
                MessageBox.Show("Datos guardados correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar los datos de la empresa, intentelo nuevamente");
            }
        }
    }
}
