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
            LocalidadesController = new LocalidadesController();
            var provincias = LocalidadesController.ListarProvincias();

            cmbProvincia.DataSource = provincias;
            cmbProvincia.DisplayMember = "Provincia1"; 
        }

        private void cmbProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var provincia = (Provincia) cmbProvincia.SelectedItem;
            LimpiarPantalla();
            cmbLocalidad.DataSource = LocalidadesController.ListarLocalidadesPorProvincia(provincia);
            cmbLocalidad.DisplayMember = "Localidad";
        }

        private void cmbLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodPostal.Text = ((Localidade) cmbLocalidad.SelectedItem).CodPostal;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(txtNuevaLocalidad.Text != "" && txtNuevoCodPostal.Text != "")
            {
                var nuevaLocalidad = new Localidade();
                nuevaLocalidad.Localidad = txtNuevaLocalidad.Text;
                nuevaLocalidad.CodPostal = txtNuevoCodPostal.Text;
                nuevaLocalidad.idProvincia = ((Provincia) cmbProvincia.SelectedItem).idProvincia;
                nuevaLocalidad.Provincia = (Provincia) cmbProvincia.SelectedItem;

                if (!LocalidadesController.GuardarNuevaLocalidad(nuevaLocalidad))
                {
                    MessageBox.Show("Ocurrio un problema al guardar la Localidad, intentelo nuevamente");
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

        public void LimpiarPantalla()
        {
            cmbLocalidad.ResetText();
            lblCodPostal.Text = "";
            txtNuevaLocalidad.Text = "";
            txtNuevoCodPostal.Text = "";

        }
    }
}
