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
    public partial class FrmClientesTransportistas : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public int IdCliente { get; set; }
        public bool SeleccionHabilitada { get; set; }
        public Clientes_Transportista TransportistaSeleccionado { get; set; }

        public FrmClientesTransportistas()
        {
            InitializeComponent();
            SeleccionHabilitada = false;
        }

        private void FrmClientesTransportistas_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();

            cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.DisplayMember = "Provincia1";

            lblCliente.Text = ClientesController.DatosCliente(IdCliente).RazonSocial;

            btnSeleccionar.Visible = SeleccionHabilitada;

            Refrescar();
        }

        private void Refrescar()
        {
            gridTransportistas.DataSource = ClientesController.ListarTransportistas(IdCliente);
            gridTransportistas.Columns[0].Visible = false;
            gridTransportistas.Columns[1].Visible = false;
            gridTransportistas.Columns[7].HeaderText = "Código Postal";
            gridTransportistas.Columns[9].HeaderText = "Información Adicional";
            gridTransportistas.Columns[10].Visible = false;
            gridTransportistas.Columns[11].Visible = false;

            Habilitar(Accion.Inicio);
        }

        public void Habilitar(Accion accion)
        {
            if (accion == Accion.Inicio)
            {
                gbxTransportista.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtNombre.Text = "";
                txtTelefono.Text = "";
                txtDomicilio.Text = "";
                txtLocalidad.Text = "";
                txtCodPostal.Text = "";
                txtInfoAdicional.Text = "";
                cmbProvincia.SelectedText = "";
                gridTransportistas.ClearSelection();
                gridTransportistas.Enabled = true;
            }
            else
            {
                gbxTransportista.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;

                gridTransportistas.Enabled = false;

                if (accion == Accion.Crear)
                {
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    txtDomicilio.Text = "";
                    txtLocalidad.Text = "";
                    txtCodPostal.Text = "";
                    txtInfoAdicional.Text = "";
                    cmbProvincia.SelectedText = "";
                    gridTransportistas.ClearSelection();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idTransportista = 0;
            if (gridTransportistas.SelectedRows.Count > 0)
                idTransportista = Convert.ToInt32(gridTransportistas.SelectedRows[0].Cells[0].Value);
            if (idTransportista > 0)
            {
                if (ClientesController.EliminarTransportista(idTransportista))
                    MessageBox.Show("Transportista eliminado correctamente");
                else
                    MessageBox.Show("Ocurrio un problema al eliminar el transportista, intentelo nuevamente");
                Refrescar();
            }
            else
                MessageBox.Show("Debe seleccionar un transportista");
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
            int idTransportista = 0;
            if (gridTransportistas.SelectedRows.Count > 0)
                idTransportista = Convert.ToInt32(gridTransportistas.SelectedRows[0].Cells[0].Value);
            Clientes_Transportista transportista;
            if (idTransportista > 0)
            {
                transportista = ClientesController.DatosTransportista(idTransportista);
            }
            else
            {
                transportista = new Clientes_Transportista();
                ClientesController.DatosCliente(IdCliente).Clientes_Transportistas.Add(transportista);
            }

            transportista.Nombre = txtNombre.Text;
            transportista.CUIT = txtCuit.Text;
            transportista.Telefono = txtTelefono.Text;
            transportista.Domicilio = txtDomicilio.Text;
            transportista.Provincia = cmbProvincia.Text;
            transportista.Localidad = txtLocalidad.Text;
            transportista.CodPostal = txtCodPostal.Text;
            transportista.InformacionAdicional = txtInfoAdicional.Text;

            if (ClientesController.GuardarCambios())
            {
                MessageBox.Show("Transportista guardado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar el transportista, intentelo de nuevo");
            }
            Refrescar();
        }

        private void gridTransportistas_SelectionChanged(object sender, EventArgs e)
        {
            if (gridTransportistas.SelectedRows.Count > 0)
            {
                int idTransportista = Convert.ToInt32(gridTransportistas.SelectedRows[0].Cells[0].Value);
                var transportista = ClientesController.DatosTransportista(idTransportista);
                txtNombre.Text = transportista.Nombre;
                txtCuit.Text = transportista.CUIT;
                txtTelefono.Text = transportista.Telefono;
                txtDomicilio.Text = transportista.Domicilio;
                cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(transportista.Provincia).idProvincia;
                txtLocalidad.Text = transportista.Localidad;
                txtCodPostal.Text = transportista.CodPostal;
                txtInfoAdicional.Text = transportista.InformacionAdicional;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEliminar.Enabled = false;
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

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if(gridTransportistas.SelectedRows.Count > 0)
            {
                TransportistaSeleccionado =
                    ClientesController.DatosTransportista(Convert.ToInt32(gridTransportistas.SelectedCells[0].Value));
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
        }
    }
}
