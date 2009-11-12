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
    public partial class FrmRemito : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public FiscalesController FiscalesController { get; set; }
        public EmpresaController EmpresaController { get; set; }
        public ArticulosController ArticulosController { get; set; }
        public RemitosController RemitosController { get; set; }

        private int _idCliente;
        private int _idTransportista;

        public FrmRemito()
        {
            InitializeComponent();
        }

        private void FrmRemito_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();
            FiscalesController = new FiscalesController();
            EmpresaController = new EmpresaController();
            ArticulosController = new ArticulosController();
            RemitosController = new RemitosController();

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

            //Documento estado
            cmbEstadoDoc.DataSource = RemitosController.ListarDocumentosEstado();
            cmbEstadoDoc.ValueMember = "idEstado";
            cmbEstadoDoc.DisplayMember = "Descripcion";

            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn) grdDetalleRemito.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetalleRemito.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

        }

        private decimal _CalcularPrecio(decimal precio)
        {
            precio += Convert.ToDecimal(Convert.ToDouble(precio) * ((btnIva.Text == "21%") ? 0.21 : 0.105));
            return precio;
        }

        private void _RecalcularArticulos()
        {
            foreach (DataGridViewRow row in grdDetalleRemito.Rows)
            {
                if (!row.IsNewRow)
                {
                    var codArticulo = row.Cells["Codigo"].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    row.Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                }
            }
        }

        private void grdDetalleRemito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleRemito.SelectedCells.Count > 0)
            {
                if (e.ColumnIndex == 2)
                {
                    var codArticulo = grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                    grdDetalleRemito.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;
                }
                else if (e.ColumnIndex == 3)
                {
                    var descripcion = grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                    grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                    grdDetalleRemito.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo + ((articulo.CodColor == null) ? "" : "-" + articulo.CodColor);
                }
                grdDetalleRemito.Rows[e.RowIndex].Cells["Totales"].Value =
                        Convert.ToDecimal(grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value) *
                        Convert.ToDecimal(grdDetalleRemito.Rows[e.RowIndex].Cells["Unidades"].Value);
            }

            double total = 0;
            foreach (DataGridViewRow row in grdDetalleRemito.Rows)
            {
                try
                {
                    total += Convert.ToDouble(row.Cells["Totales"].Value);

                }
                catch (Exception)
                {
                    total = 0;
                }
            }

            lblTotal.Text = total.ToString();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientesBuscador = new FrmClientesBuscador();
            var result = frmClientesBuscador.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var cliente = frmClientesBuscador.ClienteSeleccionado;
                _idCliente = cliente.idCliente;
                var domicilio = frmClientesBuscador.DomicilioSeleccionado;

                txtRazonSocial.Text = cliente.RazonSocial;
                txtDomicilio.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                txtProvincia.Text = domicilio.Provincia;
                txtCodPostal.Text = domicilio.CodPostal;
                txtCuit.Text = cliente.CUIT;
                txtCondIva.Text = cliente.CondicionIVA.ToString();
                txtClienteCod.Text = cliente.Codigo;
            }
        }

        private void btnIva_Click(object sender, EventArgs e)
        {
            if (btnIva.Text == "21%")
                btnIva.Text = "10.5%";
            else
                btnIva.Text = "21%";
            _RecalcularArticulos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var remito = new Remito();

            remito.idCliente = _idCliente;
            remito.FechaEmision = dtpFechaEmision.Value;
            remito.Numero = txtNumFactura.Text;
            remito.idTransportista = _idTransportista;
            remito.DomicilioEntrega = txtDomicilio.Text;
            remito.LocalidadEntrega = txtLocalidad.Text;
            remito.ProvinciaEntrega = txtProvincia.Text;
            remito.CodPostalEntrega = txtCodPostal.Text;
            remito.OrdenCompra = txtOrdenCompra.Text;
            remito.CantBultos = Convert.ToInt32(txtCantBultos.Text);
            remito.Observaciones = txtObservaciones.Text;
            remito.Total = Convert.ToDecimal(lblTotal.Text);
            remito.idEstado = Convert.ToInt32(cmbEstadoDoc.SelectedValue);

            //Carga de lineas
            foreach (DataGridViewRow row in grdDetalleRemito.Rows)
            {
                if (!row.IsNewRow)
                {
                    var linea = new Remitos_Linea();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(row.Cells["Codigo"].Value.ToString());
                    linea.idArticulo = articulo.idArticulo;
                    linea.Cantidad = Convert.ToDecimal(row.Cells["Unidades"].Value);
                    linea.Envases = Convert.ToDecimal(row.Cells["Envases"].Value);
                    linea.Precio = articulo.Precio;

                    remito.Remitos_Lineas.Add(linea);
                }
            }

            if (RemitosController.AgregarRemito(remito))
            {
                MessageBox.Show("Remito guardado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar el remito, intentelo nuevamente");
            }
        }



    }
}
