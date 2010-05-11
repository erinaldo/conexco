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
    public partial class FrmPrecios : Form
    {
        public FrmPrecios()
        {
            InitializeComponent();
        }

        public ArticulosController ArticulosController { get; set; }

        private void FrmPrecios_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            _LimpiarPantalla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(_FaltaCampoRequerido())
                return;

            var result =
                    MessageBox.Show("Va a cambiar el precio de TODOS los Articulos, ¿ha verificado que los valores sean correctos?",
                                    "Confirmación", MessageBoxButtons.OKCancel);
            if(result == System.Windows.Forms.DialogResult.Cancel)
                return;

            var valor = Convert.ToDecimal(txtValor.Text);

            if(rbtnDisminucion.Checked && rbtnPorcentaje.Checked && valor > 100)
            {
                MessageBox.Show("No se puede disminuir los precios en mas del 100%");
                return;
            }

            if (ArticulosController.ActualizarPreciosArticulos(lblSigno.Text, lblTipo.Text, valor))
            {
                MessageBox.Show("Todos los articulos fueron actualizados correctamente");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al actualizar los articulos, compruebe que los valores ingresados sean correctos");
            }
        }

        public void _LimpiarPantalla()
        {
            txtValor.Text = "";
            rbtnAumento.Checked = true;
            rbtnPorcentaje.Checked = true;
            lblSigno.Text = "+";
            lblTipo.Text = "%";
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

            if (String.IsNullOrEmpty(txtValor.Text))
                error = true;

            if (error)
                MessageBox.Show("Ingrese el valor a modificar");

            return error;
        }

        private void rbtnAumento_CheckedChanged(object sender, EventArgs e)
        {
            lblSigno.Text = "+";
            ValidarDisminucionPesos();
        }

        private void rbtnDisminucion_CheckedChanged(object sender, EventArgs e)
        {
            lblSigno.Text = "-";
            ValidarDisminucionPesos();
        }

        private void rbtnPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            lblTipo.Text = "%";
            ValidarDisminucionPesos();
        }

        private void rbtnPesos_CheckedChanged(object sender, EventArgs e)
        {
            lblTipo.Text = "$";
            ValidarDisminucionPesos();
        }

        private void ValidarDisminucionPesos()
        {
            if (rbtnDisminucion.Checked && rbtnPesos.Checked)
            {
                lblMensajePesos.Visible = true;
                lblMensajePesos2.Visible = true;
            }
            else
            {
                lblMensajePesos.Visible = false;
                lblMensajePesos2.Visible = false;
            }
        }

        private void SoloNumerosDecimales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else if (e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
