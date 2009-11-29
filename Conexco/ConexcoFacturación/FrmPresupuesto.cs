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
    public partial class FrmPresupuesto : Form
    {
        public ClientesController ClientesController { get; set; }
        public LocalidadesController LocalidadesController { get; set; }
        public FiscalesController FiscalesController { get; set; }
        public EmpresaController EmpresaController { get; set; }
        public ArticulosController ArticulosController { get; set; }
        public FacturasController FacturasController { get; set; }
        public PresupuestoController PresupuestoController { get; set; }
        public decimal PorcentajeIVA { get; set; }

        private const int MAX_FILAS = 10;

        private int _idCliente;
        private int _idDomicilio;

        public FrmPresupuesto()
        {
            InitializeComponent();
        }

        private void FrmPresupuesto_Load(object sender, EventArgs e)
        {
            ClientesController = new ClientesController();
            LocalidadesController = new LocalidadesController();
            FiscalesController = new FiscalesController();
            EmpresaController = new EmpresaController();
            ArticulosController = new ArticulosController();
            FacturasController = new FacturasController();
            PresupuestoController = new PresupuestoController();

            _CargarControles();
        }

        private void grdDetallePresupuesto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (grdDetallePresupuesto.SelectedCells.Count > 0)
                {
                    if (e.ColumnIndex == 0)
                    {
                        var codArticulo = grdDetallePresupuesto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                        grdDetallePresupuesto.Rows[e.RowIndex].Cells["Precio"].Value = (articulo.Precio);
                        grdDetallePresupuesto.Rows[e.RowIndex].Cells["Descripcion"].Value = articulo.Descripcion;
                    }
                    else if (e.ColumnIndex == 2)
                    {
                        var descripcion = grdDetallePresupuesto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                        var articulo = ArticulosController.DatosArticuloPorDescripcion((descripcion));
                        grdDetallePresupuesto.Rows[e.RowIndex].Cells["Precio"].Value = (articulo.Precio);
                        grdDetallePresupuesto.Rows[e.RowIndex].Cells["Codigo"].Value = articulo.Codigo +
                                                                                   ((articulo.CodColor == null)
                                                                                        ? ""
                                                                                        : "-" + articulo.CodColor);
                    }
                    grdDetallePresupuesto.Rows[e.RowIndex].Cells["Totales"].Value =
                        (Convert.ToDecimal(grdDetallePresupuesto.Rows[e.RowIndex].Cells["Precio"].Value)*
                        Convert.ToDecimal(grdDetallePresupuesto.Rows[e.RowIndex].Cells["Cantidad"].Value)).ToString("N2");
                }

                double total = 0;
                foreach (DataGridViewRow row in grdDetallePresupuesto.Rows)
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

        private void grdDetallePresupuesto_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetallePresupuesto.SelectedCells.Count > 0)
            {
                if (e.ColumnIndex == 1)
                {
                    try
                    {
                        Decimal.Parse(grdDetallePresupuesto.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                    }
                    catch (Exception)
                    {
                        grdDetallePresupuesto.Rows[e.RowIndex].Cells["Cantidad"].Value = 0;
                    }
                }
            }
        }

        //Solo numeros para columnas de la grilla
        private void grdDetallePresupuesto_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //if (grdDetallePresupuesto.SelectedCells.Count > 0)
            //{
            //    if (e.ColumnIndex == 1)
            //    {
            //        try
            //        {
            //            Convert.ToDecimal(e.FormattedValue);
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Cantidad Invalida");
            //            grdDetallePresupuesto.Rows[e.RowIndex].Cells["Cantidad"].Value = 0;
            //        }
            //    }
            //}
        }

        private void cmbRazonSocial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var cliente = ClientesController.DatosCliente(Convert.ToInt32(((Cliente)cmbRazonSocial.SelectedItem).idCliente));
                _idCliente = cliente.idCliente;
                var domicilio = cliente.Clientes_Domicilios.FirstOrDefault();
                _idDomicilio = domicilio.idDomicilio;

                txtDomicilioEntrega.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                comboProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
                txtCodPostal.Text = domicilio.CodPostal;
                txtCuit.Text = cliente.CUIT;
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

                txtDomicilioEntrega.Text = domicilio.Domicilio;
                txtLocalidad.Text = domicilio.Localidad;
                comboProvincia.SelectedValue = LocalidadesController.DatosProvincia(domicilio.Provincia).idProvincia;
                txtCodPostal.Text = domicilio.CodPostal;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _GuardarPresupuesto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdDetallePresupuesto_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (grdDetallePresupuesto.Rows.Count > MAX_FILAS)
            {
                MessageBox.Show("No se pueden agregar mas de " + MAX_FILAS + " lineas");
                grdDetallePresupuesto.AllowUserToAddRows = false;
            }
        }

        private void grdDetallePresupuesto_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            grdDetallePresupuesto.AllowUserToAddRows = true;
        }

        private void btnGuardarImprimir_Click(object sender, EventArgs e)
        {
            var idPresupuesto = _GuardarPresupuesto();
            if (idPresupuesto > 0)
            {
                new FrmPresupuestoImprimir() {IdPresupuesto = idPresupuesto}.ShowDialog();
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

        private void _LimpiarControles()
        {
            cmbRazonSocial.Text = "";
            txtDomicilioEntrega.Text = "";
            txtLocalidad.Text = "";
            comboProvincia.Text = "";
            txtCodPostal.Text = "";
            txtCuit.Text = "";
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


            comboProvincia.DataSource = LocalidadesController.ListarProvincias();
            comboProvincia.DisplayMember = "Provincia1";
            comboProvincia.ValueMember = "idProvincia";

            //Clientes
            _RefrescarClientes();

            //Articulos
            var columnCodigo = (DataGridViewComboBoxColumn)grdDetallePresupuesto.Columns["Codigo"];
            columnCodigo.DataSource = ArticulosController.ListarCodigoYColorArticulos();

            var columnDescripcion = (DataGridViewComboBoxColumn)grdDetallePresupuesto.Columns["Descripcion"];
            columnDescripcion.DataSource = ArticulosController.ListarDescripcionArticulos();

        }

        private void _RefrescarClientes()
        {
            cmbRazonSocial.DataSource = ClientesController.ListarClientes();
            cmbRazonSocial.ValueMember = "idCliente";
            cmbRazonSocial.DisplayMember = "RazonSocial";
            cmbRazonSocial.SelectedIndex = -1;
        }

        private void _RecalcularArticulos()
        {
            foreach (DataGridViewRow row in grdDetallePresupuesto.Rows)
            {
                if (!row.IsNewRow)
                {
                    var codArticulo = row.Cells["Codigo"].Value.ToString();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(codArticulo);
                    row.Cells["Precio"].Value = (articulo.Precio);
                }
            }
        }

        private bool _FaltaCampoRequerido()
        {
            bool error = false;

            if (String.IsNullOrEmpty(txtNumPresupuesto.Text))
                error = true;
            if (String.IsNullOrEmpty(cmbRazonSocial.Text))
                error = true;
            if (String.IsNullOrEmpty(txtDomicilioEntrega.Text))
                error = true;
            if (String.IsNullOrEmpty(txtCuit.Text))
                error = true;
            if (grdDetallePresupuesto.Rows.Count == 0 || grdDetallePresupuesto.Rows[0].IsNewRow)
                error = true;

            if (error)
                MessageBox.Show("Ingrese los campos requeridos y almenos un artículo");

            return error;
        }

        private int _GuardarPresupuesto()
        {
            if (_FaltaCampoRequerido())
                return 0;

            var Presupuesto = new Presupuesto();

            Presupuesto.idCliente = _idCliente;
            Presupuesto.FechaEmision = dtpFechaEmision.Value;
            Presupuesto.Numero = txtNumPresupuesto.Text;
            Presupuesto.FechaVto = dtpVencimiento.Value;
            Presupuesto.Condiciones = txtCondiciones.Text;
            Presupuesto.Total = Convert.ToDecimal(lblTotal.Text);
            Presupuesto.DomicilioEntrega = txtDomicilioEntrega.Text;
            Presupuesto.LocalidadEntrega = txtLocalidad.Text;
            Presupuesto.ProvinciaEntrega = comboProvincia.Text;
            Presupuesto.CodPostalEntrega = txtCodPostal.Text;
            Presupuesto.Disponibilidad = txtDisponibilidad.Text;

            try
            {
                Presupuesto.idEstado = PresupuestoController.ListarDocumentosEstado().First().idEstado;
            }
            catch (Exception)
            {
                Presupuesto.idEstado = 1;
            }

            //Carga de lineas
            foreach (DataGridViewRow row in grdDetallePresupuesto.Rows)
            {
                if (!row.IsNewRow)
                {
                    var linea = new Presupuestos_Linea();
                    var articulo = ArticulosController.DatosArticuloPorCodigoYColor(row.Cells["Codigo"].Value.ToString());
                    linea.idArticulo = articulo.idArticulo;
                    linea.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    linea.Precio = articulo.Precio;

                    Presupuesto.Presupuestos_Lineas.Add(linea);
                }
            }

            if (PresupuestoController.AgregarPresupuesto(Presupuesto))
            {
                MessageBox.Show("Presupuesto guardado correctamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un problema al guardar el Presupuesto, inténtelo nuevamente");
            }
            return Presupuesto.idPresupuesto;
        }

        #endregion

        private void FrmPresupuesto_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("¿Realmente desea Cerrar el Presupuesto? Se perderán los cambios no guardados", "Atención",
                             MessageBoxButtons.OKCancel);
            if (result != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void btnLocalidad_Click(object sender, EventArgs e)
        {
            var frmLocalidades = new FrmLocalidades();
            var result = frmLocalidades.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtLocalidad.Text = frmLocalidades.LocalidadSeleccionada;
                txtCodPostal.Text = frmLocalidades.CodPostalSeleccionado;
                comboProvincia.SelectedValue = frmLocalidades.ProvinciaSeleccionada.idProvincia;
            }
        }
   }
}
