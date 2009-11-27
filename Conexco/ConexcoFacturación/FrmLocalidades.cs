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
    public partial class FrmLocalidades : Form
    {
        public FrmLocalidades()
        {
            InitializeComponent();
        }

        public LocalidadesController LocalidadesController { get; set;}

        public Provincia ProvinciaSeleccionada { get; set; }

        public string LocalidadSeleccionada { get; set; }

        public string CodPostalSeleccionado { get; set; }

        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            try
            {
                LocalidadesController = new LocalidadesController();
                var provincias = LocalidadesController.ListarProvincias();

                cmbProvincia.DataSource = provincias;
                cmbProvincia.DisplayMember = "Provincia1";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al listar las provincias, inténtelo nuevamente");
                this.Close();
            }
 
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var provincia = (Provincia)cmbProvincia.SelectedItem;
                _LimpiarPantalla();
                cmbLocalidad.DataSource = LocalidadesController.ListarLocalidadesPorProvincia(provincia);
                cmbLocalidad.DisplayMember = "Localidad";
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un problema al listar las Localidades, inténtelo nuevamente");
                this.Close();
            }

        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblCodPostal.Text = ((Localidade)cmbLocalidad.SelectedItem).CodPostal;
            }
            catch (Exception)
            {
                lblCodPostal.Text = "";
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(_FaltaCampoRequerido())
                return;

            if(txtNuevaLocalidad.Text != "" && txtNuevoCodPostal.Text != "")
            {
                var result =
                    MessageBox.Show("Va a agregar una nueva localidad. Ha verificado que los datos sean correctos?",
                                    "Confirmación", MessageBoxButtons.OKCancel);
                if(result == System.Windows.Forms.DialogResult.Cancel)
                    return;

                var nuevaLocalidad = new Localidade();
                nuevaLocalidad.Localidad = txtNuevaLocalidad.Text;
                nuevaLocalidad.CodPostal = txtNuevoCodPostal.Text;
                nuevaLocalidad.idProvincia = ((Provincia) cmbProvincia.SelectedItem).idProvincia;
                nuevaLocalidad.Provincia = (Provincia) cmbProvincia.SelectedItem;

                if (!LocalidadesController.GuardarNuevaLocalidad(nuevaLocalidad))
                {
                    MessageBox.Show("Ocurrio un problema al guardar la Localidad, inténtelo nuevamente");
                }

                LocalidadSeleccionada = txtNuevaLocalidad.Text;
                CodPostalSeleccionado = txtNuevoCodPostal.Text;
            }
            else
            {
                LocalidadSeleccionada = cmbLocalidad.Text;
                CodPostalSeleccionado = lblCodPostal.Text;
            }

            ProvinciaSeleccionada = (Provincia)cmbProvincia.SelectedItem;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        public void _LimpiarPantalla()
        {
            cmbLocalidad.ResetText();
            lblCodPostal.Text = "";
            txtNuevaLocalidad.Text = "";
            txtNuevoCodPostal.Text = "";
        }

        private void CampoRequerido_Validating(object sender, CancelEventArgs e)
        {
            var control = (Control)sender;
            if (control.Text.Length == 0)
            {
                errorProviderRequerido.SetError(control, "Campo Requerido");
            }
            else
            {
                errorProviderRequerido.Clear();
            }
        }

        public bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(cmbProvincia.Text))
                error = true;
            if (!String.IsNullOrEmpty(txtNuevaLocalidad.Text) || !String.IsNullOrEmpty(txtNuevoCodPostal.Text))
                if (String.IsNullOrEmpty(txtNuevaLocalidad.Text) || String.IsNullOrEmpty(txtNuevoCodPostal.Text))
                    error = true;
            if (String.IsNullOrEmpty(txtNuevaLocalidad.Text) && String.IsNullOrEmpty(txtNuevoCodPostal.Text) && String.IsNullOrEmpty(cmbLocalidad.Text))
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos y la nueva Localidad y Código Postal");

            return error;
        }

        private void txtNuevaLocalidadCodPostal_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNuevaLocalidad.Text) || !String.IsNullOrEmpty(txtNuevoCodPostal.Text))
                lblMensajeNuevaLocalidad.Visible = true;
            else
                lblMensajeNuevaLocalidad.Visible = false;                
        }
    }
}
