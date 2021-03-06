﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Conexco.Controller;
using Conexco.Model;
using Conexco.Utils;

namespace ConexcoFacturación
{
    public partial class FrmArticulos : Form
    {
        public ArticulosController ArticulosController { get; set; }

        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulosStock_Load(object sender, EventArgs e)
        {
            ArticulosController = new ArticulosController();
            _ActualizarGrilla();
        }

        private void _ActualizarGrilla()
        {
            _ActualizarGrilla(false);
        }

        private void _ActualizarGrilla(bool refresh)
        {
            var listadoArticulos = ArticulosController.ListarArticulos(refresh);

            grdArticulos.DataSource = listadoArticulos.ToDataTable();
            grdArticulos.Columns[0].Visible = false;
            grdArticulos.Columns[5].Visible = false;

            grdArticulos.Columns[2].HeaderText = "Cód.Color";
            grdArticulos.Columns[3].HeaderText = "Descripción";

            grdArticulos.Columns[1].Width = 70;
            grdArticulos.Columns[2].Width = 70;
            grdArticulos.Columns[3].Width = 280;
            grdArticulos.Columns[4].Width = 100;
            grdArticulos.Columns[5].Width = 100;
        }

        private void OnArticuloAgregar(object sender, EventArgs e)
        {
            var resultado = new FrmArticulosAlta().ShowDialog();
            if (resultado == DialogResult.OK)
                _ActualizarGrilla();
        }

        private void OnArticuloModificar(object sender, EventArgs e)
        {
            var idArticulo = Convert.ToInt32(grdArticulos.SelectedRows[0].Cells[0].Value);
            var result = new FrmArticulosAlta() { IdArticulo = idArticulo, Modificar = true}.ShowDialog();
            if (result == DialogResult.OK)
            {
                ArticulosController = new ArticulosController();
                _ActualizarGrilla();
            }
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            var idArticulo = Convert.ToInt32(grdArticulos.SelectedRows[0].Cells[0].Value);
            var result = new FrmArticulosAlta() { IdArticulo = idArticulo, Modificar = false }.ShowDialog();
            if (result == DialogResult.OK)
            {
                ArticulosController = new ArticulosController();
                _ActualizarGrilla();
            }
        }

        private void OnArticuloEliminar(object sender, EventArgs e)
        {
            var nombreArticulo = grdArticulos.SelectedRows[0].Cells[3].Value;
            var confirmacion = MessageBox.Show("Esta Seguro Desea Eliminar el Articulo: " + nombreArticulo + " ?", "Eliminar",
                                               MessageBoxButtons.YesNo);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    var idArticulo = Convert.ToInt32(grdArticulos.SelectedRows[0].Cells[0].Value);
                    if (ArticulosController.EliminarArticulo(idArticulo))
                    {
                        MessageBox.Show("Articulo eliminado satisfactoriamente");
                        ArticulosController = new ArticulosController();
                        _ActualizarGrilla();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al guardar el articulo, inténtelo de nuevo");
                    }
                }
                catch(Exception ex)
                {
                    ex.ToString();
                }
            }
        }

        private void OnArticuloSeleccionado(object sender, EventArgs e)
        {
            btnEliiminar.Enabled = grdArticulos.SelectedRows.Count > 0;
            btnModificar.Enabled = btnEliiminar.Enabled;
            btnDuplicar.Enabled = btnEliiminar.Enabled;
        }

        private void OnKeyPress_Busqueda(object sender, KeyPressEventArgs e)
        {
            var listaArticulos = new List<Articulo>();
            var teclaIngresada = e.KeyChar.ToString();
            var valorIngresado = (teclaIngresada == "\b")
                                                ? (txtValorBusqueda.Text.Length == 0
                                                                ? String.Empty
                                                                : txtValorBusqueda.Text.Substring(0, txtValorBusqueda.Text.Length - 1))
                                                : txtValorBusqueda.Text + teclaIngresada;

            if (String.IsNullOrEmpty((valorIngresado).Trim()))
            {
                listaArticulos = ArticulosController.ListarArticulos();
            }
            else
            {
                if (rbtnCodigoArticulo.Checked)
                {
                    listaArticulos =
                        ArticulosController.BuscadorPorCodigoArticulo(valorIngresado);
                }
                else
                {
                    listaArticulos = rbtnDescripcion.Checked ? ArticulosController.BuscadorPorDescripcion(valorIngresado)
                                                            : ArticulosController.BuscadorPorCódigoColor(valorIngresado);
                }
            }

            grdArticulos.DataSource = listaArticulos.ToDataTable();
        }

        private void btnPrecios_Click(object sender, EventArgs e)
        {
            var resultado = new FrmPrecios().ShowDialog();
            if (resultado == DialogResult.OK)
                _ActualizarGrilla(true);
        }
    }
}
