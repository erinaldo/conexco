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
        public decimal PorcentajeIVA { get; set; }

        private const int MAX_FILAS = 10;

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

            _CargarControles();
        }

        private void grdDetalleRemito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdDetalleRemito.SelectedCells.Count > 0)
                {
                    if (e.ColumnIndex == 2)
                    {
                        var codArticulo = grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                        grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                        grdDetalleRemito.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;

                        _VerificarStock(articulo, e.RowIndex);
                    }
                    else if (e.ColumnIndex == 3)
                    {
                        var descripcion = grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                        grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value = _CalcularPrecio(articulo.Precio);
                        grdDetalleRemito.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo + ((articulo.CodColor == null) ? "" : "-" + articulo.CodColor);
                    }
                    else if(e.ColumnIndex == 1)
                    {
                        if (grdDetalleRemito.Rows[e.RowIndex].Cells["Codigo"].Value != null)
                        {
                            var codArticulo = grdDetalleRemito.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                            var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                            _VerificarStock(articulo, e.RowIndex);
                        }
                    }
                    grdDetalleRemito.Rows[e.RowIndex].Cells["Totales"].Value =
                            (Convert.ToDecimal(grdDetalleRemito.Rows[e.RowIndex].Cells["Precio"].Value) *
                            Convert.ToDecimal(grdDetalleRemito.Rows[e.RowIndex].Cells["Unidades"].Value)).ToString("N2");
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

                lblTotal.Text = total.ToString("N2");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void grdDetalleRemito_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (grdDetalleRemito.SelectedCells.Count > 0)
            //{
            //    if (e.ColumnIndex == 1 || e.ColumnIndex == 0)
            //    {
            //        decimal numero = 0;
            //        if (!Decimal.TryParse(e.FormattedValue.ToString(), out numero))
            //        {
            //            grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
            //            e.Cancel = true;
            //        }
            //        //var index = e.ColumnIndex;
            //        //try
            //        //{
            //        //    Convert.ToDecimal(e.FormattedValue);
            //        //}
            //        //catch (Exception)
            //        //{
            //        //    //MessageBox.Show("Cantidad Invalida");
            //        //    grdDetalleRemito.Rows[e.RowIndex].Cells[index].Value = 0;
            //        //}
            //    }
            //}
        }

        private void grdDetalleRemito_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetalleRemito.SelectedCells.Count > 0)
            {
                if (e.ColumnIndex == 1 || e.ColumnIndex == 0)
                {
                    try
                    {
                        Decimal.Parse(grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    catch (Exception)
                    {
                        if (e.ColumnIndex == 0)
                            grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                        else
                            grdDetalleRemito.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                    }
                }
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            var frmClientesBuscador = new FrmClientesBuscador();
            var result = frmClientesBuscador.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                cmbRazonSocial.SelectedValue = frmClientesBuscador.ClienteSeleccionado.idCliente;
                var domicilio = frmClientesBuscador.DomicilioSeleccionado;

                txtDomicilio.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
                txtCodPostal.Text = domicilio.CodPostal;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _GuardarRemito();
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

        private void btnTransportistas_Click(object sender, EventArgs e)
        {
            if(_idCliente > 0)
            {
                var frmTransportistas = new FrmClientesTransportistas() { IdCliente = _idCliente, SeleccionHabilitada = true };
                var result = frmTransportistas.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    _idTransportista = frmTransportistas.TransportistaSeleccionado.idTransportista;
                    txtTransportistaRazonSocial.Text = frmTransportistas.TransportistaSeleccionado.Nombre;
                    txtTransportistaDomicilio.Text = frmTransportistas.TransportistaSeleccionado.Domicilio + " - " + frmTransportistas.TransportistaSeleccionado.Localidad + " - CP: " + frmTransportistas.TransportistaSeleccionado.CodPostal;
                    txtTransportistaCUIT.Text = frmTransportistas.TransportistaSeleccionado.CUIT;
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente primero");
            }
        }

        private void grdDetalleRemito_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if(grdDetalleRemito.Rows.Count > MAX_FILAS)
            {
                MessageBox.Show("No se pueden agregar mas de " + MAX_FILAS + " lineas");
                grdDetalleRemito.AllowUserToAddRows = false;
            }
        }

        private void grdDetalleRemito_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdDetalleRemito.AllowUserToAddRows = true;
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cliente = ClientesController.DatosCliente(Convert.ToInt32(((Cliente)cmbRazonSocial.SelectedItem).idCliente));
                _idCliente = cliente.idCliente;
                var domicilio = cliente.Clientes_Domicilios.FirstOrDefault();

                txtDomicilio.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                cmbProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
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

        private void btnGuardarImprimir_Click(object sender, EventArgs e)
        {
            int idRemito = _GuardarRemito();
            if (idRemito > 0)
                new FrmRemitoImprimir() {IdRemito = idRemito}.ShowDialog();
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

        #region METODOS PRIVADOS

        private int _GuardarRemito()
        {
            if (_FaltaCampoRequerido())
                return 0;

            var remito = new Remito();

            remito.idCliente = _idCliente;
            remito.FechaEmision = dtpFechaEmision.Value;
            remito.Numero = txtNumRemito.Text;
            remito.idTransportista = _idTransportista;
            remito.DomicilioEntrega = txtDomicilio.Text;
            remito.LocalidadEntrega = txtLocalidad.Text;
            remito.ProvinciaEntrega = cmbProvincia.Text;
            remito.CodPostalEntrega = txtCodPostal.Text;
            remito.OrdenCompra = txtOrdenCompra.Text;
            remito.CantBultos = Convert.ToInt32(txtCantBultos.Text);
            remito.Observaciones = txtObservaciones.Text;
            remito.Total = Convert.ToDecimal(lblTotal.Text);

            try
            {
                remito.idEstado = RemitosController.ListarDocumentosEstado().FirstOrDefault().idEstado;
            }
            catch (Exception)
            {
                remito.idEstado = 1;                
            }

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
                _ReducirStockArticulos();
                MessageBox.Show("Remito guardado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar el remito, inténtelo nuevamente");
            }

            return remito.idRemito;
        }

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtNumRemito.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbRazonSocial.Text))
                error = true;
            if (String.IsNullOrEmpty(txtDomicilio.Text))
                error = true;
            if (String.IsNullOrEmpty(txtLocalidad.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbProvincia.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCodPostal.Text))
                error = true;
            if (String.IsNullOrEmpty(txtTransportistaRazonSocial.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCuit.Text))
                error = true;
            if (grdDetalleRemito.Rows.Count == 0 || grdDetalleRemito.Rows[0].IsNewRow)
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos y almenos un artículo");

            return error;
        }

        private void _LimpiarControles()
        {
            cmbRazonSocial.Text = "";
            txtDomicilio.Text = "";
            txtLocalidad.Text = "";
            cmbProvincia.Text = "";
            txtCodPostal.Text = "";
            txtCuit.Text = "";
            txtCondIva.Text = "";
            txtClienteCod.Text = "";
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

            //Clientes
            cmbRazonSocial.DataSource = ClientesController.ListarClientes();
            cmbRazonSocial.ValueMember = "idCliente";
            cmbRazonSocial.DisplayMember = "RazonSocial";
            cmbRazonSocial.SelectedIndex = -1;

            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn)grdDetalleRemito.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetalleRemito.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

            //Provincias
            cmbProvincia.DataSource = LocalidadesController.ListarProvincias();
            cmbProvincia.ValueMember = "idProvincia";
            cmbProvincia.DisplayMember = "Provincia1";
        }

        private decimal _CalcularPrecio(decimal precio)
        {
            precio += Convert.ToDecimal(Convert.ToDouble(precio) * Convert.ToDouble(PorcentajeIVA) / 100);
            return precio;
        }

        private void _ReducirStockArticulos()
        {
            try
            {
                foreach (DataGridViewRow row in grdDetalleRemito.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        var codArticulo = row.Cells["Codigo"].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                        ArticulosController.ReducirStock(articulo.idArticulo, Convert.ToDecimal(row.Cells["Unidades"].Value));
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo reducir el stock correctamente");
            }

        }

        private void _VerificarStock(Articulo articulo, int roxIndex)
        {
            if (articulo != null)
            {
                decimal cantidad;
                if (
                    Decimal.TryParse(
                        Convert.ToString(grdDetalleRemito.Rows[roxIndex].Cells["Unidades"].Value),
                        out cantidad))
                {
                    if (articulo.Stock < cantidad)
                    {
                        MessageBox.Show("La cantidad ingresada supera el Stock del artículo, reduzca a " +
                                        articulo.Stock + " o agregue mas Stock");
                        return;
                    }
                }
            }
        }

        #endregion

        private void FrmRemito_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Realmente desea Salir? Se perderán los cambios no guardados", "Atención",
                                         MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }


    }
}
