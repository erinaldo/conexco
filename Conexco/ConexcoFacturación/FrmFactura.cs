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

        private void lblNetoPagar_TextChanged(object sender, EventArgs e)
        {
            txtSonPesos.Text = Enletras(lblNetoPagar.Text);
        }

        public string Enletras(string num)
        {

           string res, dec = "";

           Int64 entero;

           int decimales;

           double nro;

           try

           {

               nro = Convert.ToDouble(num);

           }

           catch

           {

               return "";

           }

           entero = Convert.ToInt64(Math.Truncate(nro));

           decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

           if (decimales > 0)

           {

               dec = " CON " + decimales.ToString() + "/100";

           }

           res = ToText(Convert.ToDouble(entero)) + dec;

           return res;

        }

        private string ToText(double value)
       {

           string Num2Text = "";

           value = Math.Truncate(value);

           if (value == 0) Num2Text = "CERO";

           else if (value == 1) Num2Text = "UNO";

           else if (value == 2) Num2Text = "DOS";

           else if (value == 3) Num2Text = "TRES";

           else if (value == 4) Num2Text = "CUATRO";

           else if (value == 5) Num2Text = "CINCO";

           else if (value == 6) Num2Text = "SEIS";

           else if (value == 7) Num2Text = "SIETE";

           else if (value == 8) Num2Text = "OCHO";

           else if (value == 9) Num2Text = "NUEVE";

           else if (value == 10) Num2Text = "DIEZ";

           else if (value == 11) Num2Text = "ONCE";

           else if (value == 12) Num2Text = "DOCE";

           else if (value == 13) Num2Text = "TRECE";

           else if (value == 14) Num2Text = "CATORCE";

           else if (value == 15) Num2Text = "QUINCE";

           else if (value < 20) Num2Text = "DIECI" + ToText(value - 10);

           else if (value == 20) Num2Text = "VEINTE";

           else if (value < 30) Num2Text = "VEINTI" + ToText(value - 20);

           else if (value == 30) Num2Text = "TREINTA";

           else if (value == 40) Num2Text = "CUARENTA";

           else if (value == 50) Num2Text = "CINCUENTA";

           else if (value == 60) Num2Text = "SESENTA";

           else if (value == 70) Num2Text = "SETENTA";

           else if (value == 80) Num2Text = "OCHENTA";

           else if (value == 90) Num2Text = "NOVENTA";

           else if (value < 100) Num2Text = ToText(Math.Truncate(value / 10) * 10) + " Y " + ToText(value % 10);

           else if (value == 100) Num2Text = "CIEN";

           else if (value < 200) Num2Text = "CIENTO " + ToText(value - 100);

           else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = ToText(Math.Truncate(value / 100)) + "CIENTOS";

           else if (value == 500) Num2Text = "QUINIENTOS";

           else if (value == 700) Num2Text = "SETECIENTOS";

           else if (value == 900) Num2Text = "NOVECIENTOS";

           else if (value < 1000) Num2Text = ToText(Math.Truncate(value / 100) * 100) + " " + ToText(value % 100);

           else if (value == 1000) Num2Text = "MIL";

           else if (value < 2000) Num2Text = "MIL " + ToText(value % 1000);

           else if (value < 1000000)

           {

               Num2Text = ToText(Math.Truncate(value / 1000)) + " MIL";

               if ((value % 1000) > 0) Num2Text = Num2Text + " " + ToText(value % 1000);

           }

           else if (value == 1000000) Num2Text = "UN MILLON";

           else if (value < 2000000) Num2Text = "UN MILLON " + ToText(value % 1000000);

           else if (value < 1000000000000)

           {

               Num2Text = ToText(Math.Truncate(value / 1000000)) + " MILLONES ";

               if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + ToText(value - Math.Truncate(value / 1000000) * 1000000);

           }

           else if (value == 1000000000000) Num2Text = "UN BILLON";

           else if (value < 2000000000000) Num2Text = "UN BILLON " + ToText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

           else

           {

               Num2Text = ToText(Math.Truncate(value / 1000000000000)) + " BILLONES";

               if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + ToText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

           }

           return Num2Text;

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
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            CalcularTotales();
        }

        private void CalcularTotales()
        {
            var total = Convert.ToDouble(lblTotal.Text);
            var descuento = Convert.ToDouble(txtDescuento.Text);
            if(btnTipoValor.Text == "$")
                lblSubtotal.Text = (total - descuento).ToString();
            else
                lblSubtotal.Text = (total - (total * descuento / 100)).ToString();

            lblTotalIva.Text = (Convert.ToDouble(lblSubtotal.Text)*0.21).ToString();

            lblNetoPagar.Text = (Convert.ToDouble(lblSubtotal.Text) + Convert.ToDouble(lblTotalIva.Text)).ToString();
        }
   }


}
