using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        public decimal PorcentajeIVA { get; set; }

        private const int MAX_FILAS = 10;

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

            _CargarControles();
        }

        private void grdDetalleFactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdDetalleFactura.SelectedCells.Count > 0)
                {
                    if (e.ColumnIndex == 0)
                    {
                        var codArticulo = grdDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                        grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                        grdDetalleFactura.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        var descripcion = grdDetalleFactura.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                        grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                        grdDetalleFactura.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo +
                                                                                   ((articulo.CodColor == null)
                                                                                        ? ""
                                                                                        : "-" + articulo.CodColor);
                    }
                    grdDetalleFactura.Rows[e.RowIndex].Cells["Totales"].Value =
                        (Convert.ToDecimal(grdDetalleFactura.Rows[e.RowIndex].Cells["Precio"].Value)*
                        Convert.ToDecimal(grdDetalleFactura.Rows[e.RowIndex].Cells["Cantidad"].Value)).ToString("N2");
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

                lblTotal.Text = total.ToString("N2");
            }
            catch(Exception)
            {
                return;
            }
        }

        //Solo numeros para columnas de la grilla
        private void grdDetalleFactura_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (grdDetalleFactura.SelectedCells.Count > 0)
            {
                if (e.ColumnIndex == 1)
                {
                    try
                    {
                        Convert.ToDecimal(e.FormattedValue);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Cantidad Invalida");
                        grdDetalleFactura.Rows[e.RowIndex].Cells["Cantidad"].Value = 0;
                    }
                }
            }
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cliente = ClientesController.DatosCliente(Convert.ToInt32(((Cliente)cmbRazonSocial.SelectedItem).idCliente));
                _idCliente = cliente.idCliente;
                var domicilio = cliente.Clientes_Domicilios.FirstOrDefault();
                _idDomicilio = domicilio.idDomicilio;

                txtDomicilio.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                txtProvincia.Text = domicilio.Provincia;
                txtCodPostal.Text = domicilio.CodPostal;
                txtCuit.Text = cliente.CUIT;
                txtCondIva.Text = cliente.CondicionIVA.ToString();
                txtClienteCod.Text = cliente.Codigo;
            }
            catch (Exception)
            {
                _LimpiarControles();
            }

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientesBuscador = new FrmClientesBuscador();
            var result = frmClientesBuscador.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                _RefrescarClientes();
                cmbRazonSocial.SelectedValue = frmClientesBuscador.ClienteSeleccionado.idCliente;
                var domicilio = frmClientesBuscador.DomicilioSeleccionado;
                _idDomicilio = domicilio.idDomicilio;

                txtDomicilio.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                txtProvincia.Text = domicilio.Provincia;
                txtCodPostal.Text = domicilio.CodPostal;
            }
        }

        private void lblNetoPagar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtSonPesos.Text = UtilNumerosALetras.Enletras(lblNetoPagar.Text);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void lblTotal_TextChanged(object sender, EventArgs e)
        {
            _CalcularTotales();
        }

        private void btnTipoValor_Click(object sender, EventArgs e)
        {
            if (btnTipoValor.Text == "$")
                btnTipoValor.Text = "%";
            else
                btnTipoValor.Text = "$";
            _CalcularTotales();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            double descuento;
            if (!Double.TryParse(txtDescuento.Text, out descuento))
            {
                MessageBox.Show("Valor Invalido");
                txtDescuento.Text = "0";
                return;
            }
            if (btnTipoValor.Text == "$")
            {
                if (Convert.ToDouble(lblTotal.Text) < descuento)
                {
                    MessageBox.Show("Valor invalido");
                    txtDescuento.Text = "0";
                }
            }
            else
            {
                if (descuento > 100)
                {
                    MessageBox.Show("Valor invalido");
                    txtDescuento.Text = "0";
                    return;
                }
            }
            _CalcularTotales();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _GuardarFactura();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLetra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbLetra.Text == "B")
                lblTotalIva.Text = "INCLUIDO";
            _RecalcularArticulos();
        }

        private void grdDetalleFactura_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleFactura.Rows.Count > MAX_FILAS)
            {
                MessageBox.Show("No se pueden agregar mas de " + MAX_FILAS + " lineas");
                grdDetalleFactura.AllowUserToAddRows = false;
            }
        }

        private void grdDetalleFactura_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdDetalleFactura.AllowUserToAddRows = true;
        }

        private void btnGuardarImprimir_Click(object sender, EventArgs e)
        {
            var idFactura = _GuardarFactura();
            if (idFactura > 0)
            {
                if (cmbLetra.Text == "A")
                    new FrmFacturaImprimir() {IdFactura = idFactura}.ShowDialog();
                else
                    new FrmFacturaBImprimir() {IdFactura = idFactura}.ShowDialog();
            }
        }

        private void CampoRequerido_Validating(object sender, CancelEventArgs e)
        {
            var control = (Control) sender;
            if(control.Text.Length == 0)
            {
                errorProviderRequerido.SetError(control, "Campo Requerido");
            }
            else
            {
                errorProviderRequerido.Clear();
            }
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = false;
            else if (Char.IsControl(e.KeyChar))
                e.Handled = false;
            else if (Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
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

        #region METODOS PRIVADOS

        private void _LimpiarControles()
        {
            cmbRazonSocial.Text = "";
            txtDomicilio.Text = "";
            txtLocalidad.Text = "";
            txtProvincia.Text = "";
            txtCodPostal.Text = "";
            txtCuit.Text = "";
            txtCondIva.Text = "";
            txtClienteCod.Text = "";
        }

        private void _CalcularTotales()
        {
            try
            {
                var totalBruto = Convert.ToDouble(lblTotal.Text);
                var descuento = Convert.ToDouble(txtDescuento.Text);
                if (btnTipoValor.Text == "$")
                    lblSubtotal.Text = (totalBruto - descuento).ToString("N2");
                else
                    lblSubtotal.Text = (totalBruto - (totalBruto * descuento / 100)).ToString("N2");

                if (cmbLetra.Text == "A")
                {

                    lblTotalIva.Text = (Convert.ToDouble(lblSubtotal.Text) * 0.21).ToString("N2");

                    lblNetoPagar.Text = (Convert.ToDouble(lblSubtotal.Text) + Convert.ToDouble(lblTotalIva.Text)).ToString("N2");
                }
                else
                {
                    lblTotalIva.Text = "INCLUIDO";
                    lblNetoPagar.Text = lblSubtotal.Text;
                }
            }
            catch (Exception)
            {
            }
        }

        private void _CargarControles()
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

            //Clientes
            _RefrescarClientes();

            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn)grdDetalleFactura.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetalleFactura.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

        }

        private void _RefrescarClientes()
        {
            cmbRazonSocial.DataSource = ClientesController.ListarClientes();
            cmbRazonSocial.ValueMember = "idCliente";
            cmbRazonSocial.DisplayMember = "RazonSocial";
            cmbRazonSocial.SelectedIndex = -1;
        }

        private decimal _CalcularPrecio(decimal precio)
        {
            if (cmbLetra.Text == "B")
                precio += Convert.ToDecimal(Convert.ToDouble(precio) * Convert.ToDouble(PorcentajeIVA) / 100);
            return precio;
        }

        private void _RecalcularArticulos()
        {
            foreach (DataGridViewRow row in grdDetalleFactura.Rows)
            {
                if (!row.IsNewRow)
                {
                    var codArticulo = row.Cells["Codigo"].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    row.Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                }
            }
        }

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtNumFactura.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbLetra.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbRazonSocial.Text))
                error = true;
            if (String.IsNullOrEmpty(txtDomicilio.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCuit.Text))
                error = true;
            if (grdDetalleFactura.Rows.Count == 0 || grdDetalleFactura.Rows[0].IsNewRow)
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos y almenos un artículo");

            return error;
        }

        private int _GuardarFactura()
        {
            if (_FaltaCampoRequerido())
                return 0;

            var factura = new Factura();

            factura.idCliente = _idCliente;
            factura.idDomicilioCliente = _idDomicilio;
            factura.FechaEmision = dtpFechaEmision.Value;
            factura.idTipoDocumento = Convert.ToInt32(cmbLetra.SelectedValue);
            factura.Numero = txtNumFactura.Text;
            factura.Remito = txtRemito.Text;
            factura.OrdenCompra = txtOrdenCompra.Text;
            factura.FechaVto = dtpVencimiento.Value;
            factura.Observaciones = txtObservaciones.Text;
            factura.Condiciones = txtCondiciones.Text;
            factura.SonPesos = txtSonPesos.Text;
            factura.Total = Convert.ToDecimal(lblTotal.Text);
            factura.Descuento = Convert.ToDecimal(txtDescuento.Text);
            factura.Subtotal = Convert.ToDecimal(lblSubtotal.Text);
            factura.TotalIVA = (cmbLetra.Text == "A") ? Convert.ToDecimal(lblTotalIva.Text) : 0;
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

            if (FacturasController.AgregarFactura(factura))
            {
                MessageBox.Show("Factura guardada correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar la factura, intentelo nuevamente");
            }
            return factura.idFactura;
        }

        #endregion

   }
}
