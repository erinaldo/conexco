﻿using System;
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
    public partial class FrmClientesDomicilios : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public int IdCliente { get; set; }

        public FrmClientesDomicilios()
        {
            InitializeComponent();
        }

        private void FrmClientesDomicilios_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();

            cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.DisplayMember = "Provincia1";

            lblCliente.Text = ClientesController.DatosCliente(IdCliente).RazonSocial;

            _Refrescar();
        }

        private void _Refrescar()
        {
            grdDomicilios.DataSource = ClientesController.ListarDomicilios(IdCliente);
            grdDomicilios.Columns[0].Visible = false;
            grdDomicilios.Columns[1].Visible = false;
            grdDomicilios.Columns[5].HeaderText = "Código Postal";
            grdDomicilios.Columns[7].Visible = false;
            grdDomicilios.Columns[8].Visible = false;

            _Habilitar(Accion.Inicio);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();           
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

        private void grdDomicilios_SelectionChanged(object sender, EventArgs e)
        {
            if (grdDomicilios.SelectedRows.Count > 0)
            {
                int idDomicilio = Convert.ToInt32(grdDomicilios.SelectedRows[0].Cells[0].Value);
                var domicilio = ClientesController.DatosDomicilio(idDomicilio);
                txtDomicilio.Text = domicilio.Domicilio;
                cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
                txtLocalidad.Text = domicilio.Localidad;
                txtCodPostal.Text = domicilio.CodPostal;
                txtDescripcion.Text = domicilio.Descripcion;
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

        public void _Habilitar(Accion accion)
        {
            if (accion == Accion.Inicio)
            {
                gbxDomicilio.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnModificar.Enabled = true;
                txtDomicilio.Text = "";
                txtLocalidad.Text = "";
                txtCodPostal.Text = "";
                txtDescripcion.Text = "";
                cmbProvincia.SelectedText = "";
                grdDomicilios.ClearSelection();
                grdDomicilios.Enabled = true;
            }
            else
            {
                gbxDomicilio.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnModificar.Enabled = false;

                grdDomicilios.Enabled = false;

                if (accion == Accion.Crear)
                {
                    txtDomicilio.Text = "";
                    txtLocalidad.Text = "";
                    txtCodPostal.Text = "";
                    txtDescripcion.Text = "";
                    cmbProvincia.SelectedText = "";
                    grdDomicilios.ClearSelection();
                }
            }
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

                int idDomicilio = 0;
                if (grdDomicilios.SelectedRows.Count > 0)
                    idDomicilio = Convert.ToInt32(grdDomicilios.SelectedRows[0].Cells[0].Value);
                Clientes_Domicilio domicilio;
                if (idDomicilio > 0)
                {
                    domicilio = ClientesController.DatosDomicilio(idDomicilio);
                }
                else
                {
                    domicilio = new Clientes_Domicilio();
                    ClientesController.DatosCliente(IdCliente).Clientes_Domicilios.Add(domicilio);
                }

                domicilio.Domicilio = txtDomicilio.Text;
                domicilio.Provincia = cmbProvincia.Text;
                domicilio.Localidad = txtLocalidad.Text;
                domicilio.CodPostal = txtCodPostal.Text;
                domicilio.Descripcion = txtDescripcion.Text;

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
                MessageBox.Show("Ocurrio un error al guardar el domicilio, inténtelo nuevamente");
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Realmente desea eliminar el Domicilio?", "Atención", MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            int idDomicilio = 0;
            if (grdDomicilios.SelectedRows.Count > 0)
                idDomicilio = Convert.ToInt32(grdDomicilios.SelectedRows[0].Cells[0].Value);
            if (idDomicilio > 0)
            {
                if (ClientesController.EliminarDomicilio(idDomicilio))
                    MessageBox.Show("Domicilio eliminado correctamente");
                else
                    MessageBox.Show("Ocurrio un problema al eliminar el domicilio, inténtelo nuevamente");
                _Refrescar();
            }
            else
                MessageBox.Show("Debe seleccionar un domicilio");
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

    public enum Accion
    {
        Crear,
        Modificar,
        Inicio
    }
}
