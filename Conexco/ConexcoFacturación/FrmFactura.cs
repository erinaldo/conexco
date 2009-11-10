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
        public FacturasController FacturasController { get; set; }

        private int _idCliente;
        private int _idDomicilio;

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
            FacturasController = new FacturasController();

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

            //Documento tipo
            cmbLetra.DataSource = FacturasController.ListarDocumentosTipo();
            cmbLetra.ValueMember = "idTipoDocumento";
            cmbLetra.DisplayMember = "Codigo";

            //Documento estado
            cmbEstadoDoc.DataSource = FacturasController.ListarDocumentosEstado();
            cmbEstadoDoc.ValueMember = "idEstado";
            cmbEstadoDoc.DisplayMember = "Descripcion";

            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn) grdDetalleFactura.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetalleFactura.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

        }

        private void grdDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(grdDetalleFactura.SelectedCells.Count >0)
            {
                if(e.ColumnIndex == 0)
                {
                    var codArticulo = grdDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = articulo.Precio;
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;
                }
                else if(e.ColumnIndex == 2)
                {
                    var descripcion = grdDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = articulo.Precio;
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo + ((articulo.CodColor == null) ? "" : "-"+articulo.CodColor);
                }
                grdDetalleFactura.Rows[e.RowIndex].Cells["Totales"].Value =
                        Convert.ToDecimal(grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value) *
                        Convert.ToDecimal(grdDetalleFactura.Rows[e.RowIndex].Cells["Cantidad"].Value);
            }

            double total = 0;         
            foreach (DataGridViewRow row in grdDetalleFactura.Rows)
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
                _idDomicilio = domicilio.idDomicilio;

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

        private void lblNetoPagar_TextChanged(object sender, EventArgs e)
        {
            txtSonPesos.Text = UtilNumerosALetras.Enletras(lblNetoPagar.Text);
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void btnTipoValor_Click(object sender, EventArgs e)
        {
            if (btnTipoValor.Text == "$")
                btnTipoValor.Text = "%";
            else
                btnTipoValor.Text = "$";
            CalcularTotales();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            var totalBruto = Convert.ToDouble(lblTotal.Text);
            var descuento = Convert.ToDouble(txtDescuento.Text);
            if(btnTipoValor.Text == "$")
                lblSubtotal.Text = (totalBruto - descuento).ToString();
            else
                lblSubtotal.Text = (totalBruto - (totalBruto * descuento / 100)).ToString();

            //TODO: Definir discriminacion de IVA (A,B)
            if(btnIva.Text == "21%")
            {
                lblTotalIva.Text = (Convert.ToDouble(lblSubtotal.Text) * 0.21).ToString();
            }
            else
            {
                lblTotalIva.Text = (Convert.ToDouble(lblSubtotal.Text) * 0.105).ToString();
            }

            lblNetoPagar.Text = (Convert.ToDouble(lblSubtotal.Text) + Convert.ToDouble(lblTotalIva.Text)).ToString();
        }

        private void btnIva_Click(object sender, EventArgs e)
        {
            if (btnIva.Text == "21%")
                btnIva.Text = "10.5%";
            else
                btnIva.Text = "21%";

            CalcularTotales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var factura  = new Factura();

            factura.idCliente = _idCliente;
            factura.idDomicilioCliente = _idDomicilio;
            factura.FechaEmision = dtpFechaEmision.Value;
            factura.idTipoDocumento = Convert.ToInt32(cmbLetra.SelectedValue);
            factura.Numero = txtNumFactura.Text;
            factura.Remito = txtRemito.Text;
            factura.OrdenCompra = txtOrdenCompra.Text;
            factura.FechaVto = dtpVencimiento.Value;
            factura.Condiciones = txtCondiciones.Text;
            factura.Total = Convert.ToDecimal(lblTotal.Text);
            factura.Descuento = Convert.ToDecimal(txtDescuento.Text);
            factura.Subtotal = Convert.ToDecimal(lblSubtotal.Text);
            factura.TotalIVA = Convert.ToDecimal(lblTotalIva.Text);
            factura.TotalNeto = Convert.ToDecimal(lblNetoPagar.Text);
            factura.idEstado = Convert.ToInt32(cmbEstadoDoc.SelectedValue);

            //Carga de lineas
            foreach (DataGridViewRow row in grdDetalleFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    var linea = new Facturas_Linea();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(row.Cells["Codigo"].Value.ToString());
                    linea.idArticulo = articulo.idArticulo;
                    linea.Cantidad = Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    linea.Precio = articulo.Precio;

                    factura.Facturas_Lineas.Add(linea);
                }
            }

            if(FacturasController.AgregarFactura(factura))
            {
                MessageBox.Show("Factura guardada correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar la factura, intentelo nuevamente");
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }   
   }


}
