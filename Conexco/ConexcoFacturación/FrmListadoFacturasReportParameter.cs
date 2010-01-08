using System;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;

namespace ConexcoFacturación
{
    public partial class FrmListadoFacturasReportParameter : Form
    {
        public int CantidadFacturas { get; set; }
        public int IdEstadoFacturas { get; set; }

        public FrmListadoFacturasReportParameter()
        {
            InitializeComponent();
            _CargarDropDownEstados();
        }

        private void _CargarDropDownEstados()
        {
            ddlEstados.Items.Add(new Documentos_Estado
                                     {
                                         Descripcion = "Todos",
                                         idEstado = 0
                                     });
            var facturasController = new FacturasController();
            ddlEstados.DisplayMember = "Descripcion";
            ddlEstados.ValueMember = "IdEstado";
            facturasController.ListarDocumentosEstado().ForEach(est => ddlEstados.Items.Add(est));
            ddlEstados.SelectedIndex = 0;
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btn_AceptarClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text))
            {
                var result = MessageBox.Show(
                                     "No ha ingresado la cantidad máxima de facturas del listado. Por default se utilizará el valor 100 (cien). Está seguro?",
                                     "Atencion",
                                     MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                    return;
                
                CantidadFacturas = 100;
            }
            else
                CantidadFacturas = Convert.ToInt32(txtCantidad.Text.Trim());

            IdEstadoFacturas = Convert.ToInt32(((Documentos_Estado)ddlEstados.SelectedItem).idEstado);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void FrmListadoFacturasReportParameter_Load(object sender, EventArgs e)
        {

        }
    }
}
