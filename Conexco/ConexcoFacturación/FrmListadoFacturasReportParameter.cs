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
            ddlEstados.Items.Add(new Documentos_Estado()
                                     {
                                         Descripcion = "TODOS",
                                         idEstado = 0
                                     });
            var facturasController = new FacturasController();
            ddlEstados.DisplayMember = "Descripcion";
            ddlEstados.ValueMember = "IdEstado";
            facturasController.ListarDocumentosEstado().ForEach(est => ddlEstados.Items.Add(est));
        }

        private void btn_CancelarClick(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_AceptarClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCantidad.Text))
            {
                var result = MessageBox.Show(
                                     "No ha ingresado la cantidad máxima de facturas del listado. Por default se utilizará el valor 100 (cien). Está seguro?",
                                     "Atencion",
                                     MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.No)
                    return;
                else
                    CantidadFacturas = 100;
            }
            else
                CantidadFacturas = Convert.ToInt32(txtCantidad.Text);

            IdEstadoFacturas = Convert.ToInt32(((Documentos_Estado)ddlEstados.SelectedItem).idEstado);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
