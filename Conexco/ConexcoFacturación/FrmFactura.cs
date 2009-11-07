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
    public partial class FrmFactura : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public FiscalesController FiscalesController { get; set; }
        public EmpresaController EmpresaController { get; set; }
        public ArticulosController ArticulosController { get; set; }

        public FrmFactura()
        {
            InitializeComponent();
        }

        private void FrmFactura_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();
            FiscalesController = new FiscalesController();
            EmpresaController = new EmpresaController();
            ArticulosController = new ArticulosController();

            cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.DisplayMember = "Provincia1";

            cmbCondicionIva.DataSource = FiscalesController.ListarCondicionIVA();
            cmbCondicionIva.ValueMember = "idCondicionIVA";
            cmbCondicionIva.DisplayMember = "Descripcion";

            CargarControles();
        }

        private void CargarControles()
        {
            //Empresa
            var empresa = EmpresaController.DatosEmpresa();
            lblEmpRazonSocial.Text = empresa.RazonSocial;
            lblEmpDomicilio.Text = empresa.Domicilio;
            lblEmpCodPostal.Text = empresa.CodPostal;
            lblEmpLocalidad.Text = empresa.Localidad;
            lblEmpProvincia.Text = empresa.Provincia;
            lblEmpTel.Text = empresa.Telefono;
            lblEmpFax.Text = empresa.Fax;
            lblEmpPosicionIVA.Text = empresa.CondicionIVA.ToString();
            lblEmpCuit.Text = empresa.CUIT;
            lblEmpIngBrutos.Text = empresa.IngBrutos;
            lblEmpInicioActividades.Text = empresa.InicioActividades.ToShortDateString();


            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn) grdDetalleFactura.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetalleFactura.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

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

        private void grdDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(grdDetalleFactura.SelectedCells.Count >0)
            {
                if(e.ColumnIndex == 0)
                {
                    var codArticulo = grdDetalleFactura.SelectedCells[0].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = articulo.Precio;
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;
                }
                else if(e.ColumnIndex == 2)
                {
                    var descripcion = grdDetalleFactura.SelectedCells[0].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = articulo.Precio;
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo;
                }
            }
        }
    }
}
