using ConexcoFacturación;

namespace ConexcoFacturación
{
    partial class FrmPresupuestoImprimir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPresupuestoImprimir));
            this.PresupuestoImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConexcoImpresionDataSet = new ConexcoFacturación.ConexcoImpresionDataSet();
            this.PresupuestoLineaImpresionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerPresupuesto = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PresupuestoImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoImpresionTableAdapter();
            this.PresupuestoLineaImpresionTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoLineaImpresionTableAdapter();
            this.PresupuestoImpresionCabeceraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PresupuestoImpresionCabeceraTableAdapter = new ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoImpresionCabeceraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoLineaImpresionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoImpresionCabeceraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PresupuestoImpresionBindingSource
            // 
            this.PresupuestoImpresionBindingSource.DataMember = "PresupuestoImpresion";
            this.PresupuestoImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // ConexcoImpresionDataSet
            // 
            this.ConexcoImpresionDataSet.DataSetName = "ConexcoImpresionDataSet";
            this.ConexcoImpresionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PresupuestoLineaImpresionBindingSource
            // 
            this.PresupuestoLineaImpresionBindingSource.DataMember = "PresupuestoLineaImpresion";
            this.PresupuestoLineaImpresionBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // reportViewerPresupuesto
            // 
            this.reportViewerPresupuesto.AutoSize = true;
            reportDataSource1.Name = "ConexcoImpresionDataSet_PresupuestoImpresion";
            reportDataSource1.Value = this.PresupuestoImpresionBindingSource;
            reportDataSource2.Name = "ConexcoImpresionDataSet_PresupuestoImpresionCabecera";
            reportDataSource2.Value = this.PresupuestoImpresionCabeceraBindingSource;
            reportDataSource3.Name = "ConexcoImpresionDataSet_PresupuestoLineaImpresion";
            reportDataSource3.Value = this.PresupuestoLineaImpresionBindingSource;
            this.reportViewerPresupuesto.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPresupuesto.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerPresupuesto.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewerPresupuesto.LocalReport.ReportEmbeddedResource = "ConexcoFacturación.Reportes.PresupuestoImpresion.rdlc";
            this.reportViewerPresupuesto.Location = new System.Drawing.Point(13, 13);
            this.reportViewerPresupuesto.Name = "reportViewerPresupuesto";
            this.reportViewerPresupuesto.ShowBackButton = false;
            this.reportViewerPresupuesto.ShowCredentialPrompts = false;
            this.reportViewerPresupuesto.ShowFindControls = false;
            this.reportViewerPresupuesto.ShowPageNavigationControls = false;
            this.reportViewerPresupuesto.Size = new System.Drawing.Size(743, 463);
            this.reportViewerPresupuesto.TabIndex = 0;
            // 
            // PresupuestoImpresionTableAdapter
            // 
            this.PresupuestoImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // PresupuestoLineaImpresionTableAdapter
            // 
            this.PresupuestoLineaImpresionTableAdapter.ClearBeforeFill = true;
            // 
            // PresupuestoImpresionCabeceraBindingSource
            // 
            this.PresupuestoImpresionCabeceraBindingSource.DataMember = "PresupuestoImpresionCabecera";
            this.PresupuestoImpresionCabeceraBindingSource.DataSource = this.ConexcoImpresionDataSet;
            // 
            // PresupuestoImpresionCabeceraTableAdapter
            // 
            this.PresupuestoImpresionCabeceraTableAdapter.ClearBeforeFill = true;
            // 
            // FrmPresupuestoImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 488);
            this.Controls.Add(this.reportViewerPresupuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPresupuestoImprimir";
            this.Text = "Impresión de Presupuesto A";
            this.Load += new System.EventHandler(this.FrmPresupuestoImprimir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConexcoImpresionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoLineaImpresionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresupuestoImpresionCabeceraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPresupuesto;
        private System.Windows.Forms.BindingSource PresupuestoImpresionBindingSource;
        private ConexcoImpresionDataSet ConexcoImpresionDataSet;
        private System.Windows.Forms.BindingSource PresupuestoLineaImpresionBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoImpresionTableAdapter PresupuestoImpresionTableAdapter;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoLineaImpresionTableAdapter PresupuestoLineaImpresionTableAdapter;
        private System.Windows.Forms.BindingSource PresupuestoImpresionCabeceraBindingSource;
        private ConexcoFacturación.ConexcoImpresionDataSetTableAdapters.PresupuestoImpresionCabeceraTableAdapter PresupuestoImpresionCabeceraTableAdapter;
    }
}