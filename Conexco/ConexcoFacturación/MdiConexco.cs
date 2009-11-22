using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexco.Controller;

namespace ConexcoFacturación
{
    public partial class MdiConexco : Form
    {
        private int childFormNumber = 0;

        public MdiConexco()
        {
            InitializeComponent();
        }

        private void MdiConexco_Load(object sender, EventArgs e)
        {
            var empresa = new EmpresaController().DatosEmpresa();
            if (empresa == null)
            {
                MessageBox.Show("Bienvenido! Usted no tiene datos de su Empresa cargados, por favor ingreselos");
                new FrmEmpresa().ShowDialog();
            }
            else
            {
                //TODO: DESCOMENTAR CUANDO SE REQUIERA CONTRASEÑA
                //bool correcto = false;
                //for (int i = 0; i < 3; i++)
                //{
                //    var result = Inputbox.Show("Autenticación", "Ingrese su contraseña: ", FormStartPosition.CenterScreen);
                //    if (result == empresa.Contrasenia)
                //    {
                //        correcto = true;
                //        break;
                //    }
                //    MessageBox.Show("Contraseña incorrecta, inténtelo nuevamente");
                //}
                //if (!correcto)
                //{
                //    MessageBox.Show("Ha alcanzado el límite de intentos, el Sistema se cerrará");
                //    this.Close();
                //}
            }
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClientes(){MdiParent = this}.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLocalidades() { MdiParent = this }.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmArticulos() { MdiParent = this }.Show();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empresa = new EmpresaController().DatosEmpresa();

            if (empresa.PorcentajeIVA.HasValue && empresa.PorcentajeIVA.Value > 0)
            {
                new FrmFactura() { MdiParent = this, PorcentajeIVA = empresa.PorcentajeIVA.Value }.Show();
            }
            else
            {
                var result =
                        MessageBox.Show(
                            "Para crear una factura primero debe indicar el porcentaje de IVA, desea hacerlo ahora?",
                            "Atención", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new FrmEmpresa() { MdiParent = this }.Show();
                }
            }
        }

        private void remitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var empresa = new EmpresaController().DatosEmpresa();

            if (empresa.PorcentajeIVA.HasValue && empresa.PorcentajeIVA.Value > 0)
            {
                new FrmRemito() { MdiParent = this, PorcentajeIVA = empresa.PorcentajeIVA.Value }.Show();
            }
            else
            {
                var result =
                        MessageBox.Show(
                            "Para crear una factura primero debe indicar el porcentaje de IVA, desea hacerlo ahora?",
                            "Atención", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new FrmEmpresa() { MdiParent = this }.Show();
                }
            }
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmStock(){MdiParent = this}.Show();
        }

        private void salieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonLocalidades_Click(object sender, EventArgs e)
        {
            new FrmLocalidades(){MdiParent = this}.Show();
        }

        private void toolStripButtonStock_Click(object sender, EventArgs e)
        {
            new FrmStock() { MdiParent = this }.Show();
        }

        private void toolStripButtonArticulos_Click(object sender, EventArgs e)
        {
            new FrmArticulos() { MdiParent = this }.Show();
        }

        private void toolStripButtonClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes() { MdiParent = this }.Show();
        }

        private void toolStripButtonRemitos_Click(object sender, EventArgs e)
        {
            var empresa = new EmpresaController().DatosEmpresa();

            if (empresa.PorcentajeIVA.HasValue && empresa.PorcentajeIVA.Value > 0)
            {
                new FrmRemito() { MdiParent = this, PorcentajeIVA = empresa.PorcentajeIVA.Value }.Show();
            }
            else
            {
                var result =
                        MessageBox.Show(
                            "Para crear una factura primero debe indicar el porcentaje de IVA, desea hacerlo ahora?",
                            "Atención", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new FrmEmpresa() { MdiParent = this }.Show();
                }
            }
        }

        private void toolStripButtonFacturas_Click(object sender, EventArgs e)
        {
            var empresa = new EmpresaController().DatosEmpresa();

            if (empresa.PorcentajeIVA.HasValue && empresa.PorcentajeIVA.Value > 0)
            {
                new FrmFactura() { MdiParent = this, PorcentajeIVA = empresa.PorcentajeIVA.Value }.Show();
            }
            else
            {
                var result =
                        MessageBox.Show(
                            "Para crear una factura primero debe indicar el porcentaje de IVA, desea hacerlo ahora?",
                            "Atención", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    new FrmEmpresa() { MdiParent = this }.Show();
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEmpresa(){MdiParent = this}.Show();
        }
    }
}
